using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Dsp;

namespace MusicClassificationBL
{
    public static class ComplexExtensionMethods
    {
        public static float GetAmplitude(this Complex wavePlayer)
        {
            float result = 0;
            result = wavePlayer.X * wavePlayer.X + wavePlayer.Y*wavePlayer.Y;
            return result;
        }

        public static float GetFrequency(this Complex wavePlayer)
        {
            float result = 0;
            float Apm = GetAmplitude(wavePlayer);
            float F = (float)Math.Asin(wavePlayer.X / Apm);
            result = (float)(F / (2 * Math.PI));
            return result;
        }
    }
}
