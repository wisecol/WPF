using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomBarChart
{
    /// <summary>
    /// BarChart.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BarChart : UserControl, INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        private double _val;
        public double Value
        {
            get { return _val; }
            set
            {
                _val = value;
                UpdateBarHeight();
                NotifyPropertyChanged("value");
            }
        }

        private double maxVal;
        public double MaxVal
        {
            get { return maxVal; }
            set
            {
                maxVal = value;
                UpdateBarHeight();
                NotifyPropertyChanged("MaxVal");
            }
        }

        private double barHgt;
        public double BarHgt
        {
            get { return barHgt; }
            private set
            {
                barHgt = value;
                NotifyPropertyChanged("BarHgt");
            }
        }

        private Brush color;
        public Brush Color
        {
            get { return color; }
            set { color = value; NotifyPropertyChanged("color"); }
        }

        private void UpdateBarHeight()
        {
            if (MaxVal > 0)
            {
                var percent = (_val*100) / MaxVal;
                BarHgt = (percent * this.ActualHeight) / 100;
            }
        }

       
        public BarChart()
        {
            InitializeComponent();
            this.DataContext = this;
            Color=Brushes.Black;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateBarHeight();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateBarHeight() ;
        }
    }
}
