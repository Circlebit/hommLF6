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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_SumLent = new System.Windows.Forms.TextBox();
            this.textBox_InterestRate = new System.Windows.Forms.TextBox();
            this.textBox_RepaymentRate = new System.Windows.Forms.TextBox();
            this.label_SumLent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_InterestRateInPercent = new System.Windows.Forms.Label();
            this.button_CalcMortgage = new System.Windows.Forms.Button();
            this.groupBoxLaufzeit = new System.Windows.Forms.GroupBox();
            this.radioButton5Years = new System.Windows.Forms.RadioButton();
            this.radioButton10Years = new System.Windows.Forms.RadioButton();
            this.radioButton15Years = new System.Windows.Forms.RadioButton();
            this.radioButtonAbloesung = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxLaufzeit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 139);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(531, 368);
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
            this.textBox_InterestRate.Location = new System.Drawing.Point(155, 28);
            this.textBox_InterestRate.Name = "textBox_InterestRate";
            this.textBox_InterestRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_InterestRate.TabIndex = 2;
            // 
            // textBox_RepaymentRate
            // 
            this.textBox_RepaymentRate.Location = new System.Drawing.Point(294, 28);
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
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zinssatz in %";
            // 
            // label_InterestRateInPercent
            // 
            this.label_InterestRateInPercent.AutoSize = true;
            this.label_InterestRateInPercent.Location = new System.Drawing.Point(294, 8);
            this.label_InterestRateInPercent.Name = "label_InterestRateInPercent";
            this.label_InterestRateInPercent.Size = new System.Drawing.Size(88, 13);
            this.label_InterestRateInPercent.TabIndex = 6;
            this.label_InterestRateInPercent.Text = "Tilgungssatz in %";
            // 
            // button_CalcMortgage
            // 
            this.button_CalcMortgage.Location = new System.Drawing.Point(15, 97);
            this.button_CalcMortgage.Name = "button_CalcMortgage";
            this.button_CalcMortgage.Size = new System.Drawing.Size(100, 36);
            this.button_CalcMortgage.TabIndex = 7;
            this.button_CalcMortgage.Text = "Berechnen";
            this.button_CalcMortgage.UseVisualStyleBackColor = true;
            this.button_CalcMortgage.Click += new System.EventHandler(this.button_CalcMortgage_Click);
            // 
            // groupBoxLaufzeit
            // 
            this.groupBoxLaufzeit.Controls.Add(this.radioButtonAbloesung);
            this.groupBoxLaufzeit.Controls.Add(this.radioButton15Years);
            this.groupBoxLaufzeit.Controls.Add(this.radioButton10Years);
            this.groupBoxLaufzeit.Controls.Add(this.radioButton5Years);
            this.groupBoxLaufzeit.Location = new System.Drawing.Point(426, 9);
            this.groupBoxLaufzeit.Name = "groupBoxLaufzeit";
            this.groupBoxLaufzeit.Size = new System.Drawing.Size(120, 124);
            this.groupBoxLaufzeit.TabIndex = 8;
            this.groupBoxLaufzeit.TabStop = false;
            this.groupBoxLaufzeit.Text = "Laufzeit";
            this.groupBoxLaufzeit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton5Years
            // 
            this.radioButton5Years.AutoSize = true;
            this.radioButton5Years.Location = new System.Drawing.Point(20, 23);
            this.radioButton5Years.Name = "radioButton5Years";
            this.radioButton5Years.Size = new System.Drawing.Size(60, 17);
            this.radioButton5Years.TabIndex = 0;
            this.radioButton5Years.TabStop = true;
            this.radioButton5Years.Text = "5 Jahre";
            this.radioButton5Years.UseVisualStyleBackColor = true;
            // 
            // radioButton10Years
            // 
            this.radioButton10Years.AutoSize = true;
            this.radioButton10Years.Location = new System.Drawing.Point(20, 47);
            this.radioButton10Years.Name = "radioButton10Years";
            this.radioButton10Years.Size = new System.Drawing.Size(66, 17);
            this.radioButton10Years.TabIndex = 1;
            this.radioButton10Years.TabStop = true;
            this.radioButton10Years.Text = "10 Jahre";
            this.radioButton10Years.UseVisualStyleBackColor = true;
            // 
            // radioButton15Years
            // 
            this.radioButton15Years.AutoSize = true;
            this.radioButton15Years.Location = new System.Drawing.Point(20, 71);
            this.radioButton15Years.Name = "radioButton15Years";
            this.radioButton15Years.Size = new System.Drawing.Size(66, 17);
            this.radioButton15Years.TabIndex = 2;
            this.radioButton15Years.TabStop = true;
            this.radioButton15Years.Text = "15 Jahre";
            this.radioButton15Years.UseVisualStyleBackColor = true;
            // 
            // radioButtonAbloesung
            // 
            this.radioButtonAbloesung.AutoSize = true;
            this.radioButtonAbloesung.Location = new System.Drawing.Point(20, 95);
            this.radioButtonAbloesung.Name = "radioButtonAbloesung";
            this.radioButtonAbloesung.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAbloesung.TabIndex = 3;
            this.radioButtonAbloesung.TabStop = true;
            this.radioButtonAbloesung.Text = "bis Ablösung";
            this.radioButtonAbloesung.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 516);
            this.Controls.Add(this.groupBoxLaufzeit);
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
            this.groupBoxLaufzeit.ResumeLayout(false);
            this.groupBoxLaufzeit.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxLaufzeit;
        private System.Windows.Forms.RadioButton radioButtonAbloesung;
        private System.Windows.Forms.RadioButton radioButton15Years;
        private System.Windows.Forms.RadioButton radioButton10Years;
        private System.Windows.Forms.RadioButton radioButton5Years;
    }
}

