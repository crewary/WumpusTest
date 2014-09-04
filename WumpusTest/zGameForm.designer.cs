namespace WumpusTest2010
{
    partial class zGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zGameForm));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.ScoreTracker = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.buyArrows = new System.Windows.Forms.Button();
            this.dialogue = new System.Windows.Forms.TextBox();
            this.shoot1 = new System.Windows.Forms.Button();
            this.shoot2 = new System.Windows.Forms.Button();
            this.shoot3 = new System.Windows.Forms.Button();
            this.ClueBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(23, 41);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(72, 20);
            this.inputBox.TabIndex = 0;
            // 
            // ScoreTracker
            // 
            this.ScoreTracker.AutoSize = true;
            this.ScoreTracker.Location = new System.Drawing.Point(20, 352);
            this.ScoreTracker.Name = "ScoreTracker";
            this.ScoreTracker.Size = new System.Drawing.Size(72, 13);
            this.ScoreTracker.TabIndex = 1;
            this.ScoreTracker.Text = "ScoreTracker";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(30, 297);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(100, 20);
            this.room.TabIndex = 4;
            this.room.TextChanged += new System.EventHandler(this.room_TextChanged);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(294, 106);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(75, 23);
            this.option1.TabIndex = 5;
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(294, 136);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(75, 23);
            this.option2.TabIndex = 6;
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(294, 166);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(75, 23);
            this.option3.TabIndex = 7;
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // buyArrows
            // 
            this.buyArrows.Location = new System.Drawing.Point(294, 12);
            this.buyArrows.Name = "buyArrows";
            this.buyArrows.Size = new System.Drawing.Size(75, 23);
            this.buyArrows.TabIndex = 9;
            this.buyArrows.Text = "Buy Arrows";
            this.buyArrows.UseVisualStyleBackColor = true;
            this.buyArrows.Click += new System.EventHandler(this.buyArrows_Click);
            // 
            // dialogue
            // 
            this.dialogue.Location = new System.Drawing.Point(294, 261);
            this.dialogue.Name = "dialogue";
            this.dialogue.Size = new System.Drawing.Size(248, 20);
            this.dialogue.TabIndex = 10;
            this.dialogue.TextChanged += new System.EventHandler(this.dialogue_TextChanged);
            // 
            // shoot1
            // 
            this.shoot1.Location = new System.Drawing.Point(376, 106);
            this.shoot1.Name = "shoot1";
            this.shoot1.Size = new System.Drawing.Size(199, 23);
            this.shoot1.TabIndex = 11;
            this.shoot1.UseVisualStyleBackColor = true;
            this.shoot1.Click += new System.EventHandler(this.shoot1_Click);
            // 
            // shoot2
            // 
            this.shoot2.Location = new System.Drawing.Point(375, 136);
            this.shoot2.Name = "shoot2";
            this.shoot2.Size = new System.Drawing.Size(200, 23);
            this.shoot2.TabIndex = 12;
            this.shoot2.UseVisualStyleBackColor = true;
            this.shoot2.Click += new System.EventHandler(this.shoot2_Click);
            // 
            // shoot3
            // 
            this.shoot3.Location = new System.Drawing.Point(374, 166);
            this.shoot3.Name = "shoot3";
            this.shoot3.Size = new System.Drawing.Size(201, 23);
            this.shoot3.TabIndex = 13;
            this.shoot3.UseVisualStyleBackColor = true;
            this.shoot3.Click += new System.EventHandler(this.shoot3_Click);
            // 
            // ClueBox
            // 
            this.ClueBox.Location = new System.Drawing.Point(23, 106);
            this.ClueBox.Multiline = true;
            this.ClueBox.Name = "ClueBox";
            this.ClueBox.ReadOnly = true;
            this.ClueBox.Size = new System.Drawing.Size(252, 118);
            this.ClueBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Buy Secret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buySecret_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(376, 44);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(199, 47);
            this.label1.TabIndex = 17;
            this.label1.TextChanged += new System.EventHandler(this.SecretBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Start Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(620, 353);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(136, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(373, 464);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // zGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 374);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClueBox);
            this.Controls.Add(this.shoot3);
            this.Controls.Add(this.shoot2);
            this.Controls.Add(this.shoot1);
            this.Controls.Add(this.dialogue);
            this.Controls.Add(this.buyArrows);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.room);
            this.Controls.Add(this.ScoreTracker);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.pictureBox2);
            this.Name = "zGameForm";
            this.Text = "Game Form";
            this.Load += new System.EventHandler(this.zGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label ScoreTracker;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button buyArrows;
        private System.Windows.Forms.TextBox dialogue;
        private System.Windows.Forms.Button shoot1;
        private System.Windows.Forms.Button shoot2;
        private System.Windows.Forms.Button shoot3;
        private System.Windows.Forms.TextBox ClueBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}