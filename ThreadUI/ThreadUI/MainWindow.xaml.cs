using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace ThreadUI
{
    /// <summary>
    /// 외부 스레드에서 UI스레드를 제어하는 방법
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread _thread;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testBtn1_Click(object sender, RoutedEventArgs e)
        {
            _thread = new Thread(IncreaseNum);
            _thread.Start();
        }

        //Dispatcher로 감싸지 않을 경우 UI스레드의 개체를 _thread라는 외부스레드에서 컨트롤하려하면 오류 발생
        //WPF의 UI를 그리는 스레드는 STA(single-thread-apartment)로 
        //System.Windows.Threading.DispatcherObject를 통해 실현되어 UI를 그린 본인만 접근 가능
        private void IncreaseNum()
        {
            int i = 0;
            while (true)
            {
                //WPF에서는 DispatcherObject로 만든 자신의 스레드(MainWindow의 UI스레드)만 내부 UI개체들에 접근하여 내용을 수정
                //하지만 Dispatcher의 이벤트큐에 UI 변경할 로직을 넣어두면 UIThread도 제어가능.
                Dispatcher.Invoke(DispatcherPriority.Normal, new Action(() =>
                {
                    textBlk1.Text = (i + 1).ToString();
                }));
                i++;
                Thread.Sleep(300);
            }
        }

    }
}
