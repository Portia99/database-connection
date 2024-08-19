namespace DB1Project
{
    partial class addForm
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
            this.titleIDlabel = new System.Windows.Forms.Label();
            this.titleIDTextBox = new System.Windows.Forms.TextBox();
            this.titleNamelabel = new System.Windows.Forms.Label();
            this.titleNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleIDlabel
            // 
            this.titleIDlabel.AutoSize = true;
            this.titleIDlabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleIDlabel.Location = new System.Drawing.Point(39, 50);
            this.titleIDlabel.Name = "titleIDlabel";
            this.titleIDlabel.Size = new System.Drawing.Size(49, 16);
            this.titleIDlabel.TabIndex = 0;
            this.titleIDlabel.Text = "Title ID";
            // 
            // titleIDTextBox
            // 
            this.titleIDTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleIDTextBox.Location = new System.Drawing.Point(115, 47);
            this.titleIDTextBox.Name = "titleIDTextBox";
            this.titleIDTextBox.Size = new System.Drawing.Size(185, 23);
            this.titleIDTextBox.TabIndex = 1;
            // 
            // titleNamelabel
            // 
            this.titleNamelabel.AutoSize = true;
            this.titleNamelabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNamelabel.Location = new System.Drawing.Point(39, 83);
            this.titleNamelabel.Name = "titleNamelabel";
            this.titleNamelabel.Size = new System.Drawing.Size(70, 16);
            this.titleNamelabel.TabIndex = 0;
            this.titleNamelabel.Text = "Title Name";
            // 
            // titleNameTextBox
            // 
            this.titleNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNameTextBox.Location = new System.Drawing.Point(115, 80);
            this.titleNameTextBox.Name = "titleNameTextBox";
            this.titleNameTextBox.Size = new System.Drawing.Size(185, 23);
            this.titleNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(145, 298);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 37);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 347);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.titleNameTextBox);
            this.Controls.Add(this.titleNamelabel);
            this.Controls.Add(this.titleIDTextBox);
            this.Controls.Add(this.titleIDlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Title";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleIDlabel;
        private System.Windows.Forms.TextBox titleIDTextBox;
        private System.Windows.Forms.Label titleNamelabel;
        private System.Windows.Forms.TextBox titleNameTextBox;
        private System.Windows.Forms.Button addButton;
    }
}