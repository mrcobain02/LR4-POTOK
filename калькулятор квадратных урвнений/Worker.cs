using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace калькулятор_квадратных_урвнений
{
    public class Worker
    {
        private bool _stopload = false;
        public void Stop()
        {
            _stopload = true;
        }
        public void Work()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (_stopload)
                    break;
                Thread.Sleep(50);

                ProcessChanged(i);
            }
            WorkCompleted(_stopload);
        }
         public event Action<int> ProcessChanged;
         public event Action<bool> WorkCompleted;
        
    }
}
