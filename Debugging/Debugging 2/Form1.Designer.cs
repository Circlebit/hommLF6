namespace Debugging_2
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
            this.listBoxPrimzahlen = new System.Windows.Forms.ListBox();
            this.buttonBerechnePrimzahlen = new System.Windows.Forms.Button();
            this.textBoxMaxWert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPrimzahlen
            // 
            this.listBoxPrimzahlen.FormattingEnabled = true;
            this.listBoxPrimzahlen.Location = new System.Drawing.Point(12, 12);
            this.listBoxPrimzahlen.Name = "listBoxPrimzahlen";
            this.listBoxPrimzahlen.Size = new System.Drawing.Size(108, 225);
            this.listBoxPrimzahlen.TabIndex = 0;
            // 
            // buttonBerechnePrimzahlen
            // 
            this.buttonBerechnePrimzahlen.Location = new System.Drawing.Point(197, 54);
            this.buttonBerechnePrimzahlen.Name = "buttonBerechnePrimzahlen";
            this.buttonBerechnePrimzahlen.Size = new System.Drawing.Size(75, 23);
            this.buttonBerechnePrimzahlen.TabIndex = 1;
            this.buttonBerechnePrimzahlen.Text = "Berechne";
            this.buttonBerechnePrimzahlen.UseVisualStyleBackColor = true;
            this.buttonBerechnePrimzahlen.Click += new System.EventHandler(this.buttonBerechnePrimzahlen_Click);
            // 
            // textBoxMaxWert
            // 
            this.textBoxMaxWert.Location = new System.Drawing.Point(172, 28);
            this.textBoxMaxWert.Name = "textBoxMaxWert";
            this.textBoxMaxWert.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxWert.TabIndex = 2;
            this.textBoxMaxWert.Text = "37";
            this.textBoxMaxWert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MaxWert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxWert);
            this.Controls.Add(this.buttonBerechnePrimzahlen);
            this.Controls.Add(this.listBoxPrimzahlen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Berechnung Primzahlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPrimzahlen;
        private System.Windows.Forms.Button buttonBerechnePrimzahlen;
        private System.Windows.Forms.TextBox textBoxMaxWert;
        private System.Windows.Forms.Label label1;
    }
}

