
namespace WindowsFormsMetDataBase
{
    partial class Form5
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
            this.opschriftAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBadge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opschriftAdd
            // 
            this.opschriftAdd.Location = new System.Drawing.Point(12, 27);
            this.opschriftAdd.Name = "opschriftAdd";
            this.opschriftAdd.Size = new System.Drawing.Size(166, 20);
            this.opschriftAdd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opschrift";
            // 
            // btnAddBadge
            // 
            this.btnAddBadge.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddBadge.Location = new System.Drawing.Point(12, 106);
            this.btnAddBadge.Name = "btnAddBadge";
            this.btnAddBadge.Size = new System.Drawing.Size(99, 23);
            this.btnAddBadge.TabIndex = 13;
            this.btnAddBadge.Text = "Add badge";
            this.btnAddBadge.UseVisualStyleBackColor = true;
            this.btnAddBadge.Click += new System.EventHandler(this.btnAddBadge_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 141);
            this.Controls.Add(this.btnAddBadge);
            this.Controls.Add(this.opschriftAdd);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox opschriftAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBadge;
    }
}