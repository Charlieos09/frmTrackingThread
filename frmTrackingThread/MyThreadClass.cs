using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    internal class MyThreadClass
    {
        public delegate void MyThreadDelegate();
        public static void Thread1()
        {
            for (int i = 0; i <= 1; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread" + thread.Name + " = " + i);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread" + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
