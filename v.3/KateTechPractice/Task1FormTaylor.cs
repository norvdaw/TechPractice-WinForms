using System;
using System.Windows.Forms;


namespace KateTechPractice
{    public partial class Task1FormTaylor : Form
    {       
        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Task3FormQuadratureFormulas task3 = new Task3FormQuadratureFormulas();
           task3.ShowDialog();           
        }       

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2v1FormNewton task2v1 = new Task2v1FormNewton();
            task2v1.ShowDialog();            
        }
       
        public Task1FormTaylor()
        {
            InitializeComponent();
            this.Text = "Task 1. Разложение в ряд Тейлора";
            
            ApproximateFunction function = new ApproximateFunction(0, 1.5, 0.15, 0.000001);
            function.CalculateTaylorSeries(function.x,function.f);
            
            SetDgv setDgv = new SetDgv();
            string[] columnName = { "x", "f(x)", "k" };
            setDgv.Fill(dgvTeilor, columnName, function.x.Length, function.x, function.f, function.count);           
            
            SetChart setChart = new SetChart();
            setChart.Fill(chartTeilor, 0, function.x, function.f);
            setChart.SetTitle(chartTeilor,"x", "f(x)");
            
        }

        
    }
}