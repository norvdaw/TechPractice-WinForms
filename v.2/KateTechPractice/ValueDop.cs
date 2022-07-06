using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KateTechPractice
{
    class ValueDop:Value
    {
        public ValueDop(double a, double b, double h, double eps)
        {
            this.a = a; this.b = b; this.h = h; this.eps = eps;
            int length = (int)((a + b) / h + 1);
            x = new double[length];
            f = new double[length];
            k = new double[length];
            TeilorSum();
        }
        public double[] polinom { get; set; }
        public double[] pogr { get; set; }
        public int KolvoUzlov { get; set; } = 5;
        public double N1(Func<double[]> fun, double x, int kolvoUzlov) //интерполяционный полином Ньютона
        {            
            double[] e = fun();
            double[] fe = new double[kolvoUzlov];
            TeilorSum(e, fe);
            double[] divDiff = new double[e.Length - 1];
            for (int i = 1; i < e.Length; i++)
            {
                divDiff[i - 1] = calculateDividedDifferences(e, fe, i);
            }
            double res = fe[0];
            for (int k = 1; k < e.Length; k++)
            {
                double P = 1;
                for (int j = 0; j < k; j++)
                {
                    P *= (x - e[j]);
                }
                res += divDiff[k - 1] * P;
            }
            return Math.Round(res, 6);
        }

        public double N1ch(double x, int kolvoUzlov) //интерполяционный полином Ньютона
        {
            double[] e = setCh();
            double[] fe = new double[kolvoUzlov];
            TeilorSum(e, fe);
            double[] divDiff = new double[e.Length - 1];
            for (int i = 1; i < e.Length; i++)
            {
                divDiff[i - 1] = calculateDividedDifferences(e, fe, i);
            }
            double res = fe[0];
            for (int k = 1; k < e.Length; k++)
            {
                double P = 1;
                for (int j = 0; j < k; j++)
                {
                    P *= (x - e[j]);
                }
                res += divDiff[k - 1] * P;
            }
            return Math.Round(res, 6);
        }
        public void DividedPolinomCh()
        {
            polinom = new double[x.Length];
            for (int i = 0; i < polinom.Length; i++)
            {
                polinom[i] = Math.Round(N1ch(x[i],KolvoUzlov), 8);
            }
        }
        public void DividedPolinom(Func<double[]> fun)
        {
            polinom = new double[x.Length];
            for(int i = 0; i < polinom.Length; i++)
            {
                polinom[i] = Math.Round(N1(fun, x[i], KolvoUzlov),8);
            }
        }

        public void DividedPogr()
        {
            pogr = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                pogr[i] = Math.Round((f[i] - polinom[i]), 8);
            }
        }
        public double[] setCh() //Расчет узлов для Чебышевской сетки
        {
            double res;
            double[] e = new double[(int)KolvoUzlov];
            double h = Math.Round((b - a) / e.Length, 3);
            e[0] = a + h / 2;            
            for (int i = 0; i < KolvoUzlov; i++)
            {
                res = ((b - a) / 2) * Math.Cos(((2 * i + 1) * Math.PI) / (2 * ((double)KolvoUzlov + 1))) + ((a + b) / 2);
                e[i] = res;
            }
            return e;
        }
        public double[] setNorm() //Расчет узлов для Норм
        {            
            double[] e = new double[KolvoUzlov];
            double h = Math.Round((b - a) / (double)KolvoUzlov, 3);
            e[0] = a + h / 2;
            for (int i = 1; i < KolvoUzlov; i++)
                e[i] = Math.Round(e[i - 1] + h, 3);
            return e;
        }
        public double calculateDividedDifferences(double[] x, double[] y, int k) //Произведение в полиноме Ньютона
        {
            double result = 0;
            for (int j = 0; j <= k; j++)
            {
                double mul = 1;
                for (int i = 0; i <= k; i++)
                {
                    if (j != i)
                    {
                        mul *= (x[j] - x[i]);
                    }
                }
                result += y[j] / mul;
            }
            return result;
        }
    }
}
