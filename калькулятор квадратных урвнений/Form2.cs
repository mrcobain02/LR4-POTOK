using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_квадратных_урвнений
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a, b, c;
            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);
            c = Convert.ToDouble(C.Text);
            double x1, x2;
            double disc;
            disc = Math.Pow(b, 2) - 4 * a * c;
            if (disc < 0)
            {
                label9.Text = Convert.ToString("Дискриминант < 0 корней нет");
                Disc.Text = Convert.ToString(disc);
                

            }
            if (disc == 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                X1.Text = Convert.ToString(x1);
                Disc.Text = Convert.ToString(disc);
            }
            else
            x1 = (-b + Math.Sqrt(disc)) / (2 * a);
            x2 = (-b - Math.Sqrt(disc)) / (2 * a);
            X1.Text=Convert.ToString("x1 = "+ x1);
            X2.Text = Convert.ToString("x2 = "+ x2);
            Disc.Text = Convert.ToString(disc);
            
           

        }

        
    }
}
