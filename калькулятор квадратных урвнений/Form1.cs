using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace калькулятор_квадратных_урвнений
{
    public partial class Form1 : Form
    {
        private Worker _worker;
        public Form1()
        {
            InitializeComponent();

            startload.Click += startload_Click; // название старта
            stopload.Click += stopload_Click;  // название кнопки стоп
        }
        
        private void startload_Click(object sender, EventArgs e)
        {
            _worker = new Worker();
            _worker.ProcessChanged += worker_ProcessChanged;
            _worker.WorkCompleted += _worker_WorkCompleted;

            

            Thread thread = new Thread(_worker.Work);
            thread.Start();
        }

        private void stopload_Click(object sender, EventArgs e)
        {

            

        }

        private void _worker_WorkCompleted(bool stopload)
        {
            
            Action action = () =>
            {

                Form2 newForm = new Form2();
                newForm.Show();


            };
            
            Invoke(action);
        }

        private void worker_ProcessChanged(int progress)
        {
            Action action = () => { progressBar1.Value = progress; };
            
            Invoke(action);
        }
    }
    
}
