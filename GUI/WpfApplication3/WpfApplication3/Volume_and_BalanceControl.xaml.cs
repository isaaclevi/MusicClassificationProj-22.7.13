using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicClassificationGui
{
	/// <summary>
	/// Interaction logic for Volume_and_BalanceControl.xaml
	/// </summary>
	public partial class Volume_and_BalanceControl : UserControl
	{
        private double LeftMixerValue = 1.0;
        private double RightMixerValue = 1.0;

        public event Action<double> DockLeftVolumeChanged;
        public event Action<double> DockRightVolumeChanged;

		public Volume_and_BalanceControl()
		{
			this.InitializeComponent();
		}

        private void DockLeftSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double NewVolume = (100 * e.NewValue) / LeftValumeSlider.Maximum/100;
            NewVolume *= LeftMixerValue;
            if (this.DockLeftVolumeChanged!=null)
            {
                this.DockLeftVolumeChanged(NewVolume);
            }
        }

        private void DockRightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double NewVolume = (100 * e.NewValue) / RightVolumeSlider.Maximum;
            NewVolume *= RightMixerValue;
            if (this.DockRightVolumeChanged != null)
            {
                this.DockRightVolumeChanged(e.NewValue);
            }
        }


        private void MixerSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double center = MixerSlider.Maximum;
            LeftMixerValue = (100 * e.NewValue) / center / 100;
            double leftVolumeSlider = ((100 * LeftValumeSlider.Value) / LeftValumeSlider.Maximum / 100);
            double result = leftVolumeSlider * LeftMixerValue;
            if (this.DockLeftVolumeChanged != null)
            {
                this.DockLeftVolumeChanged(result);
            }
            RightMixerValue = (100 * (MixerSlider.Maximum - e.NewValue)) / center / 100;
            double rightVolumeSlider = ((100 * RightVolumeSlider.Value) / RightVolumeSlider.Maximum / 100);
            result = rightVolumeSlider * RightMixerValue;
            if (this.DockRightVolumeChanged != null)
            {
                this.DockRightVolumeChanged(result);
            }
        }

	}
}