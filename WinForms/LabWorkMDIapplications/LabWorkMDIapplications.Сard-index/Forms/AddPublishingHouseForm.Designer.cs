namespace LabWorkMDIapplications.Сard_index
{
    partial class AddPublishingHouseForm
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
            this.ButtonAddPubHouse = new System.Windows.Forms.Button();
            this.labelPubHouseName = new System.Windows.Forms.Label();
            this.TextBoxNameHouse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonAddPubHouse
            // 
            this.ButtonAddPubHouse.Location = new System.Drawing.Point(98, 111);
            this.ButtonAddPubHouse.Name = "ButtonAddPubHouse";
            this.ButtonAddPubHouse.Size = new System.Drawing.Size(120, 35);
            this.ButtonAddPubHouse.TabIndex = 14;
            this.ButtonAddPubHouse.Text = "Add PubHouse";
            this.ButtonAddPubHouse.UseVisualStyleBackColor = true;
            this.ButtonAddPubHouse.Click += new System.EventHandler(this.ButtonAddPubHouse_Click);
            // 
            // labelPubHouseName
            // 
            this.labelPubHouseName.AutoSize = true;
            this.labelPubHouseName.Location = new System.Drawing.Point(8, 45);
            this.labelPubHouseName.Name = "labelPubHouseName";
            this.labelPubHouseName.Size = new System.Drawing.Size(120, 13);
            this.labelPubHouseName.TabIndex = 13;
            this.labelPubHouseName.Text = "Publishing House Name";
            // 
            // TextBoxNameHouse
            // 
            this.TextBoxNameHouse.Location = new System.Drawing.Point(151, 45);
            this.TextBoxNameHouse.Name = "TextBoxNameHouse";
            this.TextBoxNameHouse.Size = new System.Drawing.Size(158, 20);
            this.TextBoxNameHouse.TabIndex = 12;
            // 
            // AddPublishingHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 158);
            this.Controls.Add(this.ButtonAddPubHouse);
            this.Controls.Add(this.labelPubHouseName);
            this.Controls.Add(this.TextBoxNameHouse);
            this.Name = "AddPublishingHouseForm";
            this.Text = "AddPublishingHouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddPubHouse;
        private System.Windows.Forms.Label labelPubHouseName;
        private System.Windows.Forms.TextBox TextBoxNameHouse;
    }
}