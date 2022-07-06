using System;
using System.Windows.Forms;


namespace KateTechPractice
{    public partial class FormTeilor : Form
    {                      
        const double a = 0, b = 1.5, h = 0.15;
        const int n = 11;
        static double[] x = new double[n];
        static double[] f = new double[n];       
        int[] k = new int[n];
        Form2 ff = new Form2(x, f, n, a, b); // Создание формы для Задания 2
        Form4 f4 = new Form4(x, f, n);
        

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(x,f);
            f6.ShowDialog();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ff.ShowDialog();
        }  
        public FormTeilor()
        {
            InitializeComponent();          
            Value test = new Value(0, 1.5, 0.15, 0.000001);
            test.TeilorSum(test.x,test.f);
            string[] ColumnName = { "x", "f", "k" };
            test.FillDgv(dgvTeilor,ColumnName, test.x.Length, test.x, test.f, test.k);
            test.FillChart(chartTeilor, test.x, test.f);          
        }        
    }
}