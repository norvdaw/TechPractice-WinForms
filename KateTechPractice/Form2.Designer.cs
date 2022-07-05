
namespace KateTechPractice
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvN = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.dgvNch = new System.Windows.Forms.DataGridView();
            this.chartN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvN
            // 
            this.dgvN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvN.Location = new System.Drawing.Point(12, 29);
            this.dgvN.Name = "dgvN";
            this.dgvN.RowHeadersWidth = 51;
            this.dgvN.RowTemplate.Height = 24;
            this.dgvN.Size = new System.Drawing.Size(631, 371);
            this.dgvN.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(674, 816);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(59, 22);
            this.txtM.TabIndex = 2;
            this.txtM.Text = "5";
            // 
            // dgvNch
            // 
            this.dgvNch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNch.Location = new System.Drawing.Point(15, 441);
            this.dgvNch.Name = "dgvNch";
            this.dgvNch.RowHeadersWidth = 51;
            this.dgvNch.RowTemplate.Height = 24;
            this.dgvNch.Size = new System.Drawing.Size(628, 366);
            this.dgvNch.TabIndex = 3;
            // 
            // chartN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartN.ChartAreas.Add(chartArea1);
            this.chartN.Location = new System.Drawing.Point(640, 9);
            this.chartN.Name = "chartN";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartN.Series.Add(series1);
            this.chartN.Size = new System.Drawing.Size(552, 419);
            this.chartN.TabIndex = 4;
            this.chartN.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График погрешности для равномерного распределения ";
            this.chartN.Titles.Add(title1);
            // 
            // chartNch
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNch.ChartAreas.Add(chartArea2);
            this.chartNch.Location = new System.Drawing.Point(640, 424);
            this.chartNch.Name = "chartNch";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartNch.Series.Add(series2);
            this.chartNch.Size = new System.Drawing.Size(552, 383);
            this.chartNch.TabIndex = 5;
            this.chartNch.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "График погрешности для корней полинома Чебышева";
            this.chartNch.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 821);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число узлов интерполяции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Таблица для равномерно распределенных узлов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Таблица для корней полинома Чебышева:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(987, 816);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Таблица зависимостей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 847);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartNch);
            this.Controls.Add(this.chartN);
            this.Controls.Add(this.dgvNch);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvN);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.DataGridView dgvNch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}