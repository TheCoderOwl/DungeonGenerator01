namespace DungeonGenerator01
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
            this.MapTxt = new System.Windows.Forms.TextBox();
            this.MakeBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxRoomWidth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfRoomsTxt = new System.Windows.Forms.TextBox();
            this.MinRoomHeightTxt = new System.Windows.Forms.TextBox();
            this.MaxRoomHeightTxt = new System.Windows.Forms.TextBox();
            this.MaxRoomWidthTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MinRoomWidthTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MapTxt
            // 
            this.MapTxt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapTxt.Location = new System.Drawing.Point(587, 12);
            this.MapTxt.Multiline = true;
            this.MapTxt.Name = "MapTxt";
            this.MapTxt.Size = new System.Drawing.Size(383, 323);
            this.MapTxt.TabIndex = 0;
            // 
            // MakeBtn
            // 
            this.MakeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.MakeBtn.Location = new System.Drawing.Point(27, 25);
            this.MakeBtn.Name = "MakeBtn";
            this.MakeBtn.Size = new System.Drawing.Size(107, 62);
            this.MakeBtn.TabIndex = 1;
            this.MakeBtn.Text = "Make Rooms";
            this.MakeBtn.UseVisualStyleBackColor = false;
            this.MakeBtn.Click += new System.EventHandler(this.MakeBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(27, 329);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(107, 23);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset Map";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 323);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Make Walls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Make Doors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NumOfRooms";
            // 
            // MaxRoomWidth
            // 
            this.MaxRoomWidth.AutoSize = true;
            this.MaxRoomWidth.Location = new System.Drawing.Point(346, 395);
            this.MaxRoomWidth.Name = "MaxRoomWidth";
            this.MaxRoomWidth.Size = new System.Drawing.Size(86, 13);
            this.MaxRoomWidth.TabIndex = 7;
            this.MaxRoomWidth.Text = "MaxRoomHeight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MinRoomHeight";
            // 
            // NumOfRoomsTxt
            // 
            this.NumOfRoomsTxt.Location = new System.Drawing.Point(240, 364);
            this.NumOfRoomsTxt.Name = "NumOfRoomsTxt";
            this.NumOfRoomsTxt.Size = new System.Drawing.Size(100, 20);
            this.NumOfRoomsTxt.TabIndex = 9;
            this.NumOfRoomsTxt.Text = "6";
            // 
            // MinRoomHeightTxt
            // 
            this.MinRoomHeightTxt.Location = new System.Drawing.Point(240, 416);
            this.MinRoomHeightTxt.Name = "MinRoomHeightTxt";
            this.MinRoomHeightTxt.Size = new System.Drawing.Size(100, 20);
            this.MinRoomHeightTxt.TabIndex = 10;
            this.MinRoomHeightTxt.Text = "3";
            // 
            // MaxRoomHeightTxt
            // 
            this.MaxRoomHeightTxt.Location = new System.Drawing.Point(240, 390);
            this.MaxRoomHeightTxt.Name = "MaxRoomHeightTxt";
            this.MaxRoomHeightTxt.Size = new System.Drawing.Size(100, 20);
            this.MaxRoomHeightTxt.TabIndex = 11;
            this.MaxRoomHeightTxt.Text = "6";
            // 
            // MaxRoomWidthTxt
            // 
            this.MaxRoomWidthTxt.Location = new System.Drawing.Point(429, 390);
            this.MaxRoomWidthTxt.Name = "MaxRoomWidthTxt";
            this.MaxRoomWidthTxt.Size = new System.Drawing.Size(100, 20);
            this.MaxRoomWidthTxt.TabIndex = 12;
            this.MaxRoomWidthTxt.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "MaxRoomWidth";
            // 
            // MinRoomWidthTxt
            // 
            this.MinRoomWidthTxt.Location = new System.Drawing.Point(429, 416);
            this.MinRoomWidthTxt.Name = "MinRoomWidthTxt";
            this.MinRoomWidthTxt.Size = new System.Drawing.Size(100, 20);
            this.MinRoomWidthTxt.TabIndex = 14;
            this.MinRoomWidthTxt.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MinRoomWidth";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 53);
            this.button3.TabIndex = 16;
            this.button3.Text = "CleanUp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 53);
            this.button4.TabIndex = 17;
            this.button4.Text = "Save Dungeon";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1005, 469);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinRoomWidthTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxRoomWidthTxt);
            this.Controls.Add(this.MaxRoomHeightTxt);
            this.Controls.Add(this.MinRoomHeightTxt);
            this.Controls.Add(this.NumOfRoomsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxRoomWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.MakeBtn);
            this.Controls.Add(this.MapTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MapTxt;
        private System.Windows.Forms.Button MakeBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxRoomWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumOfRoomsTxt;
        private System.Windows.Forms.TextBox MinRoomHeightTxt;
        private System.Windows.Forms.TextBox MaxRoomHeightTxt;
        private System.Windows.Forms.TextBox MaxRoomWidthTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinRoomWidthTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

