using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmTrackThread;
namespace frmTrackingThread
{
    public partial class Form1 : Form
    {


        private Thread ThreadA, ThreadB, ThreadC, ThreadD;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadStart delobjThread1 = new ThreadStart(MyThreadClass.Thread1);
                ThreadStart delobjThread2 = new ThreadStart(MyThreadClass.Thread2);

                Console.WriteLine("- Thread Start -");

                ThreadA = new Thread(delobjThread1);
                ThreadA.Name = "Thread A ";

                ThreadB = new Thread(delobjThread2);
                ThreadB.Name = "Thread B ";

                ThreadC = new Thread(delobjThread1);
                ThreadC.Name = "Thread C ";

                ThreadD = new Thread(delobjThread2);
                ThreadD.Name = "Thread D ";

                ThreadA.Priority = ThreadPriority.Highest;
                ThreadB.Priority = ThreadPriority.Normal;
                ThreadC.Priority = ThreadPriority.AboveNormal;
                ThreadD.Priority = ThreadPriority.BelowNormal;

                ThreadA.Start();
                ThreadB.Start();
                ThreadC.Start();
                ThreadD.Start();

                ThreadA.Join();
                ThreadB.Join();
                ThreadC.Join();
                ThreadD.Join();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Console.WriteLine("- Thread End -");
                label2.Text = "- Track End -";
            }
        }
    }
}
