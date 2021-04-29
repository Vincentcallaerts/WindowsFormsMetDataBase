
namespace WindowsFormsMetDataBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.voornaamAdd = new System.Windows.Forms.TextBox();
            this.achternaamAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leeftijdAdd = new System.Windows.Forms.NumericUpDown();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leeftijdAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // voornaamAdd
            // 
            this.voornaamAdd.Location = new System.Drawing.Point(12, 56);
            this.voornaamAdd.Name = "voornaamAdd";
            this.voornaamAdd.Size = new System.Drawing.Size(166, 20);
            this.voornaamAdd.TabIndex = 1;
            // 
            // achternaamAdd
            // 
            this.achternaamAdd.Location = new System.Drawing.Point(12, 101);
            this.achternaamAdd.Name = "achternaamAdd";
            this.achternaamAdd.Size = new System.Drawing.Size(166, 20);
            this.achternaamAdd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leeftijd";
            // 
            // leeftijdAdd
            // 
            this.leeftijdAdd.Location = new System.Drawing.Point(12, 142);
            this.leeftijdAdd.Name = "leeftijdAdd";
            this.leeftijdAdd.Size = new System.Drawing.Size(166, 20);
            this.leeftijdAdd.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddUser.Location = new System.Drawing.Point(55, 177);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 256);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.leeftijdAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.achternaamAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voornaamAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.leeftijdAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox voornaamAdd;
        private System.Windows.Forms.TextBox achternaamAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown leeftijdAdd;
        private System.Windows.Forms.Button btnAddUser;
    }
}