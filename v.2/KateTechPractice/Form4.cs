using System;
using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Form4 : Form
    {
        static int N;
        int n;
        double[] x;
        double[] f;        
        static double a = 0, b;
        double eps1 = 0.00001, eps2 = 0.0000001;
        double[] arrAllErr = new double[110];
        int StartArrAllErr = 0;
        public Form4(double[] x, double[] f, int n)
        {
            InitializeComponent();
            //Обрабатываем данные           
            this.x = x;
            this.f = f;
            this.n = n;            
        }
        private static double[] integral(Func<double,double> f, double[] arrayX, double eps, double[] arrErr, double[] arrN)
        {
            double[] arrayY = new double[arrayX.Length];
            for (int i = 0; i < arrayX.Length; i++)
            {
                b = arrayX[i];
                N = 2;
                double s = f(arrayX[i]);
                N = N * 2;
                double ss = f(arrayX[i]);
                double err = Math.Abs(s - ss);
                while (err >= eps)
                {
                    s = ss;
                    N = N * 2;
                    ss = f(arrayX[i]);
                    err = Math.Abs(s - ss);
                }
                arrayY[i] = Math.Round(s,8);
                arrErr[i] = Math.Round(err, 10);
                arrN[i] = N;
            }           
            return arrayY;
        }
        private static double GaussFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += intFunc(x,arrayZ[i - 1] + ((b - a) / N) / 2 * (1 - 1 / Math.Sqrt(3))) + intFunc(
                x,
               arrayZ[i - 1] + ((b - a) / N) / 2 * (1 + 1 / Math.Sqrt(3))
                );
            }
            return ((b - a) / N) / 2 * resultSum;
        }
        private static double SimpsonFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += intFunc(x, arrayZ[i - 1]) +
                4 * intFunc(x, (arrayZ[i] - arrayZ[i - 1]) / 2) +
                intFunc(x, arrayZ[i]);
            }
            return ((b - a) / N) / 6 * resultSum;
        }
        private static double TrapezFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += intFunc(x, arrayZ[i - 1]) + intFunc(x,
               arrayZ[i]);
            }
            return ((b - a) / N) / 2 * resultSum;
        }
        private static double CentralRectanglesFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += intFunc(x, (arrayZ[i] + arrayZ[i - 1]) / 2);
            }
            return ((b - a) / N) * resultSum;
        }
        private static double LeftRectanglesFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += intFunc(x, arrayZ[i - 1]);
            }
            return ((b - a) / N) * resultSum;
        }

        public static double[] arrZ()
        {
            double[] arrayZ = new double[N + 1];
            for (int i = 0; i <= N; i++)
            {
                arrayZ[i] = Math.Round(a + ((b - a) / N) * i, 2);
            }
            return arrayZ;
        }
        double []arrS = new double[11];

        private void btnCentr_Click(object sender, EventArgs e)
        {
            FillDgv(CentralRectanglesFormula);
        }

        private void btnLeftRect_Click(object sender, EventArgs e)
        {
            FillDgv(LeftRectanglesFormula);
        }

        private void btnTr_Click(object sender, EventArgs e)
        {
            FillDgv(TrapezFormula);
        }

        private void btnSimp_Click(object sender, EventArgs e)
        {
            FillDgv(SimpsonFormula);
        }

        private void btnGaus_Click(object sender, EventArgs e)
        {
            FillDgv(GaussFormula);
        }

        private void btnPogr_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(arrAllErr, x);
            f5.ShowDialog();
        }

        public void FillDgv(Func<double,double> f)
        {
            double[] arrayErr = new double[11];
            double[] arrayN = new double[11];
            arrS = integral(f, x, eps1, arrayErr, arrayN);
            dgvInt.Rows.Clear();
            dgvInt.ColumnCount = 4;
            dgvInt.Columns[0].Name = "x";
            dgvInt.Columns[1].Name = "S";
            dgvInt.Columns[2].Name = "N";
            dgvInt.Columns[3].Name = "error";
            for (int i = 0; i < n; i++)
            {
                arrAllErr[StartArrAllErr + i] = arrayErr[i];
                string[] row = { x[i].ToString(), arrS[i].ToString(), arrayN[i].ToString(), arrayErr[i].ToString() };
                dgvInt.Rows.Add(row);
            }
            StartArrAllErr += 11;
            arrS = integral(f, x, eps2, arrayErr, arrayN);
            dgvInt2.Rows.Clear();
            dgvInt2.ColumnCount = 4;
            dgvInt2.Columns[0].Name = "x";
            dgvInt2.Columns[1].Name = "S";
            dgvInt2.Columns[2].Name = "N";
            dgvInt2.Columns[3].Name = "error";
            for (int i = 0; i < n; i++)
            {
                arrAllErr[StartArrAllErr + i] = arrayErr[i];
                string[] row = { x[i].ToString(), arrS[i].ToString(), arrayN[i].ToString(), arrayErr[i].ToString() };
                dgvInt2.Rows.Add(row);
            }
            StartArrAllErr += 11;
        }

        private static double intFunc(double x, double z)
        {
           
            return (Math.Cos(Math.PI*z*z/2));
        }



    }
}
