using System;
using System.Windows.Forms;

namespace KateTechPractice
{    public partial class Form1 : Form
    {      
                  
        const double a = 0, b = 1.5, h = 0.15;
        const int n = 11, m = 5;
        static double[] x = new double[n];
        static double[] f = new double[n];       
        int[] k = new int[n];
        Form2 ff = new Form2(x, f, n, a, b); // Создание формы для Задания 2
        Form4 f4 = new Form4(x, f, n);
               
        public void TeilorSum(double[] x, double[] f, int [] k)
        {
            double eps = 0.000001;
            double an, res = 0;            
            for (int i = 0; i < x.Length && i < 1000; i++)
            {                
                an = 1;
                k[i] = 0;
                while (Math.Abs(an) > eps)
                {
                    an = (Math.Pow(-1, k[i]) * (Math.Pow(Math.PI / 2, 2 * k[i])) * Math.Pow(x[i], 4 * k[i] + 1)) / ((Factorial(2 * k[i]) * (4 * k[i] + 1)));
                    res += an;
                    k[i]++;
                }
                f[i] = Math.Round(res, 8);
                res = 0;
            }
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(x,f);
            f6.ShowDialog();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ff.ShowDialog();
        }
               
        public double Factorial(int numb)
        {
            double res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
               
        public Form1()
        {
            InitializeComponent();
            dgvTeilor.Rows.Clear();
            dgvTeilor.ColumnCount = 3;
            dgvTeilor.Columns[0].Name = "x";
            dgvTeilor.Columns[1].Name = "f";
            dgvTeilor.Columns[2].Name = "k";
      
            x[0] = a;
            for (int i = 1; i < x.Length; i++)
                x[i] = Math.Round(x[i - 1] + h, 3);
            TeilorSum(x, f, k);
           
            for (int i = 0; i < n; i++)
            {
                string[] row = { x[i].ToString(), f[i].ToString(), k[i].ToString() };
                dgvTeilor.Rows.Add(row);
            }
            chartTeilor.Series[0].Points.Clear();

            chartTeilor.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            for (int i = 0; i < n; i++)
            {
                chartTeilor.Series[0].Points.AddXY(x[i], f[i]);
            }
        }
    }
}