
namespace KateTechPractice
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.chartP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvP
            // 
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(12, 29);
            this.dgvP.Name = "dgvP";
            this.dgvP.RowHeadersWidth = 51;
            this.dgvP.RowTemplate.Height = 24;
            this.dgvP.Size = new System.Drawing.Size(469, 445);
            this.dgvP.TabIndex = 0;
            // 
            // chartP
            // 
            chartArea1.Name = "ChartArea1";
            this.chartP.ChartAreas.Add(chartArea1);
            this.chartP.Location = new System.Drawing.Point(487, 6);
            this.chartP.Name = "chartP";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Равномерное распределение";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Полином Чебышева";
            this.chartP.Series.Add(series1);
            this.chartP.Series.Add(series2);
            this.chartP.Size = new System.Drawing.Size(585, 549);
            this.chartP.TabIndex = 1;
            this.chartP.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица для разного числа узлов интерполяции";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartP);
            this.Controls.Add(this.dgvP);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartP;
        private System.Windows.Forms.Label label1;
    }
}