namespace LabWorkMDIapplications.Сard_index
{
    partial class AddAutorForm
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
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.TextBoxLName = new System.Windows.Forms.TextBox();
            this.TextFName = new System.Windows.Forms.TextBox();
            this.ButtonAddAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(8, 88);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(58, 13);
            this.labelLName.TabIndex = 10;
            this.labelLName.Text = "Lost Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(8, 62);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(58, 13);
            this.labelFName.TabIndex = 9;
            this.labelFName.Text = "FerstName";
            // 
            // TextBoxLName
            // 
            this.TextBoxLName.Location = new System.Drawing.Point(114, 88);
            this.TextBoxLName.Name = "TextBoxLName";
            this.TextBoxLName.Size = new System.Drawing.Size(158, 20);
            this.TextBoxLName.TabIndex = 8;
            // 
            // TextFName
            // 
            this.TextFName.Location = new System.Drawing.Point(114, 62);
            this.TextFName.Name = "TextFName";
            this.TextFName.Size = new System.Drawing.Size(158, 20);
            this.TextFName.TabIndex = 7;
            // 
            // ButtonAddAutor
            // 
            this.ButtonAddAutor.Location = new System.Drawing.Point(75, 152);
            this.ButtonAddAutor.Name = "ButtonAddAutor";
            this.ButtonAddAutor.Size = new System.Drawing.Size(120, 35);
            this.ButtonAddAutor.TabIndex = 11;
            this.ButtonAddAutor.Text = "Add Autor";
            this.ButtonAddAutor.UseVisualStyleBackColor = true;
            this.ButtonAddAutor.Click += new System.EventHandler(this.ButtonAddAutor_Click);
            // 
            // AddAutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.ButtonAddAutor);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.TextBoxLName);
            this.Controls.Add(this.TextFName);
            this.Name = "AddAutorForm";
            this.Text = "AddAutorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox TextBoxLName;
        private System.Windows.Forms.TextBox TextFName;
        private System.Windows.Forms.Button ButtonAddAutor;
    }
}