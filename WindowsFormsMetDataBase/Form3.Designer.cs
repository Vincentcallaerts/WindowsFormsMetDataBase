
namespace WindowsFormsMetDataBase
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonen = new System.Windows.Forms.ComboBox();
            this.btnBewerkUser = new System.Windows.Forms.Button();
            this.leeftijdAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.achternaamAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voornaamAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leeftijdAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persoon";
            // 
            // cbPersonen
            // 
            this.cbPersonen.FormattingEnabled = true;
            this.cbPersonen.Location = new System.Drawing.Point(13, 26);
            this.cbPersonen.Name = "cbPersonen";
            this.cbPersonen.Size = new System.Drawing.Size(150, 21);
            this.cbPersonen.TabIndex = 1;
            // 
            // btnBewerkUser
            // 
            this.btnBewerkUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBewerkUser.Location = new System.Drawing.Point(268, 160);
            this.btnBewerkUser.Name = "btnBewerkUser";
            this.btnBewerkUser.Size = new System.Drawing.Size(75, 23);
            this.btnBewerkUser.TabIndex = 13;
            this.btnBewerkUser.Text = "Bewerk";
            this.btnBewerkUser.UseVisualStyleBackColor = true;
            this.btnBewerkUser.Click += new System.EventHandler(this.btnBewerkUser_Click);
            // 
            // leeftijdAdd
            // 
            this.leeftijdAdd.Location = new System.Drawing.Point(225, 125);
            this.leeftijdAdd.Name = "leeftijdAdd";
            this.leeftijdAdd.Size = new System.Drawing.Size(166, 20);
            this.leeftijdAdd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Leeftijd";
            // 
            // achternaamAdd
            // 
            this.achternaamAdd.Location = new System.Drawing.Point(225, 84);
            this.achternaamAdd.Name = "achternaamAdd";
            this.achternaamAdd.Size = new System.Drawing.Size(166, 20);
            this.achternaamAdd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Achternaam";
            // 
            // voornaamAdd
            // 
            this.voornaamAdd.Location = new System.Drawing.Point(225, 39);
            this.voornaamAdd.Name = "voornaamAdd";
            this.voornaamAdd.Size = new System.Drawing.Size(166, 20);
            this.voornaamAdd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(222, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Voornaam";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnVerwijder.Location = new System.Drawing.Point(15, 160);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 14;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 202);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnBewerkUser);
            this.Controls.Add(this.leeftijdAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.achternaamAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voornaamAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPersonen);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.leeftijdAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonen;
        private System.Windows.Forms.Button btnBewerkUser;
        private System.Windows.Forms.NumericUpDown leeftijdAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox achternaamAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox voornaamAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerwijder;
    }
}