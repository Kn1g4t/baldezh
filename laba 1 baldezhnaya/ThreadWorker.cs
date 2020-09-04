using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Laba_1_baldezhnaya
{
    public class ThreadWorker
    {
        public Thread thread { get; set; }

        public void Run()
        {
            thread.Start();
        }
        public void Func() 
        {
            
        }

        public ThreadWorker()
        {
            thread = new Thread(Func);
        }
    }
}
