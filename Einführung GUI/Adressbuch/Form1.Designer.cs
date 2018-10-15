namespace Adressbuch
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox_NewEntry = new System.Windows.Forms.GroupBox();
            this.button_AddEntry = new System.Windows.Forms.Button();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.showPersons = new System.Windows.Forms.Button();
            this.groupBox_NewEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(74, 23);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(199, 20);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // groupBox_NewEntry
            // 
            this.groupBox_NewEntry.Controls.Add(this.button_AddEntry);
            this.groupBox_NewEntry.Controls.Add(this.textBox_LastName);
            this.groupBox_NewEntry.Controls.Add(this.label_Birthday);
            this.groupBox_NewEntry.Controls.Add(this.dateTimePicker_Birthday);
            this.groupBox_NewEntry.Controls.Add(this.label_LastName);
            this.groupBox_NewEntry.Controls.Add(this.label_FirstName);
            this.groupBox_NewEntry.Controls.Add(this.textBox_FirstName);
            this.groupBox_NewEntry.Location = new System.Drawing.Point(12, 12);
            this.groupBox_NewEntry.Name = "groupBox_NewEntry";
            this.groupBox_NewEntry.Size = new System.Drawing.Size(280, 134);
            this.groupBox_NewEntry.TabIndex = 1;
            this.groupBox_NewEntry.TabStop = false;
            this.groupBox_NewEntry.Text = "Neuer Eintrag";
            // 
            // button_AddEntry
            // 
            this.button_AddEntry.Location = new System.Drawing.Point(198, 105);
            this.button_AddEntry.Name = "button_AddEntry";
            this.button_AddEntry.Size = new System.Drawing.Size(75, 23);
            this.button_AddEntry.TabIndex = 6;
            this.button_AddEntry.Text = "Hinzufügen";
            this.button_AddEntry.UseVisualStyleBackColor = true;
            this.button_AddEntry.Click += new System.EventHandler(this.button_AddEntry_Click);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(74, 49);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(199, 20);
            this.textBox_LastName.TabIndex = 5;
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(6, 80);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(59, 13);
            this.label_Birthday.TabIndex = 4;
            this.label_Birthday.Text = "Geburtstag";
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(74, 74);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker_Birthday.TabIndex = 3;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(6, 52);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(59, 13);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = "Nachname";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(6, 26);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(49, 13);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "Vorname";
            // 
            // showPersons
            // 
            this.showPersons.Location = new System.Drawing.Point(21, 173);
            this.showPersons.Name = "showPersons";
            this.showPersons.Size = new System.Drawing.Size(129, 23);
            this.showPersons.TabIndex = 2;
            this.showPersons.Text = "Personen anzeigen";
            this.showPersons.UseVisualStyleBackColor = true;
            this.showPersons.Click += new System.EventHandler(this.showPersons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPersons);
            this.Controls.Add(this.groupBox_NewEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_NewEntry.ResumeLayout(false);
            this.groupBox_NewEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.GroupBox groupBox_NewEntry;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.Button button_AddEntry;
        private System.Windows.Forms.Button showPersons;
    }
}

