using System;
using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Task2v1FormNewton : Form
    {
        public Task2v1FormNewton()
        {
            InitializeComponent();
            this.Text = "Task 2.1. Интерполяционный полином Ньютона";
        }

        private void btnFillDGVnChart_Click(object sender, EventArgs e)
        {

            FillDGVnChart();

        }
        public void FillDGVnChart()
        {
            //вычисление полинома с равномерно распределенными узлами
            NewtonPolynomialAppFunc funcNormal = new NewtonPolynomialAppFunc(0, 1.5, 0.15, 0.000001);
            funcNormal.numberOfNodes = int.Parse(txtM.Text);
            funcNormal.CalculatePolynomial(funcNormal.setNormalNodes);
            funcNormal.CalculateError();

            //вычисление полинома с корнями полинома Чебышева
            NewtonPolynomialAppFunc funcChebyshev = new NewtonPolynomialAppFunc(0, 1.5, 0.15, 0.000001);
            funcChebyshev.numberOfNodes = int.Parse(txtM.Text);
            funcChebyshev.CalculatePolynomial(funcNormal.setChebyshevRoots);
            funcChebyshev.CalculateError();

            SetDgv changeDgv = new SetDgv();
            string[] ColumnName = { "x", "f", "Полином", "Погрешность" };
            changeDgv.Fill(dgvNormal, ColumnName, funcNormal.x.Length,
                funcNormal.x, funcNormal.f, funcNormal.polinomial, funcNormal.error);
            changeDgv.Fill(dgvChebyshev, ColumnName, funcChebyshev.x.Length,
                funcChebyshev.x, funcChebyshev.f, funcChebyshev.polinomial, funcChebyshev.error);

            SetChart setChart = new SetChart();
            setChart.Fill(chartNormal, 0, funcNormal.x, funcNormal.error);
            setChart.SetTitle(chartNormal, "x", "погрешность");
            setChart.Fill(chartChebyshev, 0, funcChebyshev.x, funcChebyshev.error);
            setChart.SetTitle(chartChebyshev, "x", "погрешность");
        }

        private void btnShowTask2v2_Click(object sender, EventArgs e) //Создание доп. окна для графика и таблицы макс. погрешности
        {

            Task2v2FormDependenceOfMaxError task2v2 = new Task2v2FormDependenceOfMaxError();
            task2v2.ShowDialog();

        }
    }
}
