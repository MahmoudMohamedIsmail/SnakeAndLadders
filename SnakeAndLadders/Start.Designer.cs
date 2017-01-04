namespace SnakeAndLadders
{
    partial class Start
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
            this.Startbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfPlayers = new System.Windows.Forms.TextBox();
            this.Gobt = new System.Windows.Forms.Button();
            this.PlayersNames = new System.Windows.Forms.TextBox();
            this.Player = new System.Windows.Forms.Label();
            this.AddPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Startbt
            // 
            this.Startbt.Location = new System.Drawing.Point(103, 211);
            this.Startbt.Name = "Startbt";
            this.Startbt.Size = new System.Drawing.Size(75, 23);
            this.Startbt.TabIndex = 0;
            this.Startbt.Text = "Start";
            this.Startbt.UseVisualStyleBackColor = true;
            this.Startbt.Click += new System.EventHandler(this.Startbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Players";
            // 
            // NumOfPlayers
            // 
            this.NumOfPlayers.Location = new System.Drawing.Point(113, 26);
            this.NumOfPlayers.Name = "NumOfPlayers";
            this.NumOfPlayers.Size = new System.Drawing.Size(65, 20);
            this.NumOfPlayers.TabIndex = 2;
            // 
            // Gobt
            // 
            this.Gobt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Gobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobt.ForeColor = System.Drawing.Color.DeepPink;
            this.Gobt.Location = new System.Drawing.Point(296, 263);
            this.Gobt.Name = "Gobt";
            this.Gobt.Size = new System.Drawing.Size(75, 50);
            this.Gobt.TabIndex = 4;
            this.Gobt.Text = "GO";
            this.Gobt.UseVisualStyleBackColor = false;
            this.Gobt.Click += new System.EventHandler(this.Gobt_Click);
            // 
            // PlayersNames
            // 
            this.PlayersNames.Location = new System.Drawing.Point(78, 76);
            this.PlayersNames.Name = "PlayersNames";
            this.PlayersNames.Size = new System.Drawing.Size(100, 20);
            this.PlayersNames.TabIndex = 5;
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(12, 79);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(42, 13);
            this.Player.TabIndex = 6;
            this.Player.Text = "Player1";
            // 
            // AddPlayers
            // 
            this.AddPlayers.Location = new System.Drawing.Point(126, 114);
            this.AddPlayers.Name = "AddPlayers";
            this.AddPlayers.Size = new System.Drawing.Size(52, 23);
            this.AddPlayers.TabIndex = 7;
            this.AddPlayers.Text = "Add";
            this.AddPlayers.UseVisualStyleBackColor = true;
            this.AddPlayers.Click += new System.EventHandler(this.AddPlayers_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 323);
            this.Controls.Add(this.AddPlayers);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.PlayersNames);
            this.Controls.Add(this.Gobt);
            this.Controls.Add(this.NumOfPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Startbt);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumOfPlayers;
        private System.Windows.Forms.Button Gobt;
        private System.Windows.Forms.TextBox PlayersNames;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Button AddPlayers;
    }
}