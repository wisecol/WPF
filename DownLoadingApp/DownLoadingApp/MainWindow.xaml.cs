using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DownLoadingApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        //progressbar에서 사용
        BackgroundWorker worker=null;

        public MainWindow()
        {
            InitializeComponent();
        }

        //다운로드 버튼 클릭 할 때
        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            if (worker == null)
            {
                worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.WorkerSupportsCancellation = true;
                worker.DoWork += worker_DoWork;
                worker.ProgressChanged += worker_ProgressChanged;
                worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                //호출하여 시작
                worker.RunWorkerAsync();
            }            
        }

        //실행
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        { 
            for(int i=0; i<100; i++)
            {
                worker.ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        //progress 리포트 
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bar.Value = e.ProgressPercentage;
        }

        //작업 완료
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bar.Value = bar.Maximum;
        }

    }
}
