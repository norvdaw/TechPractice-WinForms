using System;
using System.Windows.Forms;

namespace KateTechPractice
{
    public partial class Task3FormQuadratureFormulas : Form
    {

        public Task3FormQuadratureFormulas()
        {
            InitializeComponent();
            this.Text = "Task 3. Квадратурные формулы";

        }
        private void FillDgv(QuadratureFormulasAppFunc.Formula formul)
        {
            QuadratureFormulasAppFunc ValuesForEps1 = new QuadratureFormulasAppFunc(0, 1.5, 0.15, 0.000001);
            QuadratureFormulasAppFunc ValuesForEps2 = new QuadratureFormulasAppFunc(0, 1.5, 0.15, 0.00000001);
            ValuesForEps1.ChoiceFormula(formul);
            ValuesForEps2.ChoiceFormula(formul);

            SetDgv changeDgv = new SetDgv();
            string[] NameColumns = { "x", "S", "N", "Error" };
            changeDgv.Fill(dgvInt, NameColumns, ValuesForEps1.x.Length, ValuesForEps1.x,
                ValuesForEps1.valuesOfFormulas, ValuesForEps1.numberOfParts, ValuesForEps1.error);
            changeDgv.Fill(dgvInt2, NameColumns, ValuesForEps2.x.Length,
                ValuesForEps2.x, ValuesForEps2.valuesOfFormulas, ValuesForEps2.numberOfParts, ValuesForEps2.error);

        }
        private void btnCentr_Click(object sender, EventArgs e)
        {
            FillDgv(QuadratureFormulasAppFunc.Formula.CenterRect);
        }

        private void btnLeftRect_Click(object sender, EventArgs e)
        {
            FillDgv(QuadratureFormulasAppFunc.Formula.LeftRect);
        }

        private void btnTr_Click(object sender, EventArgs e)
        {
            FillDgv(QuadratureFormulasAppFunc.Formula.Trapez);
        }

        private void btnSimp_Click(object sender, EventArgs e)
        {
            FillDgv(QuadratureFormulasAppFunc.Formula.Simpson);
        }

        private void btnGaus_Click(object sender, EventArgs e)
        {
            FillDgv(QuadratureFormulasAppFunc.Formula.Gauss);
        }
    }
}
