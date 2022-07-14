
namespace KateTechPractice
{
    partial class Task3FormQuadratureFormulas
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
            this.dgvInt = new System.Windows.Forms.DataGridView();
            this.btnLeftRect = new System.Windows.Forms.Button();
            this.btnGaus = new System.Windows.Forms.Button();
            this.btnTr = new System.Windows.Forms.Button();
            this.btnSimp = new System.Windows.Forms.Button();
            this.btnCentr = new System.Windows.Forms.Button();
            this.dgvInt2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInt2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInt
            // 
            this.dgvInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInt.Location = new System.Drawing.Point(12, 34);
            this.dgvInt.Name = "dgvInt";
            this.dgvInt.RowHeadersWidth = 51;
            this.dgvInt.RowTemplate.Height = 24;
            this.dgvInt.Size = new System.Drawing.Size(505, 500);
            this.dgvInt.TabIndex = 0;
            // 
            // btnLeftRect
            // 
            this.btnLeftRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLeftRect.Location = new System.Drawing.Point(12, 540);
            this.btnLeftRect.Name = "btnLeftRect";
            this.btnLeftRect.Size = new System.Drawing.Size(200, 50);
            this.btnLeftRect.TabIndex = 1;
            this.btnLeftRect.Text = "Формула левых прямоугольников";
            this.btnLeftRect.UseVisualStyleBackColor = true;
            this.btnLeftRect.Click += new System.EventHandler(this.btnLeftRect_Click);
            // 
            // btnGaus
            // 
            this.btnGaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGaus.Location = new System.Drawing.Point(836, 540);
            this.btnGaus.Name = "btnGaus";
            this.btnGaus.Size = new System.Drawing.Size(200, 50);
            this.btnGaus.TabIndex = 2;
            this.btnGaus.Text = "Формула Гаусса";
            this.btnGaus.UseVisualStyleBackColor = true;
            this.btnGaus.Click += new System.EventHandler(this.btnGaus_Click);
            // 
            // btnTr
            // 
            this.btnTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTr.Location = new System.Drawing.Point(424, 540);
            this.btnTr.Name = "btnTr";
            this.btnTr.Size = new System.Drawing.Size(200, 50);
            this.btnTr.TabIndex = 3;
            this.btnTr.Text = "Формула трапеции";
            this.btnTr.UseVisualStyleBackColor = true;
            this.btnTr.Click += new System.EventHandler(this.btnTr_Click);
            // 
            // btnSimp
            // 
            this.btnSimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSimp.Location = new System.Drawing.Point(630, 540);
            this.btnSimp.Name = "btnSimp";
            this.btnSimp.Size = new System.Drawing.Size(200, 50);
            this.btnSimp.TabIndex = 4;
            this.btnSimp.Text = "Формула Симпсона";
            this.btnSimp.UseVisualStyleBackColor = true;
            this.btnSimp.Click += new System.EventHandler(this.btnSimp_Click);
            // 
            // btnCentr
            // 
            this.btnCentr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCentr.Location = new System.Drawing.Point(218, 540);
            this.btnCentr.Name = "btnCentr";
            this.btnCentr.Size = new System.Drawing.Size(200, 50);
            this.btnCentr.TabIndex = 5;
            this.btnCentr.Text = "Формула центральных прямоугольников";
            this.btnCentr.UseVisualStyleBackColor = true;
            this.btnCentr.Click += new System.EventHandler(this.btnCentr_Click);
            // 
            // dgvInt2
            // 
            this.dgvInt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInt2.Location = new System.Drawing.Point(531, 34);
            this.dgvInt2.Name = "dgvInt2";
            this.dgvInt2.RowHeadersWidth = 51;
            this.dgvInt2.RowTemplate.Height = 24;
            this.dgvInt2.Size = new System.Drawing.Size(505, 500);
            this.dgvInt2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Для eps1 = 1E-05";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(532, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Для eps2 = 1E-07";
            // 
            // Task3FormQuadratureFormulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInt2);
            this.Controls.Add(this.btnCentr);
            this.Controls.Add(this.btnSimp);
            this.Controls.Add(this.btnTr);
            this.Controls.Add(this.btnGaus);
            this.Controls.Add(this.btnLeftRect);
            this.Controls.Add(this.dgvInt);
            this.Name = "Task3FormQuadratureFormulas";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInt;
        private System.Windows.Forms.Button btnLeftRect;
        private System.Windows.Forms.Button btnGaus;
        private System.Windows.Forms.Button btnTr;
        private System.Windows.Forms.Button btnSimp;
        private System.Windows.Forms.Button btnCentr;
        private System.Windows.Forms.DataGridView dgvInt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}