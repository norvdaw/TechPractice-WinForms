using System;

namespace KateTechPractice
{
    class QuadratureFormulasAppFunc:ApproximateFunction
    {
        private int N { get; set; } //количество частей для разбиения отрезка интегрирования
        public double[] valuesOfFormulas { get; set; }
        public double[] error { get; set; }
        public double[] numberOfParts { get; set; } //количество частей, при которых достигнута точность eps

        public enum Formula
        {
            LeftRect, CenterRect, Trapez, Simpson, Gauss
        }
        public QuadratureFormulasAppFunc(double a, double b, double h, double eps)
        {
            this.a = a; this.b = b; this.step = h; this.eps = eps;
            int length = (int)((a + b) / h + 1);
            x = new double[length];
            FillArrayX(x);
        }
        public void ChoiceFormula(Formula formula)
        {
            switch (formula)
            {
                case Formula.LeftRect:
                    CalculateIntegral(LeftRectanglesFormula);                    
                    break;
                case Formula.CenterRect:
                    CalculateIntegral(CentralRectanglesFormula);                    
                    break;
                case Formula.Trapez:
                    CalculateIntegral(TrapezFormula);                   
                    break;
                case Formula.Simpson:
                    CalculateIntegral(SimpsonFormula);                    
                    break;
                case Formula.Gauss:
                    CalculateIntegral(GaussFormula);                    
                    break;
            }
        }
        public void CalculateIntegral(Func<double,double> func)
        {
            valuesOfFormulas = new double[x.Length];
            error = new double[x.Length];
            numberOfParts = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                b = x[i];
                N = 2;
                double s = func(x[i]);
                N = N * 2;
                double ss = func(x[i]);
                double err = Math.Abs(s - ss);
                while (err >= eps && N <= 524288)
                {
                    s = ss;                    
                    N += 65536;
                    ss = func(x[i]);
                    err = Math.Abs(s - ss);
                }
                valuesOfFormulas[i] = Math.Round(s, 8);
                this.error[i] = Math.Round(err, 10);
                if(s!=0)
                numberOfParts[i] = N- 65536;
            }            
        }

        private double IntegrandFunction(double x, double z) //подыинтегральная функция
        {

            return (Math.Cos(Math.PI * z * z / 2));
        }        
        public double[] arrZ()//разбиение отрезка на N частей
        {
            double[] arrayZ = new double[N + 1];
            for (int i = 0; i <= N; i++)
            {
                arrayZ[i] = Math.Round(a + ((b - a) / N) * i, 2);
            }
            return arrayZ;
        }
        public double GaussFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += IntegrandFunction(x, arrayZ[i - 1] + ((b - a) / N) / 2 * (1 - 1 / Math.Sqrt(3))) + 
                    IntegrandFunction(x, arrayZ[i - 1] + ((b - a) / N) / 2 * (1 + 1 / Math.Sqrt(3)));
            }
            return ((b - a) / N) / 2 * resultSum;
        }
        public double SimpsonFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += IntegrandFunction(x, arrayZ[i - 1]) +
                4 * IntegrandFunction(x, (arrayZ[i] - arrayZ[i - 1]) / 2) +
                IntegrandFunction(x, arrayZ[i]);
            }
            return ((b - a) / N) / 6 * resultSum;
        }
        public double TrapezFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += IntegrandFunction(x, arrayZ[i - 1]) + IntegrandFunction(x,
               arrayZ[i]);
            }
            return ((b - a) / N) / 2 * resultSum;
        }
        public double CentralRectanglesFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += IntegrandFunction(x, (arrayZ[i] + arrayZ[i - 1]) / 2);
            }
            return ((b - a) / N) * resultSum;
        }
        public double LeftRectanglesFormula(double x)
        {
            double[] arrayZ = arrZ();
            double resultSum = 0;
            for (int i = 1; i < N; i++)
            {
                resultSum += IntegrandFunction(x, arrayZ[i - 1]);
            }
            return ((b - a) / N) * resultSum;
        }
    }
}
