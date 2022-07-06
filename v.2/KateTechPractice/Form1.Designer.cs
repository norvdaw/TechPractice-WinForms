
namespace KateTechPractice
{
    partial class FormTeilor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvTeilor = new System.Windows.Forms.DataGridView();
            this.chartTeilor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборЗаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeilor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeilor
            // 
            this.dgvTeilor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeilor.Location = new System.Drawing.Point(12, 29);
            this.dgvTeilor.Name = "dgvTeilor";
            this.dgvTeilor.RowHeadersWidth = 51;
            this.dgvTeilor.RowTemplate.Height = 24;
            this.dgvTeilor.Size = new System.Drawing.Size(471, 481);
            this.dgvTeilor.TabIndex = 0;
            // 
            // chartTeilor
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTeilor.ChartAreas.Add(chartArea1);
            this.chartTeilor.Location = new System.Drawing.Point(501, 28);
            this.chartTeilor.Name = "chartTeilor";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartTeilor.Series.Add(series1);
            this.chartTeilor.Size = new System.Drawing.Size(491, 482);
            this.chartTeilor.TabIndex = 2;
            this.chartTeilor.Text = "chartTeilor";
            title1.Name = "Title1";
            title1.Text = "График функции по полученной таблице";
            this.chartTeilor.Titles.Add(title1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборЗаданияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборЗаданияToolStripMenuItem
            // 
            this.выборЗаданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задание1ToolStripMenuItem,
            this.задание2ToolStripMenuItem,
            this.задание3ToolStripMenuItem,
            this.задание4ToolStripMenuItem});
            this.выборЗаданияToolStripMenuItem.Name = "выборЗаданияToolStripMenuItem";
            this.выборЗаданияToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.выборЗаданияToolStripMenuItem.Text = "Выбор задания";
            // 
            // задание1ToolStripMenuItem
            // 
            this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.задание1ToolStripMenuItem.Text = "Задание 1";
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.задание2ToolStripMenuItem.Text = "Задание 2";
            this.задание2ToolStripMenuItem.Click += new System.EventHandler(this.задание2ToolStripMenuItem_Click);
            // 
            // задание3ToolStripMenuItem
            // 
            this.задание3ToolStripMenuItem.Name = "задание3ToolStripMenuItem";
            this.задание3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.задание3ToolStripMenuItem.Text = "Задание 3";
            this.задание3ToolStripMenuItem.Click += new System.EventHandler(this.задание3ToolStripMenuItem_Click);
            // 
            // задание4ToolStripMenuItem
            // 
            this.задание4ToolStripMenuItem.Name = "задание4ToolStripMenuItem";
            this.задание4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.задание4ToolStripMenuItem.Text = "Задание 4";
            this.задание4ToolStripMenuItem.Click += new System.EventHandler(this.задание4ToolStripMenuItem_Click);
            // 
            // FormTeilor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 552);
            this.Controls.Add(this.chartTeilor);
            this.Controls.Add(this.dgvTeilor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTeilor";
            this.Text = "FormTeilor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeilor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem задание4ToolStripMenuItem;
    }
}

