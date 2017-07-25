using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicClassificationAlgotihm;

namespace MusicClassificationBL
{
    public class SongVector : IPoint<SongVector>
    {
        private float[] m_SongWave;
        private SongClass m_song;

        public SongClass Song
        {
            get { return m_song; }
            set { m_song = value; }
        }


        public float[] Wave
        {
            get { return m_SongWave; }
            set { m_SongWave = value; }
        }

        public SongVector(float[] SongWave)
        {
            this.m_SongWave = SongWave;
        }

        public float GetMin()
        {
            float Min = this.Wave[0];
            for (int i = 1; i < 96; i++)
            {
                if (this.Wave[i] < Min) Min = this.Wave[i];
            }
            return Min;
        }

        public float GetMax()
        {
            float Max = this.Wave[0];
            for (int i = 1; i < 96; i++)
            {
                if (this.Wave[i] > Max) Max = this.Wave[i];
            }
            return Max;
        }

        public int Lenght {
            get { 
                return this.m_SongWave.Length;
            }
        }

        public override string ToString()
        {
            return this.Song.ToString();
        }
    }
    
}
