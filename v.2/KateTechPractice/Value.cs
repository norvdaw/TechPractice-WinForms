using System;
using System.Windows.Forms;

namespace KateTechPractice
{
    class Value
    {
        public double a { get; set; } = 0;
        public double b { get; set; } = 1.5;
        public double h { get; set; } = 0.15;
        public double eps { get; set; } = 0.000001;
        public double[] x { get; set; }
        public double[] f { get; set; }
        public double[] k { get; set; }
        public Value() { }
        public Value(double a, double b, double h, double eps)
        {
            this.a = a; this.b = b; this.h = h; this.eps = eps;
            int length = (int)((a + b) / h + 1);
            x = new double[length];
            f = new double[length];
            k = new double[length];
            TeilorSum();
        }
        public void TeilorSum()
        {
            FillArrayX(x);
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
        public void TeilorSum(double[] x, double[] f)
        {                     
            double an, res = 0;
            int t;
            for (int i = 0; i < x.Length; i++)
            {
                t = 0;
                an = 1;
                while (Math.Abs(an) > eps)
                {
                    an = (Math.Pow(-1, t) * Math.Pow(Math.PI / 2, 2 * t)) * Math.Pow(x[i], 4 * t + 1) / ((Factorial(2 * t) * (4 * t + 1)));
                    res += an;
                    t++;
                }
                f[i] = Math.Round(res, 8);
                res = 0;
            }
        }
        public void FillChart(System.Windows.Forms.DataVisualization.Charting.Chart t, double[] X, double[] Y)
        {
            t.Series[0].Points.Clear();
            t.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < X.Length; i++)
            {
                t.Series[0].Points.AddXY(X[i], Y[i]);
            }
        }
        public void FillDgv(DataGridView t, string[] ColumnName,int Length, params double[][] arr)
        {
            t.Rows.Clear();
            t.ColumnCount = ColumnName.Length;
            for(int i = 0; i< ColumnName.Length; i++)
            {
                t.Columns[i].Name = ColumnName[i];
            }

            //for (int i = 0; i < arr.Length; i++)

            for (int i = 0; i < Length; i++)
            {
                string[] row = new string[arr.Length];
                for (int j = 0; j < arr.Length; j++)
                {
                    
                    row[j] = arr[j][i].ToString();
                    //string[] row = { j.ToString()};

                    //string[] row = { x[i].ToString(), f[i].ToString(), k[i].ToString() };                
                    
                }
                t.Rows.Add(row);

            }
        }
        private void FillArrayX(double[]x)
        {
            x[0] = a;
            for (int i = 1; i < x.Length; i++)
                x[i] = Math.Round(x[i - 1] + h, 3);
        }
        private double Factorial(double numb)
        {
            double res = 1;
            for (int i = (int)numb; i > 1; i--)
                res *= i;
            return res;
        }
    }
}
