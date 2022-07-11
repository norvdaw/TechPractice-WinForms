using System.Windows.Forms;

namespace KateTechPractice
{
    class SetDgv
    {        
        public void Fill(DataGridView t, string[] ColumnName, int Length, params double[][] arr)
        {
            t.Rows.Clear();
            t.RowHeadersVisible = false;
            t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            t.ColumnCount = ColumnName.Length;
            for (int i = 0; i < ColumnName.Length; i++)
            {
                t.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                t.Columns[i].Name = ColumnName[i];
            }

            for (int i = 0; i < Length; i++)
            {
                string[] row = new string[arr.Length];
                for (int j = 0; j < arr.Length; j++)
                {
                    row[j] = arr[j][i].ToString();
                }
                t.Rows.Add(row);
            }
        }
    }
}
