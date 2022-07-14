
namespace KateTechPractice
{
    partial class Task2v2FormDependenceOfMaxError
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
            this.dgvMaxError = new System.Windows.Forms.DataGridView();
            this.chartMaxError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvP
            // 
            this.dgvMaxError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaxError.Location = new System.Drawing.Point(12, 29);
            this.dgvMaxError.Name = "dgvP";
            this.dgvMaxError.RowHeadersWidth = 51;
            this.dgvMaxError.RowTemplate.Height = 24;
            this.dgvMaxError.Size = new System.Drawing.Size(469, 445);
            this.dgvMaxError.TabIndex = 0;
            // 
            // chartP
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMaxError.ChartAreas.Add(chartArea1);
            this.chartMaxError.Location = new System.Drawing.Point(487, 6);
            this.chartMaxError.Name = "chartP";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Равномерное распределение";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Полином Чебышева";
            this.chartMaxError.Series.Add(series1);
            this.chartMaxError.Series.Add(series2);
            this.chartMaxError.Size = new System.Drawing.Size(585, 549);
            this.chartMaxError.TabIndex = 1;
            this.chartMaxError.Text = "chart1";
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
            // Task3FormDependenceOfMaxError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartMaxError);
            this.Controls.Add(this.dgvMaxError);
            this.Name = "Task3FormDependenceOfMaxError";
            this.Text = "Task3FormDependenceOfMaxError";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaxError;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaxError;
        private System.Windows.Forms.Label label1;
    }
}