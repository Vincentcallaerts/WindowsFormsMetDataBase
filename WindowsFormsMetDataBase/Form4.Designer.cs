
namespace WindowsFormsMetDataBase
{
    partial class Form4
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
            this.btnAddBadge = new System.Windows.Forms.Button();
            this.cbPersonen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBadge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBadge
            // 
            this.btnAddBadge.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddBadge.Location = new System.Drawing.Point(10, 175);
            this.btnAddBadge.Name = "btnAddBadge";
            this.btnAddBadge.Size = new System.Drawing.Size(148, 23);
            this.btnAddBadge.TabIndex = 17;
            this.btnAddBadge.Text = "Voeg Badge Toe";
            this.btnAddBadge.UseVisualStyleBackColor = true;
            this.btnAddBadge.Click += new System.EventHandler(this.btnAddBadge_Click);
            // 
            // cbPersonen
            // 
            this.cbPersonen.FormattingEnabled = true;
            this.cbPersonen.Location = new System.Drawing.Point(10, 35);
            this.cbPersonen.Name = "cbPersonen";
            this.cbPersonen.Size = new System.Drawing.Size(150, 21);
            this.cbPersonen.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Persoon";
            // 
            // cbBadge
            // 
            this.cbBadge.FormattingEnabled = true;
            this.cbBadge.Location = new System.Drawing.Point(199, 35);
            this.cbBadge.Name = "cbBadge";
            this.cbBadge.Size = new System.Drawing.Size(150, 21);
            this.cbBadge.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Badge";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 206);
            this.Controls.Add(this.cbBadge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddBadge);
            this.Controls.Add(this.cbPersonen);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBadge;
        private System.Windows.Forms.ComboBox cbPersonen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBadge;
        private System.Windows.Forms.Label label2;
    }
}