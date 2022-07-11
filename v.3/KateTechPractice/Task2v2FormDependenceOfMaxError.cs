using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Task2v2FormDependenceOfMaxError : Form
    {
        
        public Task2v2FormDependenceOfMaxError()
        {
            InitializeComponent();
            this.Text = "Task 2.2. Зависимость макс. погрешности от числа узлов интерполирования";
            FillDGVnChart();            
        }
        public void FillDGVnChart()
        {
            NewtonPolynomialAppFunc maxErrorNormal = new NewtonPolynomialAppFunc(0, 1.5, 0.15, 0.000001);
            maxErrorNormal.CalculateMaxError(maxErrorNormal.setNormalNodes);

            NewtonPolynomialAppFunc maxErrorChebyshev = new NewtonPolynomialAppFunc(0, 1.5, 0.15, 0.000001);
            maxErrorChebyshev.CalculateMaxError(maxErrorChebyshev.setChebyshevRoots);
            SetDgv setDgv = new SetDgv();
            string[] ColumnName = { "Нормальное распределение", "Корни полинома Чебышева", "Кол-во узлов" };
            setDgv.Fill(dgvMaxError, ColumnName, maxErrorNormal.f.Length,
                maxErrorNormal.maxError, maxErrorChebyshev.maxError, maxErrorNormal.numberOfNodesMaxError);

            SetChart setChart = new SetChart();
            setChart.SetAxisY(chartMaxError, -1, 6);
            setChart.SetTitle(chartMaxError, "кол-во узлов", "макс. погрешность");
            setChart.Fill(chartMaxError, 0, maxErrorNormal.numberOfNodesMaxError, maxErrorNormal.maxError);
            setChart.Fill(chartMaxError, 1, maxErrorChebyshev.numberOfNodesMaxError, maxErrorChebyshev.maxError);

        }
    }
}
