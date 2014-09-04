namespace WumpusTest2010
{
    partial class WinningForm
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
            this.continueButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.enterNameBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(13, 119);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(13, 82);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(265, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // enterNameBox
            // 
            this.enterNameBox.AutoSize = true;
            this.enterNameBox.Location = new System.Drawing.Point(13, 63);
            this.enterNameBox.Name = "enterNameBox";
            this.enterNameBox.Size = new System.Drawing.Size(95, 13);
            this.enterNameBox.TabIndex = 2;
            this.enterNameBox.Text = "Enter Name Below";
            // 
            // WinningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 262);
            this.Controls.Add(this.enterNameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.continueButton);
            this.Name = "WinningForm";
            this.Text = "You Win!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label enterNameBox;
    }
}