using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace MusicClassificationBL
{
    public class SongClass
    {
        #region Members

        private BlockAlignReductionStream m_stream = null;
        private DirectSoundOut m_output = null;
        private WaveStream m_pcm = null;
        private SongType m_enmSongType;
        private string m_strFilePath; 
       
        
        #endregion

        #region Prop
        
        public float Volume
	    {
            get { return this.m_output.Volume; }
            set { this.m_output.Volume = value; }
	    }
	
        public string FilePath
        {
            get { return m_strFilePath; }
            set { m_strFilePath = value; }
        }


        public SongType Type
        {
            get { return m_enmSongType; }
            set { m_enmSongType = value; }
        }



        public TimeSpan Time
        {
            get { return m_pcm.CurrentTime; }
            set { m_pcm.CurrentTime = value; }
        }
        

        #endregion

        #region Ctor
        
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="FilePath"></param>
        public SongClass(string FilePath)
        {
            Init(FilePath);
            Id3v2Tag id3v2 = Id3v2Tag.ReadTag(this.m_pcm);
            
        } 

        #endregion

        #region Public Method
        /// <summary>
        /// init the Song 
        /// </summary>
        /// <param name="FilePath"></param>
        public void Init(string FilePath)
        {
            this.Dispose();
            m_strFilePath = FilePath;
            if (m_strFilePath.EndsWith(".mp3"))
            {
                m_enmSongType = SongType.MP3;
                m_pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(m_strFilePath));
                m_stream = new BlockAlignReductionStream(m_pcm);
            }
            else if (m_strFilePath.EndsWith(".wav"))
            {
                m_enmSongType = SongType.Wav;
                m_pcm = new WaveChannel32(new WaveFileReader(m_strFilePath));
                m_stream = new BlockAlignReductionStream(m_pcm);
            }
            else throw new InvalidOperationException("Not a correct audio file type.");

            m_output = new DirectSoundOut();
            m_output.Init(m_stream);
        }

        /// <summary>
        /// Get the music bytes
        /// </summary>
        /// <returns>return the amlitude wave</returns>
        public float[] GetMusicBytes()
        {
            WaveChannel32 wav = new WaveChannel32(m_pcm);
            ///every amplitoda build from 4 bytes
            float[] Wave = new float[wav.Length/4];
            byte[] buffer = new byte[short.MaxValue];
            int read = 0;
            ///read the song
            while (wav.Position < wav.Length)
            {
                for (int i = 0; i < read / 4; i++)
                {
                    float currSingle = BitConverter.ToSingle(buffer, i * 4);
                    Wave[i] = currSingle;
                }
            }
            return Wave;
        }

        /// <summary>
        /// play the song
        /// </summary>
        public void Play()
        {
            if (m_output.PlaybackState == PlaybackState.Paused || m_output.PlaybackState == PlaybackState.Stopped)
                m_output.Play();
        }

        #endregion

        #region Private Methods
        
        /// <summary>
        /// dispose
        /// </summary>
        private void Dispose()
        {
            if (m_output != null)
            {
                if (m_output.PlaybackState == PlaybackState.Playing) m_output.Stop();
                m_output.Dispose();
                m_output = null;
            }
            if (m_stream != null)
            {
                m_stream.Dispose();
                m_stream = null;
            }
        } 

        #endregion

        #region Enum
        
        public enum SongType
        {
            MP3,
            Wav
        } 

        #endregion
    }
}
