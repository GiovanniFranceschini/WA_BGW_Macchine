using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_BGW_Macchine
{
    public partial class Form1 : Form
    {
        //Dichiarazione backgroundworker
        BackgroundWorker bgw1;
        
        public Form1()
        {
            InitializeComponent();
           
        }

      

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            ptb_Car1.Location = new Point(151, 123);
            ptb_Car2.Location = new Point(151, 243);
            
        }


        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ptb_Car1.Bounds.IntersectsWith(pictureBox2.Bounds) && !ptb_Car2.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MessageBox.Show("Ha vinto la macchina 1");
                
            }
            if (!ptb_Car1.Bounds.IntersectsWith(pictureBox2.Bounds) && ptb_Car2.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MessageBox.Show("Ha vinto la macchina 2");
            }
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Random rnd = new Random(Environment.TickCount);
            if (!ptb_Car1.Bounds.IntersectsWith(pictureBox2.Bounds) && !ptb_Car2.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                ptb_Car1.Left += rnd.Next(3, 13);
                ptb_Car2.Left += rnd.Next(3, 13);
            }
            else if ((ptb_Car1.Location.X == 534 || ptb_Car1.Location.Y == 123) || (ptb_Car2.Location.X == 534 || ptb_Car2.Location.Y == 243))
            {
                bgw1.CancelAsync();
            }
            
            
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;

            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(100);
                bgw.ReportProgress(i);
                if (bgw.CancellationPending)
                {
                    return;
                }
            }
            
        }

        private void btn_Start_Click_1(object sender, EventArgs e)
        {
            //Creazione metodi backgroundworker
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            bgw1.RunWorkerAsync();
            

        }

        private void ptb_Car2_Click(object sender, EventArgs e)
        {

        }
    }
}
