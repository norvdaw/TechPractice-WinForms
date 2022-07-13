using System;

namespace KateTechPractice
{
    class NewtonPolynomialAppFunc : ApproximateFunction
    {
        public NewtonPolynomialAppFunc(double a, double b, double step, double eps)
        {
            this.a = a; this.b = b; this.step = step; this.eps = eps;
            int length = (int)((a + b) / step + 1);
            x = new double[length];
            f = new double[length];
            count = new double[length];
            CalculateTaylorSeries();
        }
        public double[] polinomial { get; set; }
        public double[] error { get; set; }
        public double[] numberOfNodesMaxError { get; set; }
        public double[] maxError { get; set; }
        public int numberOfNodes { get; set; } = 5;
        public double CalculateNewtonPolinomial(Func<double[]> funс, double x, int kolvoUzlov) //интерполяционный полином Ньютона
        {
            double[] xSupport = funс();
            double[] fSupport = new double[kolvoUzlov];
            CalculateTaylorSeries(xSupport, fSupport);
            double[] divDiff = new double[xSupport.Length - 1];
            for (int i = 1; i < xSupport.Length; i++)
            {
                divDiff[i - 1] = CalculateDividedDifferences(xSupport, fSupport, i);
            }
            double res = fSupport[0];
            for (int k = 1; k < xSupport.Length; k++)
            {
                double P = 1;
                for (int j = 0; j < k; j++)
                {
                    P *= (x - xSupport[j]);
                }
                res += divDiff[k - 1] * P;
            }
            return Math.Round(res, 6);
        }
        public double MaxError(Func<double[]> func) //макс. погрешность для узла интерполяции 
        {
            double[] polynomial = new double[x.Length];
            double errorSupport = 0;
            double error;
            for (int i = 0; i < x.Length; i++)
            {
                polynomial[i] = Math.Round(CalculateNewtonPolinomial(func, x[i], numberOfNodes), 8);
                error = Math.Round(Math.Abs(f[i] - polynomial[i]), 8);
                if (errorSupport < error)
                    errorSupport = error;
            }
            return errorSupport;
        }
        public void CalculateMaxError(Func<double[]> func)
        {
            numberOfNodesMaxError = new double[f.Length];
            maxError = new double[f.Length];
            numberOfNodes = 0;
            for (int i = 0; i < f.Length; i++)
            {
                numberOfNodes += 3;
                numberOfNodesMaxError[i] = numberOfNodes;
                maxError[i] = MaxError(func);
            }
        }
        public void CalculatePolynomial(Func<double[]> func)
        {
            polinomial = new double[x.Length];
            for (int i = 0; i < polinomial.Length; i++)
            {
                polinomial[i] = Math.Round(CalculateNewtonPolinomial(func, x[i], numberOfNodes), 8);
            }
        }

        public void CalculateError()
        {
            error = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                error[i] = Math.Round((f[i] - polinomial[i]), 8);
            }
        }
        public double[] setChebyshevRoots() //Расчет узлов для корней полинома Чебышева
        {
            double result;
            double[] arrRoots = new double[(int)numberOfNodes];
            double stepChebyshev = Math.Round((b - a) / arrRoots.Length, 3);
            arrRoots[0] = a + stepChebyshev / 2;
            for (int i = 0; i < numberOfNodes; i++)
            {
                result = ((b - a) / 2) * Math.Cos(((2 * i + 1) * Math.PI) /
                    (2 * ((double)numberOfNodes + 1))) + ((a + b) / 2);
                arrRoots[i] = result;
            }
            return arrRoots;
        }
        public double[] setNormalNodes() //Расчет узлов для равномерно распределенных узлов
        {
            double[] arrNodes = new double[numberOfNodes];
            double stepNormal = Math.Round((b - a) / numberOfNodes, 3);
            arrNodes[0] = a + stepNormal / 2;
            for (int i = 1; i < numberOfNodes; i++)
                arrNodes[i] = Math.Round(arrNodes[i - 1] + stepNormal, 3);
            return arrNodes;
        }
        public double CalculateDividedDifferences(double[] x, double[] y, int k) //Произведение в полиноме Ньютона
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
