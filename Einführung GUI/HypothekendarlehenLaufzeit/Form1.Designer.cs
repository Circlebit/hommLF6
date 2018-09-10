namespace HypothekendarlehenLaufzeit
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_SumLent = new System.Windows.Forms.TextBox();
            this.textBox_InterestRate = new System.Windows.Forms.TextBox();
            this.textBox_RepaymentRate = new System.Windows.Forms.TextBox();
            this.label_SumLent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_InterestRateInPercent = new System.Windows.Forms.Label();
            this.button_CalcMortgage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Location = new System.Drawing.Point(15, 102);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(531, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_SumLent
            // 
            this.textBox_SumLent.Location = new System.Drawing.Point(15, 28);
            this.textBox_SumLent.Name = "textBox_SumLent";
            this.textBox_SumLent.Size = new System.Drawing.Size(100, 20);
            this.textBox_SumLent.TabIndex = 1;
            // 
            // textBox_InterestRate
            // 
            this.textBox_InterestRate.Location = new System.Drawing.Point(153, 28);
            this.textBox_InterestRate.Name = "textBox_InterestRate";
            this.textBox_InterestRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_InterestRate.TabIndex = 2;
            // 
            // textBox_RepaymentRate
            // 
            this.textBox_RepaymentRate.Location = new System.Drawing.Point(291, 28);
            this.textBox_RepaymentRate.Name = "textBox_RepaymentRate";
            this.textBox_RepaymentRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_RepaymentRate.TabIndex = 3;
            // 
            // label_SumLent
            // 
            this.label_SumLent.AutoSize = true;
            this.label_SumLent.Location = new System.Drawing.Point(12, 9);
            this.label_SumLent.Name = "label_SumLent";
            this.label_SumLent.Size = new System.Drawing.Size(88, 13);
            this.label_SumLent.TabIndex = 4;
            this.label_SumLent.Text = "Darlehenssumme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zinssatz in %";
            // 
            // label_InterestRateInPercent
            // 
            this.label_InterestRateInPercent.AutoSize = true;
            this.label_InterestRateInPercent.Location = new System.Drawing.Point(291, 8);
            this.label_InterestRateInPercent.Name = "label_InterestRateInPercent";
            this.label_InterestRateInPercent.Size = new System.Drawing.Size(88, 13);
            this.label_InterestRateInPercent.TabIndex = 6;
            this.label_InterestRateInPercent.Text = "Tilgungssatz in %";
            // 
            // button_CalcMortgage
            // 
            this.button_CalcMortgage.Location = new System.Drawing.Point(15, 63);
            this.button_CalcMortgage.Name = "button_CalcMortgage";
            this.button_CalcMortgage.Size = new System.Drawing.Size(75, 23);
            this.button_CalcMortgage.TabIndex = 7;
            this.button_CalcMortgage.Text = "Berechnen";
            this.button_CalcMortgage.UseVisualStyleBackColor = true;
            this.button_CalcMortgage.Click += new System.EventHandler(this.button_CalcMortgage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 365);
            this.Controls.Add(this.button_CalcMortgage);
            this.Controls.Add(this.label_InterestRateInPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SumLent);
            this.Controls.Add(this.textBox_RepaymentRate);
            this.Controls.Add(this.textBox_InterestRate);
            this.Controls.Add(this.textBox_SumLent);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "HypothekendarlehenLaufzeit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_SumLent;
        private System.Windows.Forms.TextBox textBox_InterestRate;
        private System.Windows.Forms.TextBox textBox_RepaymentRate;
        private System.Windows.Forms.Label label_SumLent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_InterestRateInPercent;
        private System.Windows.Forms.Button button_CalcMortgage;
    }
}

