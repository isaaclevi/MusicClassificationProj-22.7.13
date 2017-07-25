using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace MusicClassificationBL
{
    public class SongAction
    {

        /// <summary>
        /// Convert mp3 file to Wave file
        /// </summary>
        /// <param name="MP3FilePath">Exist mp3 file path</param>
        /// <param name="WaveFilePath">the wav file path</param>
        /// <returns></returns>
        public void ConvertMP3ToWav(string MP3FilePath,string WaveFilePath)
        {
            try
            {
                if (!MP3FilePath.EndsWith(".mp3"))
                {
                    throw new Exception("not mp3 file");
                }
                if (!WaveFilePath.EndsWith(".wav"))
                {
                    throw new Exception("not wav file");
                }

                using (Mp3FileReader mp3 = new Mp3FileReader(MP3FilePath))
                {
                    using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                    {
                        WaveFileWriter.CreateWaveFile(WaveFilePath, pcm);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        /// Convert mp3 file to Wave file
        /// </summary>
        /// <param name="MP3FilePath">Exist mp3 file path</param>
        /// <param name="WaveFilePath">the wav file path</param>
        /// <returns></returns>
        public void ConvertWavToMp3(string MP3FilePath, string WaveFilePath)
        {
            try
            {
                if (!WaveFilePath.EndsWith(".wav"))
                {
                    throw new Exception("not wav file");
                }
                if (!MP3FilePath.EndsWith(".mp3"))
                {
                    throw new Exception("not mp3 file");
                }


                using (WaveFileReader wav = new WaveFileReader(WaveFilePath))
                {
                    
                    using (NAudio.Wave. pcm = WaveFormatConversionStream.CreatePcmStream(wav))
                    {
                        WaveFileWriter.CreateWaveFile(WaveFilePath, pcm);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
