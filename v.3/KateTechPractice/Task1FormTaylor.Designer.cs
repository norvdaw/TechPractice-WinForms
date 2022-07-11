
namespace KateTechPractice
{
    partial class Task1FormTaylor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvTeilor = new System.Windows.Forms.DataGridView();
            this.chartTeilor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборЗаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeilor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeilor
            // 
            this.dgvTeilor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeilor.Location = new System.Drawing.Point(6, 21);
            this.dgvTeilor.Name = "dgvTeilor";
            this.dgvTeilor.RowHeadersWidth = 51;
            this.dgvTeilor.RowTemplate.Height = 24;
            this.dgvTeilor.Size = new System.Drawing.Size(480, 500);
            this.dgvTeilor.TabIndex = 0;
            // 
            // chartTeilor
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTeilor.ChartAreas.Add(chartArea2);
            this.chartTeilor.Location = new System.Drawing.Point(494, 21);
            this.chartTeilor.Name = "chartTeilor";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartTeilor.Series.Add(series2);
            this.chartTeilor.Size = new System.Drawing.Size(480, 500);
            this.chartTeilor.TabIndex = 2;
            this.chartTeilor.Text = "chartTeilor";
            title2.Name = "Title1";
            title2.Text = "График функции по полученной таблице";
            this.chartTeilor.Titles.Add(title2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборЗаданияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборЗаданияToolStripMenuItem
            // 
            this.выборЗаданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem,
            this.задание2ToolStripMenuItem,
            this.задание3ToolStripMenuItem});
            this.выборЗаданияToolStripMenuItem.Name = "выборЗаданияToolStripMenuItem";
            this.выборЗаданияToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.выборЗаданияToolStripMenuItem.Text = "Выбор задания";
            // 
            // задание1ToolStripMenuItem
            // 
            this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.задание1ToolStripMenuItem.Text = "Задание 1";
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.задание2ToolStripMenuItem.Text = "Задание 2";
            this.задание2ToolStripMenuItem.Click += new System.EventHandler(this.задание2ToolStripMenuItem_Click);
            // 
            // задание3ToolStripMenuItem
            // 
            this.задание3ToolStripMenuItem.Name = "задание3ToolStripMenuItem";
            this.задание3ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.задание3ToolStripMenuItem.Text = "Задание 3";
            this.задание3ToolStripMenuItem.Click += new System.EventHandler(this.задание3ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartTeilor);
            this.groupBox1.Controls.Add(this.dgvTeilor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 530);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Разложение в ряд Тейлора";
            // 
            // FormTeilor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 573);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTeilor";
            this.Text = "FormTeilor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeilor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeilor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTeilor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборЗаданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание3ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

