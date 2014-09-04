namespace WumpusTest2010
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.room = new System.Windows.Forms.TextBox();
            this.ConstructorButton = new System.Windows.Forms.Button();
            this.highScoresButton = new System.Windows.Forms.Button();
            this.startGameBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.HelpButtonMain = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HelpText = new System.Windows.Forms.TextBox();
            this.readBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(336, 95);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(100, 20);
            this.room.TabIndex = 0;
            this.room.TextChanged += new System.EventHandler(this.room_TextChanged);
            // 
            // ConstructorButton
            // 
            this.ConstructorButton.Location = new System.Drawing.Point(244, 92);
            this.ConstructorButton.Name = "ConstructorButton";
            this.ConstructorButton.Size = new System.Drawing.Size(75, 23);
            this.ConstructorButton.TabIndex = 1;
            this.ConstructorButton.Text = "Construct";
            this.ConstructorButton.UseVisualStyleBackColor = true;
            this.ConstructorButton.Click += new System.EventHandler(this.ConstructorButton_Click);
            // 
            // highScoresButton
            // 
            this.highScoresButton.Location = new System.Drawing.Point(19, 72);
            this.highScoresButton.Name = "highScoresButton";
            this.highScoresButton.Size = new System.Drawing.Size(102, 23);
            this.highScoresButton.TabIndex = 3;
            this.highScoresButton.Text = "View High Scores";
            this.highScoresButton.UseVisualStyleBackColor = true;
            this.highScoresButton.Click += new System.EventHandler(this.showHighScores_Click);
            // 
            // startGameBox
            // 
            this.startGameBox.Location = new System.Drawing.Point(19, 41);
            this.startGameBox.Name = "startGameBox";
            this.startGameBox.Size = new System.Drawing.Size(102, 23);
            this.startGameBox.TabIndex = 1;
            this.startGameBox.Text = "Start new game?";
            this.startGameBox.UseVisualStyleBackColor = true;
            this.startGameBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // HelpButtonMain
            // 
            this.HelpButtonMain.Location = new System.Drawing.Point(19, 100);
            this.HelpButtonMain.Name = "HelpButtonMain";
            this.HelpButtonMain.Size = new System.Drawing.Size(102, 23);
            this.HelpButtonMain.TabIndex = 13;
            this.HelpButtonMain.Text = "Help";
            this.HelpButtonMain.UseVisualStyleBackColor = true;
            this.HelpButtonMain.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(19, 129);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(19, 212);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HelpText
            // 
            this.HelpText.Location = new System.Drawing.Point(21, 12);
            this.HelpText.Multiline = true;
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(432, 194);
            this.HelpText.TabIndex = 16;
            // 
            // readBox
            // 
            this.readBox.AutoSize = true;
            this.readBox.Location = new System.Drawing.Point(21, 242);
            this.readBox.Name = "readBox";
            this.readBox.Size = new System.Drawing.Size(46, 13);
            this.readBox.TabIndex = 17;
            this.readBox.Text = "readBox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 284);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.highScoresButton);
            this.Controls.Add(this.startGameBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelpButtonMain);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConstructorButton);
            this.Controls.Add(this.room);
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.Button ConstructorButton;
        private System.Windows.Forms.Button highScoresButton;
        private System.Windows.Forms.Button startGameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button HelpButtonMain;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox HelpText;
        private System.Windows.Forms.Label readBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}