namespace Währungsumrechnung
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxEUR = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(169, 68);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Umrechnen";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxEUR
            // 
            this.textBoxEUR.Location = new System.Drawing.Point(12, 32);
            this.textBoxEUR.Name = "textBoxEUR";
            this.textBoxEUR.Size = new System.Drawing.Size(100, 20);
            this.textBoxEUR.TabIndex = 1;
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(144, 32);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxUSD.TabIndex = 2;
            // 
            // labelEUR
            // 
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(12, 16);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(44, 13);
            this.labelEUR.TabIndex = 3;
            this.labelEUR.Text = "Euro (€)";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(144, 16);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(67, 13);
            this.labelUSD.TabIndex = 4;
            this.labelUSD.Text = "US Dollar ($)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 103);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.labelEUR);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxEUR);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Form1";
            this.Text = "Währungsrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxEUR;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.Label labelUSD;
    }
}

