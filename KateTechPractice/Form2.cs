using System;
using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Form2 : Form
    {
        int n;       
        double[] x;
        double[] f;
        double a, b; 
        
        public Form2(double[] x, double[] f, int n, double a, double b)
        {
            InitializeComponent();
            //Обрабатываем данные           
            this.x = x;
            this.f = f;
            this.n = n;
            this.a = a;
            this.b = b;
        }        
     
        private void button1_Click(object sender, EventArgs e)
        {
            //Производим расчет
            int m = int.Parse(txtM.Text);
            double[] polinom = new double[n];
            double[] pogr = new double[n];
            double[] polinomCh = new double[n];
            double[] pogrCh = new double[n];
            for (int i = 0; i < n; i++)
            {
                polinom[i] = Math.Round(N1(x[i], m, a, b), 8);
                pogr[i] = Math.Round((f[i] - polinom[i]), 8);
                polinomCh[i] = Math.Round(N1ch(x[i], m, a,b), 8);
                pogrCh[i] = Math.Round((f[i] - polinomCh[i]), 8);
            }
            //Заполняем таблицы
            dgvN.Rows.Clear();
            dgvN.ColumnCount = 4;
            dgvN.Columns[0].Name = "x";
            dgvN.Columns[1].Name = "f";
            dgvN.Columns[2].Name = "Полином";
            dgvN.Columns[3].Name = "Погрешность";
            dgvNch.Rows.Clear();
            dgvNch.ColumnCount = 4;
            dgvNch.Columns[0].Name = "x";
            dgvNch.Columns[1].Name = "f";
            dgvNch.Columns[2].Name = "Полином";
            dgvNch.Columns[3].Name = "Погрешность";
            for (int i = 0; i < n; i++)
            {
                string[] row = { x[i].ToString(), f[i].ToString(), polinom[i].ToString(), pogr[i].ToString() };
                dgvN.Rows.Add(row);
                string[] rowCh = { x[i].ToString(), f[i].ToString(), polinomCh[i].ToString(), pogrCh[i].ToString() };
                dgvNch.Rows.Add(rowCh);

            }
            //Рисуем графики
            chartN.Series[0].Points.Clear();
            chartN.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartNch.Series[0].Points.Clear();
            chartNch.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < n; i++)
            {
                chartN.Series[0].Points.AddXY(x[i], pogr[i]);
                chartNch.Series[0].Points.AddXY(x[i], pogrCh[i]);
            }
           
        }
        public double maxP(double[] f, double[] x, int kUzlov, double a, double b) //Макс. погрешность для равномерного распределения
        {
            double[] p = new double[x.Length];
            double S = 0;
            double pogr;
            for (int i = 0; i < x.Length; i++)
            {
                p[i] = Math.Round(N1(x[i], kUzlov, a, b), 8);
                pogr = Math.Round(Math.Abs(f[i] - p[i]), 8);
                if (S < pogr)
                    S = pogr;
            }
            return S;
        }
        public double maxPch(double[] f, double[] x, int kUzlov, double a, double b) //Макс. погрешность для Чебышевской сетки
        {
            double[] p = new double[x.Length];
            double S = 0;
            double pogr;
            for (int i = 0; i < x.Length; i++)
            {
                p[i] = Math.Round(N1ch(x[i], kUzlov, a, b), 8);
                pogr = Math.Round(Math.Abs(f[i] - p[i]), 8);
                if (S < pogr)
                    S = pogr;
            }
            return S;
        }
        static void setCh(double[] ch, double a, double b) //Расчет узлов для Чебышевской сетки
        {
            double e;
            for (int i = 0; i < ch.Length; i++)
            {
                e = ((b - a) / 2) * Math.Cos(((2 * i + 1) * Math.PI) / (2 * (ch.Length + 1))) + ((a + b) / 2);
                ch[i] = e;
            }
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
        public double N1(double x, int kolvoUzlov, double a, double b) //интерполяционный полином Ньютона
        {
            double[] e = new double[kolvoUzlov];
            double h = Math.Round((b - a) / e.Length, 3);
            e[0] = a + h / 2;
            for (int i = 1; i < e.Length; i++)
                e[i] = Math.Round(e[i - 1] + h, 3);
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
        public double N1ch(double x, int kolvoUzlov, double a, double b) //интерполяционный полином Ньютона для Чебышевской сетки
        {
            double[] e = new double[kolvoUzlov];
            double h = Math.Round((b - a) / e.Length, 3);
            e[0] = a + h / 2;
            setCh(e, a, b);
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
        public void TeilorSum(double[] x, double[] f) //Ряд Тейлора
        {
            double eps = 0.000001;
            double an, res = 0;
            int t;
            for (int i = 0; i < x.Length; i++)
            {
                t = 0;
                an = 1;
                while (Math.Abs(an) > eps)
                {
                    an = (Math.Pow(-1, t) * (Math.Pow(Math.PI / 2, 2 * t)) * Math.Pow(x[i], 4 * t + 1)) / ((Factorial(2 * t) * (4 * t + 1)));
                    res += an;
                    t++;
                }
                f[i] = Math.Round(res, 8);
                res = 0;
            }
        }
        static int[] uzel = new int[12]; 
        static double[] maxPogr = new double[12];
        static double[] maxPogrCh = new double[12];        
        private void button2_Click(object sender, EventArgs e) //Создание доп. окна для графика и таблицы макс. погрешности
        {

            uzel[0] = 2;
            for (int i = 1; i < uzel.Length; i++)
            {
                uzel[i] = uzel[i - 1] + 3;
            }

            for (int i = 0; i < maxPogr.Length; i++)
            {
                maxPogr[i] = maxP(f, x, uzel[i], a, b);
                maxPogrCh[i] = maxPch(f, x, uzel[i], a, b);
            }
            Form3 fff = new Form3(uzel, maxPogr, maxPogrCh);
           fff.ShowDialog();
            
        }

        public double Factorial(int numb)
        {
            double res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
    }
}
