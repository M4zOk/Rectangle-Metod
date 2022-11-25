using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        static double f(double x)
        {
            return (x / 4.5) * Math.Exp((Math.Pow(x, 2) * -1) / 8.2);
        }


        static double Priamougol(double a, double b, int n)
        {
            double result, h;

            h = (b - a) / n;
            result = 0.0;
            for (int i = 0; i <= n; i++)
            {
                result += f(a + h * (i - 0.5));
            }
            result *= h;
            return result;
        }



        private void raschet_btn_Click(object sender, EventArgs e)
        {

            double a2 , b2 , h2 = 1, y, x2;
            this.chart1.Series[0].Points.Clear();
            a2 = Convert.ToInt32(LeftGran.Text);
            b2 = Convert.ToInt32(RigntGran.Text);
            x2 = a2;
            while (a2 <= b2)
            {
                y = (x2 / 4.5) * Math.Exp((Math.Pow(x2, 2)* -1) / 8.2);
                this.chart1.Series[0].Points.AddXY(x2, y);
                x2 += h2;
                a2 += 1;
            }

            double a = 0, b = 3;
            int n;
            n = Convert.ToInt32(textBox1.Text);
            double z = Priamougol(a,b,n);
            Otvlbl.Text = z.ToString();
            
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
