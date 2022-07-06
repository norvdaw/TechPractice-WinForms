using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Form5 : Form
    {
        double[] arrErr, arrX;
        public Form5(double[] arrErr, double[]arrX)
        {
            InitializeComponent();
            this.arrErr = arrErr;
            this.arrX = arrX;
            FillDgv();

        }
        public void FillDgv()
        {            
            dgv.Rows.Clear();
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "x";
            dgv.Columns[1].Name = "Лев. прям.";
            dgv.Columns[2].Name = "Центр. прям.";
            dgv.Columns[3].Name = "Трапеции";
            dgv.Columns[4].Name = "Симпсона";
            dgv.Columns[5].Name = "Гаусса";
            int t = 11;
            for (int i = 0; i < arrX.Length; i++)
            {                
                string[] row = { arrX[i].ToString() + " (eps1)", arrErr[i].ToString(), arrErr[i+2*t].ToString(), arrErr[i+4*t].ToString(), arrErr[i+6*t].ToString(), arrErr[i+8*t].ToString() };
                dgv.Rows.Add(row);
                string[] row2 = { arrX[i].ToString() + " (eps2)", arrErr[i+t].ToString(), arrErr[i + 3*t].ToString(), arrErr[i + 5*t].ToString(), arrErr[i + 7*t].ToString(), arrErr[i + 9*t].ToString() };
                dgv.Rows.Add(row2);
            }
            
        }
    }
}
