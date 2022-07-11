using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KateTechPractice
{
    class ApproximateFunction
    {
        public double a { get; set; } = 0; //начало интервала
        public double b { get; set; } = 1.5; // конец интервала
        public double step { get; set; } = 0.15;
        public double eps { get; set; } = 0.000001; //точность
        public double[] x { get; set; }
        public double[] f { get; set; } //значение функции в точке x
        public double[] count { get; set; } //количество слагаемых в ряде Тейлора для достижения точности eps
        public ApproximateFunction() { }
        public ApproximateFunction(double a, double b, double step, double eps)
        {
            this.a = a; this.b = b; this.step = step; this.eps = eps;
            int length = (int)((a + b) / step + 1);
            x = new double[length];
            f = new double[length];
            count = new double[length];
            CalculateTaylorSeries();
        }
        public void CalculateTaylorSeries()
        {
            FillArrayX(x);
            double an, res = 0;
            for (int i = 0; i < x.Length && i < 1000; i++)
            {
                an = 1;
                count[i] = 0;
                while (Math.Abs(an) > eps)
                {
                    an = (Math.Pow(-1, count[i]) * (Math.Pow(Math.PI / 2, 2 * count[i])) * 
                        Math.Pow(x[i], 4 * count[i] + 1)) / ((Factorial(2 * count[i]) * (4 * count[i] + 1)));
                    res += an;
                    count[i]++;
                }
                f[i] = Math.Round(res, 8);
                res = 0;
            }
        }
        public void CalculateTaylorSeries(double[] x, double[] f)
        {                     
            double an, res = 0;
            int t;
            for (int i = 0; i < f.Length; i++)
            {
                t = 0;
                an = 1;
                while (Math.Abs(an) > eps)
                {
                    an = (Math.Pow(-1, t) * Math.Pow(Math.PI / 2, 2 * t)) * 
                        Math.Pow(x[i], 4 * t + 1) / ((Factorial(2 * t) * (4 * t + 1)));
                    res += an;
                    t++;
                }
                f[i] = Math.Round(res, 8);
                res = 0;
            }
        }
        protected void FillArrayX(double[]x)
        {
            x[0] = a;
            for (int i = 1; i < x.Length; i++)
                x[i] = Math.Round(x[i - 1] + step, 3);
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
