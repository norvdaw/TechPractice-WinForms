using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Form3 : Form
    {
        int[] uzel; double[] maxPogr; double[] maxPogrCh;
        public Form3(int[] uzel, double[] maxPogr, double[] maxPogrCh )
        {
            InitializeComponent();
            this.uzel = uzel;
            this.maxPogr = maxPogr;
            this.maxPogrCh = maxPogrCh;
            //Заполнение таблицы
            dgvP.Rows.Clear();
            dgvP.ColumnCount = 3;
            dgvP.Columns[0].Name = "Кол-во узлов интерп.";
            dgvP.Columns[1].Name = "Max погрешность равном.";
            dgvP.Columns[2].Name = "Max погрешность Чебышева";
            for (int i = 0; i < uzel.Length; i++)
            {
                string[] row = { uzel[i].ToString(), maxPogr[i].ToString(), maxPogrCh[i].ToString()};
                dgvP.Rows.Add(row);
            }
            //Создание графика
                chartP.Series[0].Points.Clear();
            chartP.ChartAreas[0].AxisY.Minimum = -0.05;
            chartP.ChartAreas[0].AxisY.Maximum = 0.5;
            chartP.ChartAreas[0].AxisX.Minimum = 2;
            chartP.ChartAreas[0].AxisX.Maximum = 40;
            chartP.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartP.Series[1].Points.Clear();
            chartP.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < uzel.Length; i++)
            {
                chartP.Series[0].Points.AddXY(uzel[i], maxPogr[i]);
                chartP.Series[1].Points.AddXY(uzel[i], maxPogrCh[i]);
            }
        }
    }
}
