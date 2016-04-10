namespace LabWorkMDIapplications.Сard_index
{
    partial class AddBookForm
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
            this.TextBoxNameBook = new System.Windows.Forms.TextBox();
            this.TextBoxNamPages = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.TextBoxAutor = new System.Windows.Forms.ComboBox();
            this.TextBoxPubHouse = new System.Windows.Forms.ComboBox();
            this.labelNameBook = new System.Windows.Forms.Label();
            this.labelNamPages = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelPubHouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxNameBook
            // 
            this.TextBoxNameBook.Location = new System.Drawing.Point(128, 35);
            this.TextBoxNameBook.Name = "TextBoxNameBook";
            this.TextBoxNameBook.Size = new System.Drawing.Size(158, 20);
            this.TextBoxNameBook.TabIndex = 0;
            // 
            // TextBoxNamPages
            // 
            this.TextBoxNamPages.Location = new System.Drawing.Point(128, 61);
            this.TextBoxNamPages.Name = "TextBoxNamPages";
            this.TextBoxNamPages.Size = new System.Drawing.Size(158, 20);
            this.TextBoxNamPages.TabIndex = 1;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(76, 166);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(120, 35);
            this.AddBook.TabIndex = 2;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            // 
            // TextBoxAutor
            // 
            this.TextBoxAutor.FormattingEnabled = true;
            this.TextBoxAutor.Location = new System.Drawing.Point(128, 87);
            this.TextBoxAutor.Name = "TextBoxAutor";
            this.TextBoxAutor.Size = new System.Drawing.Size(158, 21);
            this.TextBoxAutor.TabIndex = 3;
            // 
            // TextBoxPubHouse
            // 
            this.TextBoxPubHouse.FormattingEnabled = true;
            this.TextBoxPubHouse.Location = new System.Drawing.Point(128, 114);
            this.TextBoxPubHouse.Name = "TextBoxPubHouse";
            this.TextBoxPubHouse.Size = new System.Drawing.Size(158, 21);
            this.TextBoxPubHouse.TabIndex = 4;
            // 
            // labelNameBook
            // 
            this.labelNameBook.AutoSize = true;
            this.labelNameBook.Location = new System.Drawing.Point(22, 35);
            this.labelNameBook.Name = "labelNameBook";
            this.labelNameBook.Size = new System.Drawing.Size(60, 13);
            this.labelNameBook.TabIndex = 5;
            this.labelNameBook.Text = "NameBook";
            // 
            // labelNamPages
            // 
            this.labelNamPages.AutoSize = true;
            this.labelNamPages.Location = new System.Drawing.Point(22, 61);
            this.labelNamPages.Name = "labelNamPages";
            this.labelNamPages.Size = new System.Drawing.Size(77, 13);
            this.labelNamPages.TabIndex = 6;
            this.labelNamPages.Text = "Namber Pages";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(22, 87);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(32, 13);
            this.labelAutor.TabIndex = 7;
            this.labelAutor.Text = "Autor";
            // 
            // labelPubHouse
            // 
            this.labelPubHouse.AutoSize = true;
            this.labelPubHouse.Location = new System.Drawing.Point(22, 114);
            this.labelPubHouse.Name = "labelPubHouse";
            this.labelPubHouse.Size = new System.Drawing.Size(89, 13);
            this.labelPubHouse.TabIndex = 8;
            this.labelPubHouse.Text = "Publishing House";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 220);
            this.Controls.Add(this.labelPubHouse);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelNamPages);
            this.Controls.Add(this.labelNameBook);
            this.Controls.Add(this.TextBoxPubHouse);
            this.Controls.Add(this.TextBoxAutor);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.TextBoxNamPages);
            this.Controls.Add(this.TextBoxNameBook);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNameBook;
        private System.Windows.Forms.TextBox TextBoxNamPages;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.ComboBox TextBoxAutor;
        private System.Windows.Forms.ComboBox TextBoxPubHouse;
        private System.Windows.Forms.Label labelNameBook;
        private System.Windows.Forms.Label labelNamPages;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelPubHouse;
    }
}