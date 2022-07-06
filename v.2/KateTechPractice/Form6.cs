using System;
using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Form6 : Form
    {
        double[] x;
        double[] F;
        double eps1 = 0.00001, eps2 = 0.0000001;
        public Form6(double[]x, double []F)
        {
            InitializeComponent();
            this.x = x;
            this.F = F;
        }
        static int n = 11;
        double[] z = new double[n];
        int[] k = new int[n];
        double[] Fi= new double[n];

        public void FillDgv(double eps)
        {
           Hord(x, eps, z, Fi, k);
            //Newtone(x, eps1, z, Fi, k);
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "x";
            dgv.Columns[1].Name = "z";
            dgv.Columns[2].Name = "f";
            dgv.Columns[3].Name = "k";
            for (int i = 0; i < n; i++)
            {
                string[] row = { x[i].ToString(), z[i].ToString(), Fi[i].ToString(), k[i].ToString() };
                dgv.Rows.Add(row);                

            }
            chartN.Series[0].Points.Clear();
            chartN.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartN.Series[1].Points.Clear();
            chartN.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < n; i++)
            {
                chartN.Series[0].Points.AddXY(x[i], F[i]);
                chartN.Series[1].Points.AddXY(x[i], Fi[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDgv(eps1);
        }
  
        private static void Newtone(double[] arrayX, double eps, double[] z1, double[] fi1, int[] k1)
        {
            for (int i = 0; i < arrayX.Length; i++)
            {
                double z = arrayX[i], fi = f_i(arrayX, i, eps);
                int k = 0;
                double funcZValue = f(z, eps) - fi;
                while (Math.Abs(funcZValue) >= eps)
                {
                    z -= funcZValue - fi / g(z);
                    funcZValue = f(z, eps) - fi;
                    k++;
                }
                z1[i] = z;
                fi1[i] = fi;
                k1[i] = k;
            }
        }

        public static double f(double x, double eps)
        {
           
            int n = 0;
            double a = x, s1 = a, S = s1, q, s2;            
            while (Math.Abs(s1) > eps)
            {
                 q = ((-1) * (Math.Pow((Math.PI / 2), 2)) * (Math.Pow(x, 4)) * (4 * n + 1)) / ((2 * n + 1) * (2 * n + 2) * (4 * n + 5));
                s2 = q * s1;
                 S += s2;
                s1 = s2;
                 n++;
                
            }
            return S;
        }
    
        private static double g(double x)
        {
            return Math.Cos(Math.PI * Math.Pow(x, 2) / 2);
        }
        public static void Hord(double[] arrayX, double eps, double [] z1, double []fi1,int[]k1)
        {
            for (int i = 0; i < arrayX.Length; i++)
            {
                int k = 0;
                double z = arrayX[arrayX.Length - 2];
                if (i != arrayX.Length - 1)
                {
                    z = arrayX[i + 1];
                }
                double z0 = arrayX[i];
                double fi = f_i(arrayX, i, eps);
                double gZi = f(z, eps) - fi;
                double gZ0 = f(z0, eps) - fi;
                while (Math.Abs(gZi) > eps)
                {
                    z = ((z0 * gZi) - (z * gZ0)) / (gZi - gZ0);
                    gZi = f(z, eps) - fi;
                    k++;
                }
                
                z1[i] = z;
                fi1[i] = fi;
                k1[i] = k;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillDgv(eps2);
        }

        public static double f_i(double[] arrayX, int i, double eps)
        {
            double n = arrayX.Length;
            double x0 = arrayX[0];
            double xn = arrayX[arrayX.Length - 1];
            return f(x0, eps) + i * (f(xn, eps) - f(x0, eps)) / n;
        }

    }
}
