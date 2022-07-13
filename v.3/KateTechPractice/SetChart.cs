using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace KateTechPractice
{
    class SetChart
    {
        public string BasicFont { get; set; } = "Microsoft Sans Serif";
        public int BasicFontSize { get; set; } = 10;
        public int BasicBorderWidth = 1;
        public void Fill(Chart t, int NumOfSeries, double[] X, double[] Y)
        {
            t.Series[NumOfSeries].Points.Clear();
            t.Series[NumOfSeries].ChartType = SeriesChartType.Spline;
            t.Series[NumOfSeries].BorderWidth = BasicBorderWidth;

            for (int i = 0; i < X.Length; i++)
            {
                t.Series[NumOfSeries].Points.AddXY(X[i], Y[i]);
            }
        }
        public void SetAxisX(Chart t, int minX, int maxX)
        {
            t.ChartAreas[0].AxisX.Minimum = minX;
            t.ChartAreas[0].AxisX.Maximum = maxX;
        }
        public void SetAxisY(Chart t, int minY, int maxY)
        {
            t.ChartAreas[0].AxisY.Minimum = minY;
            t.ChartAreas[0].AxisY.Maximum = maxY;
        }
        public void SetTitle(Chart t, string NameTitleX, string NameTitleY)
        {
            t.ChartAreas[0].AxisX.TitleFont = new Font(BasicFont, BasicFontSize, FontStyle.Regular);
            t.ChartAreas[0].AxisY.TitleFont = new Font(BasicFont, BasicFontSize, FontStyle.Regular);
            t.ChartAreas[0].AxisX.Title = NameTitleX;
            t.ChartAreas[0].AxisY.Title = NameTitleY;
        }
    }
}
