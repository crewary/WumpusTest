namespace WumpusTest2010
{
    partial class Form1
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
            this.ConstructorButton = new System.Windows.Forms.Button();
            this.firstRoom = new System.Windows.Forms.TextBox();
            this.newRoom = new System.Windows.Forms.TextBox();
            this.whether = new System.Windows.Forms.TextBox();
            this.wumpus = new System.Windows.Forms.TextBox();
            this.isWumpusThere = new System.Windows.Forms.TextBox();
            this.originalRoom = new System.Windows.Forms.Label();
            this.otherRoom = new System.Windows.Forms.Label();
            this.whetha = new System.Windows.Forms.Label();
            this.moor = new System.Windows.Forms.Label();
            this.iz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConstructorButton
            // 
            this.ConstructorButton.Location = new System.Drawing.Point(13, 13);
            this.ConstructorButton.Name = "ConstructorButton";
            this.ConstructorButton.Size = new System.Drawing.Size(75, 23);
            this.ConstructorButton.TabIndex = 0;
            this.ConstructorButton.Text = "test";
            this.ConstructorButton.UseVisualStyleBackColor = true;
            this.ConstructorButton.Click += new System.EventHandler(this.ConstructorButton_Click);
            // 
            // firstRoom
            // 
            this.firstRoom.Location = new System.Drawing.Point(95, 13);
            this.firstRoom.Name = "firstRoom";
            this.firstRoom.Size = new System.Drawing.Size(100, 20);
            this.firstRoom.TabIndex = 1;
            this.firstRoom.TextChanged += new System.EventHandler(this.firstRoom_TextChanged);
            // 
            // newRoom
            // 
            this.newRoom.Location = new System.Drawing.Point(95, 40);
            this.newRoom.Name = "newRoom";
            this.newRoom.Size = new System.Drawing.Size(100, 20);
            this.newRoom.TabIndex = 2;
            this.newRoom.TextChanged += new System.EventHandler(this.newRoom_TextChanged);
            // 
            // whether
            // 
            this.whether.Location = new System.Drawing.Point(95, 67);
            this.whether.Name = "whether";
            this.whether.Size = new System.Drawing.Size(100, 20);
            this.whether.TabIndex = 3;
            this.whether.TextChanged += new System.EventHandler(this.whether_TextChanged);
            // 
            // wumpus
            // 
            this.wumpus.Location = new System.Drawing.Point(95, 94);
            this.wumpus.Name = "wumpus";
            this.wumpus.Size = new System.Drawing.Size(100, 20);
            this.wumpus.TabIndex = 4;
            this.wumpus.TextChanged += new System.EventHandler(this.wumpus_TextChanged);
            // 
            // isWumpusThere
            // 
            this.isWumpusThere.Location = new System.Drawing.Point(95, 121);
            this.isWumpusThere.Name = "isWumpusThere";
            this.isWumpusThere.Size = new System.Drawing.Size(100, 20);
            this.isWumpusThere.TabIndex = 5;
            this.isWumpusThere.TextChanged += new System.EventHandler(this.isWumpusThere_TextChanged);
            // 
            // originalRoom
            // 
            this.originalRoom.AutoSize = true;
            this.originalRoom.Location = new System.Drawing.Point(202, 13);
            this.originalRoom.Name = "originalRoom";
            this.originalRoom.Size = new System.Drawing.Size(73, 13);
            this.originalRoom.TabIndex = 6;
            this.originalRoom.Text = "Original Room";
            this.originalRoom.Click += new System.EventHandler(this.originalRoom_Click);
            // 
            // otherRoom
            // 
            this.otherRoom.AutoSize = true;
            this.otherRoom.Location = new System.Drawing.Point(205, 40);
            this.otherRoom.Name = "otherRoom";
            this.otherRoom.Size = new System.Drawing.Size(64, 13);
            this.otherRoom.TabIndex = 7;
            this.otherRoom.Text = "Other Room";
            this.otherRoom.Click += new System.EventHandler(this.otherRoom_Click);
            // 
            // whetha
            // 
            this.whetha.AutoSize = true;
            this.whetha.Location = new System.Drawing.Point(208, 67);
            this.whetha.Name = "whetha";
            this.whetha.Size = new System.Drawing.Size(48, 13);
            this.whetha.TabIndex = 8;
            this.whetha.Text = "Whether";
            this.whetha.Click += new System.EventHandler(this.whetha_Click);
            // 
            // moor
            // 
            this.moor.AutoSize = true;
            this.moor.Location = new System.Drawing.Point(208, 94);
            this.moor.Name = "moor";
            this.moor.Size = new System.Drawing.Size(35, 13);
            this.moor.TabIndex = 9;
            this.moor.Text = "Room";
            this.moor.Click += new System.EventHandler(this.moor_Click);
            // 
            // iz
            // 
            this.iz.AutoSize = true;
            this.iz.Location = new System.Drawing.Point(211, 121);
            this.iz.Name = "iz";
            this.iz.Size = new System.Drawing.Size(60, 13);
            this.iz.TabIndex = 10;
            this.iz.Text = "Is Wumpus";
            this.iz.Click += new System.EventHandler(this.iz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.iz);
            this.Controls.Add(this.moor);
            this.Controls.Add(this.whetha);
            this.Controls.Add(this.otherRoom);
            this.Controls.Add(this.originalRoom);
            this.Controls.Add(this.isWumpusThere);
            this.Controls.Add(this.wumpus);
            this.Controls.Add(this.whether);
            this.Controls.Add(this.newRoom);
            this.Controls.Add(this.firstRoom);
            this.Controls.Add(this.ConstructorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConstructorButton;
        private System.Windows.Forms.TextBox firstRoom;
        private System.Windows.Forms.TextBox newRoom;
        private System.Windows.Forms.TextBox whether;
        private System.Windows.Forms.TextBox wumpus;
        private System.Windows.Forms.TextBox isWumpusThere;
        private System.Windows.Forms.Label originalRoom;
        private System.Windows.Forms.Label otherRoom;
        private System.Windows.Forms.Label whetha;
        private System.Windows.Forms.Label moor;
        private System.Windows.Forms.Label iz;
    }
}

