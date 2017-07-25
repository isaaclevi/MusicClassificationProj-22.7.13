using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;


namespace NAudioTest
{
    public partial class Form1 : Form
    {
        IWavePlayer waveOutDevice;
        WaveStream mainOutputStream;
        string fileName = null;

        public Form1()
        {
            InitializeComponent();
            Init();
            
        }


        public void Init()
        {

            try
            {
                waveOutDevice = new AsioOut();
            }
            catch (Exception driverCreateException)
            {
                MessageBox.Show(String.Format("{0}", driverCreateException.Message));
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Wave Files (*.wav)|*.wav|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }

            mainOutputStream = CreateInputStream(fileName);
        }

        private WaveStream CreateInputStream(string fileName)
        {
            WaveChannel32 inputStream;
            if (fileName.EndsWith(".wav"))
            {
                WaveStream readerStream = new WaveFileReader(fileName);
                if (readerStream.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                {
                    readerStream = WaveFormatConversionStream.CreatePcmStream(readerStream);
                    readerStream = new BlockAlignReductionStream(readerStream);
                }
                if (readerStream.WaveFormat.BitsPerSample != 16)
                {
                    var format = new WaveFormat(readerStream.WaveFormat.SampleRate,
                       16, readerStream.WaveFormat.Channels);
                    readerStream = new WaveFormatConversionStream(format, readerStream);
                }
                inputStream = new WaveChannel32(readerStream);
            }
            else
            {
                throw new InvalidOperationException("Unsupported extension");
            }
            return inputStream;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                waveOutDevice.Init(mainOutputStream);
            }
            catch (Exception initException)
            {
                MessageBox.Show(String.Format("{0}", initException.Message), "Error Initializing Output");
                return;
            }
            waveOutDevice.Play();
        }

    }
}
