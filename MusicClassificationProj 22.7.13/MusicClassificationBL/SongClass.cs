using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;  
using TagLib;
using NAudio.Wave.SampleProviders;
using NAudio.Dsp;
using System.Timers;

namespace MusicClassificationBL 
{
    public class SongClass : INotifyPropertyChanged 
    {
        #region Members

        //private BlockAlignReductionStream m_stream = null;
        private IWavePlayer m_output = null;
        //private WaveStream m_pcm = null;
        private SongType m_enmSongType;
        private string m_strFilePath;
        private SongProp m_propertys;
        //private readonly SampleAggregator aggregator;
        private AudioFileReader m_AudioFileReader;
        //private WaveChannel32 m_waveChannel;
        private Timer timer;

        

        #endregion

        #region Prop

        public bool PerformFFT { get; set; }

        public SongProp Property
        {
            get { return m_propertys; }
        }
        
        public string FileName
        {
            get { return m_strFilePath; }
            set
            {
                m_strFilePath = value;
                
            }
        }
        
        public float Volume
	    {
            get {
                if (this.m_output!=null)
                {
                    return this.m_AudioFileReader.Volume;                    
                }
                return 0;
            }
            set {
                this.m_AudioFileReader.Volume = value;
                OnPropertyChanged(this, "Volume");
            }
	    }
        
        public SongType Type
        {
            get { return m_enmSongType; }
            set { m_enmSongType = value; }
        }

        public TimeSpan Duration
        {
            get { return this.m_AudioFileReader.TotalTime - this.m_AudioFileReader.CurrentTime; }
            set { }
        }

        public TimeSpan CurrentTime
        {
            get { return this.m_AudioFileReader.CurrentTime; }
        }

        public long SongLength
        {
            get { return this.m_AudioFileReader.Length; }
        }
        
        #endregion

        #region Ctor
        
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="FilePath"></param>
        public SongClass(string FilePath)
        {
            this.m_propertys = new SongProp(FilePath);
            this.PerformFFT = true;
            Init(FilePath);
        }

        public SongClass(SongProp sp)
        {
            this.m_propertys = sp;
            this.PerformFFT = true;
            Init(sp.Name);
        }

        #endregion
 
        #region Public Method

        public override string ToString()
        {
            return this.m_strFilePath;
        }


        /// <summary>
        /// init the Song 
        /// </summary>
        /// <param name="FilePath"></param>
        public void Init(string FilePath)
        {
            m_strFilePath = FilePath;

            timer = new Timer();
            timer.Interval = 10;
            timer.Elapsed += timer_Elapsed;
            

            try
            {
                if (m_strFilePath.EndsWith(".mp3"))
                {
                    m_enmSongType = SongType.MP3;
                }
                else if (m_strFilePath.EndsWith(".wav"))
                {
                    m_enmSongType = SongType.Wav;
                }
                else throw new InvalidOperationException("Not a correct audio file type.");
                this.m_AudioFileReader = new AudioFileReader(FilePath);
                m_output = new DirectSoundOut();
                m_output.Init(this.m_AudioFileReader);
                this.m_output.PlaybackStopped += m_output_PlaybackStopped;
                timer.Start();
            }
            catch (Exception e)
            {
                this.m_enmSongType = SongType.Error;
                this.Dispose();

            }
        }

        /// <summary>
        /// Get the music bytes
        /// </summary>
        /// <returns>return the amlitude wave</returns>
        public SongVector GetMusicWave(TimeSpan StartTime, TimeSpan PlayingTime)
        {

            TimeSpan endTime = StartTime + PlayingTime;
            this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);
            this.m_AudioFileReader.CurrentTime = StartTime;
            
            ///every amplitoda build from 4 bytes
            int fftLength = 1024;
            float[] Spectrom = new float[fftLength];
            Complex[] fftBuffer = new Complex[fftLength];
            List<float> songSpectrom = new List<float>();
            int fftPos = 0;
            int read = 0;
            
            ///read the song
            while (this.m_AudioFileReader.Position < this.m_AudioFileReader.Length && this.m_AudioFileReader.CurrentTime < endTime)
            {
                read = m_AudioFileReader.Read(Spectrom, 0, fftLength);
                if (PerformFFT)
                {
                    for (int i = 0; i < read; i++)
                    {
                        fftBuffer[fftPos].X = (float)(Spectrom[i] * FastFourierTransform.HammingWindow(fftPos, fftBuffer.Length));
                        fftBuffer[fftPos].Y = 0;
                        fftPos++;
                        if (fftPos >= fftBuffer.Length)
                        {
                            fftPos = 0;
                            // 1024 = 2^10
                            FastFourierTransform.FFT(true, (int)Math.Log(fftLength, 2.0), fftBuffer);
                            songSpectrom.AddRange(fftBuffer.Select(x=>x.X));
                        }
                    }

                }
            
            }

            SongVector sv = new SongVector(songSpectrom.ToArray());
            sv.Song = this;
            this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);
            return sv;
        }

        public SongVector GetMusicVector( )
        {
            SongVector sv = null;
            TimeSpan PlayingTime = new TimeSpan(0, 0, 3);
            this.m_AudioFileReader.CurrentTime = new TimeSpan(this.m_AudioFileReader.TotalTime.Ticks / 2);
            //sv = GetMusicAvgThresVector(PlayingTime);
            sv = GetMusicAvgVector(PlayingTime);
            //sv = GetMusicBineryVector(PlayingTime);
            return sv;
        }

        /// <summary>
        /// play the song
        /// </summary>
        public void Play()
        {
            if (m_output.PlaybackState == PlaybackState.Paused || m_output.PlaybackState == PlaybackState.Stopped)
            {
                m_output.Play();
                this.m_bIsPlaying = true;
            }
        }

        /// <summary>
        /// play the song
        /// </summary>
        public void Pause()
        {
            if (m_output.PlaybackState == PlaybackState.Playing)
            {
                m_output.Pause();
                this.m_bIsPlaying = false;
            }
        }

        /// <summary>
        /// play the song
        /// </summary>
        public void Stop()
        {
            if (m_output.PlaybackState == PlaybackState.Paused || m_output.PlaybackState == PlaybackState.Playing)
            {
                m_output.Stop();
                this.m_bIsPlaying = false;
            }
        }

        public void Dispose()
        {
            if (this.timer!=null)
            {
                this.timer.Stop();
                this.timer.Dispose();    
            }
            

            if (this.m_AudioFileReader != null)
            {
                this.m_AudioFileReader.Dispose();
            }

            if (this.m_output!=null)
            {
                this.m_output.Dispose();
            }
        }
        #endregion

        #region Private methods

        /// <summary>
        /// Get the music bytes
        /// </summary>
        /// <returns>return the amlitude wave</returns>
        private SongVector GetMusicAvgVector( TimeSpan PlayingTime)
        {

            if (this.m_AudioFileReader!=null)
            {
                TimeSpan endTime = this.m_AudioFileReader.CurrentTime + PlayingTime;
                //this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);
                //this.m_AudioFileReader.CurrentTime = StartTime;

                ///every amplitoda build from 4 bytes
                int fftLength = 1024;
                float[] Spectrom = new float[fftLength];
                Complex[] fftBuffer = new Complex[fftLength];
                float[] AvgVector = new float[fftLength];
                int fftPos = 0;
                int read = 0;

                ///read the song
                int couter = 0;
                while (this.m_AudioFileReader.Position < this.m_AudioFileReader.Length && this.m_AudioFileReader.CurrentTime < endTime)
                {
                    read = m_AudioFileReader.Read(Spectrom, 0, fftLength);
                    if (PerformFFT)
                    {
                        for (int i = 0; i < read; i++)
                        {
                            fftBuffer[fftPos].X = (float)(Spectrom[i] * FastFourierTransform.HammingWindow(fftPos, fftBuffer.Length));
                            fftBuffer[fftPos].Y = 0;
                            fftPos++;
                            if (fftPos >= fftBuffer.Length)
                            {
                                fftPos = 0;
                                // 1024 = 2^10
                                FastFourierTransform.FFT(true, (int)Math.Log(fftLength, 2.0), fftBuffer);

                                couter++;
                                for (int j = 0; j < fftLength; j++)
                                {
                                    AvgVector[j] += fftBuffer[j].GetAmplitude();
                                }

                            }
                        }
                    }
                }
                for (int i = 0; i < fftLength; i++)
                {
                    AvgVector[i] = AvgVector[i] / couter;
                }
                SongVector sv = new SongVector(AvgVector);
                sv.Song = this;
                this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);

                return sv; 
            }
            return null;
        }
        
        /// <summary>
        /// Get the music bytes
        /// </summary>
        /// <returns>return the amlitude wave</returns>
        private SongVector GetMusicBineryVector( TimeSpan PlayingTime)
        {

            if (this.m_AudioFileReader!=null)
            {
                TimeSpan endTime = this.m_AudioFileReader.CurrentTime + PlayingTime;
                //this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);
                //this.m_AudioFileReader.CurrentTime = StartTime;

                ///every amplitoda build from 4 bytes
                int fftLength = 1024;
                float[] Spectrom = new float[fftLength];
                Complex[] fftBuffer = new Complex[fftLength];
                float[] AvgVector = new float[fftLength];
                int fftPos = 0;
                int read = 0;

                ///read the song
                int couter = 0;
                while (this.m_AudioFileReader.Position < this.m_AudioFileReader.Length && this.m_AudioFileReader.CurrentTime < endTime)
                {
                    read = m_AudioFileReader.Read(Spectrom, 0, fftLength);
                    if (PerformFFT)
                    {
                        for (int i = 0; i < read; i++)
                        {
                            fftBuffer[fftPos].X = (float)(Spectrom[i] * FastFourierTransform.HammingWindow(fftPos, fftBuffer.Length));
                            fftBuffer[fftPos].Y = 0;
                            fftPos++;
                            if (fftPos >= fftBuffer.Length)
                            {
                                fftPos = 0;
                                // 1024 = 2^10
                                FastFourierTransform.FFT(true, (int)Math.Log(fftLength, 2.0), fftBuffer);

                                bool IncCounter = false;
                                for (int j = 0; j < fftLength; j++)
                                {
                                    if (fftBuffer[j].GetAmplitude() >= 0.00005)
                                    {
                                        IncCounter = true;
                                        AvgVector[j] += 1;
                                    }
                                }
                                if (IncCounter)
                                {
                                    couter++;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < fftLength; i++)
                {
                    AvgVector[i] = AvgVector[i] / couter;
                }
                SongVector sv = new SongVector(AvgVector);
                sv.Song = this;
                this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);

                return sv; 
            }
            return null;
        }
        
        /// <summary>
        /// Get the music bytes
        /// </summary>
        /// <returns>return the amlitude wave</returns>
        private SongVector GetMusicAvgThresVector( TimeSpan PlayingTime)
        {
            if (this.m_AudioFileReader != null)
            {

                TimeSpan endTime = this.m_AudioFileReader.CurrentTime + PlayingTime;
                
                //this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);
                //this.m_AudioFileReader.CurrentTime = StartTime;

                ///every amplitoda build from 4 bytes
                int fftLength = 1024;
                float[] Spectrom = new float[fftLength];
                Complex[] fftBuffer = new Complex[fftLength];
                float[] AvgVector = new float[fftLength];
                int fftPos = 0;
                int read = 0;

                ///read the song
                int couter = 0;
                while (this.m_AudioFileReader.Position < this.m_AudioFileReader.Length && this.m_AudioFileReader.CurrentTime < endTime)
                {
                    read = m_AudioFileReader.Read(Spectrom, 0, fftLength);
                    if (PerformFFT)
                    {
                        for (int i = 0; i < read; i++)
                        {
                            fftBuffer[fftPos].X = (float)(Spectrom[i] * FastFourierTransform.HammingWindow(fftPos, fftBuffer.Length));
                            fftBuffer[fftPos].Y = 0;
                            fftPos++;
                            if (fftPos >= fftBuffer.Length)
                            {
                                fftPos = 0;
                                // 1024 = 2^10
                                FastFourierTransform.FFT(true, (int)Math.Log(fftLength, 2.0), fftBuffer);

                                bool IncCounter = false;
                                for (int j = 0; j < fftLength; j++)
                                {
                                    float FftAMP = fftBuffer[j].GetAmplitude();
                                    if (FftAMP >= 0.00005)
                                    {
                                        IncCounter = true;
                                        AvgVector[j] += FftAMP;
                                    }
                                }
                                if (IncCounter)
                                {
                                    couter++;
                                }


                            }
                        }
                    }
                }
                for (int i = 0; i < fftLength; i++)
                {
                    AvgVector[i] = AvgVector[i] / couter;
                }
                SongVector sv = new SongVector(AvgVector);
                sv.Song = this;
                this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);

                return sv;
            }
            return null;
        } 
        #endregion

        #region Enum

        public enum SongType
        {
            MP3,
            Wav,
            Error,
            wma
        } 

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;
        public event Action SongEnded;
        public event Action SongEnd
        {
            add { this.SongEnded += value; }
            remove { this.SongEnded -= value; }
        }
        private bool m_bIsPlaying;

        #endregion

        #region Event Methods

        void m_output_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            this.m_bIsPlaying = false;

        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (PropertyChanged != null && this.m_output.PlaybackState == PlaybackState.Playing)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("CurrentTime"));
                PropertyChanged(this, new PropertyChangedEventArgs("Duration"));
            }
            if (this.SongEnded != null && this.m_output.PlaybackState == PlaybackState.Stopped && this.Duration == TimeSpan.Zero)
            {
                this.m_AudioFileReader.CurrentTime = new TimeSpan(0, 0, 0);
                this.SongEnded();
            }
        }

        private void OnPropertyChanged(object sender, string PropName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender, new PropertyChangedEventArgs(PropName));
            }
        } 
        #endregion
    }

}

