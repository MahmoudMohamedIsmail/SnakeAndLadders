namespace SnakeAndLadders
{
    partial class Snakes
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
            this.Grid = new System.Windows.Forms.Panel();
            this.RollBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DicePic = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndPoint = new System.Windows.Forms.PictureBox();
            this.StartPoint = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NewGames = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(401, 401);
            this.Grid.TabIndex = 0;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // RollBut
            // 
            this.RollBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollBut.Location = new System.Drawing.Point(10, 74);
            this.RollBut.Name = "RollBut";
            this.RollBut.Size = new System.Drawing.Size(87, 26);
            this.RollBut.TabIndex = 1;
            this.RollBut.Text = "Roll";
            this.RollBut.UseVisualStyleBackColor = true;
            this.RollBut.Click += new System.EventHandler(this.RollBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DicePic);
            this.groupBox1.Controls.Add(this.RollBut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(189, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice";
            // 
            // DicePic
            // 
            this.DicePic.BackColor = System.Drawing.Color.White;
            this.DicePic.Location = new System.Drawing.Point(33, 19);
            this.DicePic.Name = "DicePic";
            this.DicePic.Size = new System.Drawing.Size(45, 45);
            this.DicePic.TabIndex = 5;
            this.DicePic.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EndPoint);
            this.groupBox2.Controls.Add(this.StartPoint);
            this.groupBox2.Location = new System.Drawing.Point(12, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Location";
            // 
            // EndPoint
            // 
            this.EndPoint.BackColor = System.Drawing.Color.Red;
            this.EndPoint.Location = new System.Drawing.Point(6, 62);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(36, 32);
            this.EndPoint.TabIndex = 1;
            this.EndPoint.TabStop = false;
            // 
            // StartPoint
            // 
            this.StartPoint.BackColor = System.Drawing.Color.DarkGreen;
            this.StartPoint.Location = new System.Drawing.Point(6, 19);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(36, 32);
            this.StartPoint.TabIndex = 0;
            this.StartPoint.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NewGames
            // 
            this.NewGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGames.Location = new System.Drawing.Point(458, 456);
            this.NewGames.Name = "NewGames";
            this.NewGames.Size = new System.Drawing.Size(75, 28);
            this.NewGames.TabIndex = 10;
            this.NewGames.Text = "New Game";
            this.NewGames.UseVisualStyleBackColor = true;
            this.NewGames.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(320, 467);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(0, 17);
            this.PlayerName.TabIndex = 11;
            // 
            // Snakes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 527);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.NewGames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Snakes";
            this.Text = "Snakes And Ladders";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DicePic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Grid;
        private System.Windows.Forms.Button RollBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EndPoint;
        private System.Windows.Forms.PictureBox StartPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox DicePic;
        private System.Windows.Forms.Button NewGames;
        private System.Windows.Forms.Label PlayerName;
    }
}

