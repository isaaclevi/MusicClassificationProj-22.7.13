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

        public float[] Wave
        {
            get { return m_SongWave; }
            set { m_SongWave = value; }
        }

        public SongVector(float[] SongWave)
        {
            this.m_SongWave = SongWave;
        }

    }
}
