
namespace FinalProject
{
    partial class MainForm
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
            this.LevelBox = new System.Windows.Forms.NumericUpDown();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.TotalPointsBox = new System.Windows.Forms.NumericUpDown();
            this.CurrentPointsBox = new System.Windows.Forms.NumericUpDown();
            this.NeededPointsBox = new System.Windows.Forms.NumericUpDown();
            this.TokensEarnedBox = new System.Windows.Forms.NumericUpDown();
            this.ChampionNameBox = new System.Windows.Forms.GroupBox();
            this.ChampionListBox = new System.Windows.Forms.ListBox();
            this.ChampionPointsBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.apikey_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LevelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeededPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokensEarnedBox)).BeginInit();
            this.ChampionNameBox.SuspendLayout();
            this.ChampionPointsBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelBox
            // 
            this.LevelBox.Location = new System.Drawing.Point(348, 121);
            this.LevelBox.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(87, 20);
            this.LevelBox.TabIndex = 0;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(191, 68);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(244, 20);
            this.ID_Box.TabIndex = 1;
            // 
            // TotalPointsBox
            // 
            this.TotalPointsBox.Location = new System.Drawing.Point(9, 32);
            this.TotalPointsBox.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.TotalPointsBox.Name = "TotalPointsBox";
            this.TotalPointsBox.Size = new System.Drawing.Size(122, 20);
            this.TotalPointsBox.TabIndex = 4;
            // 
            // CurrentPointsBox
            // 
            this.CurrentPointsBox.Location = new System.Drawing.Point(9, 79);
            this.CurrentPointsBox.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.CurrentPointsBox.Name = "CurrentPointsBox";
            this.CurrentPointsBox.Size = new System.Drawing.Size(122, 20);
            this.CurrentPointsBox.TabIndex = 6;
            // 
            // NeededPointsBox
            // 
            this.NeededPointsBox.Location = new System.Drawing.Point(9, 128);
            this.NeededPointsBox.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.NeededPointsBox.Name = "NeededPointsBox";
            this.NeededPointsBox.Size = new System.Drawing.Size(122, 20);
            this.NeededPointsBox.TabIndex = 8;
            // 
            // TokensEarnedBox
            // 
            this.TokensEarnedBox.Location = new System.Drawing.Point(348, 177);
            this.TokensEarnedBox.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.TokensEarnedBox.Name = "TokensEarnedBox";
            this.TokensEarnedBox.Size = new System.Drawing.Size(87, 20);
            this.TokensEarnedBox.TabIndex = 10;
            // 
            // ChampionNameBox
            // 
            this.ChampionNameBox.Controls.Add(this.ChampionListBox);
            this.ChampionNameBox.Location = new System.Drawing.Point(3, 7);
            this.ChampionNameBox.Name = "ChampionNameBox";
            this.ChampionNameBox.Size = new System.Drawing.Size(170, 254);
            this.ChampionNameBox.TabIndex = 14;
            this.ChampionNameBox.TabStop = false;
            this.ChampionNameBox.Text = "Current Champions";
            // 
            // ChampionListBox
            // 
            this.ChampionListBox.FormattingEnabled = true;
            this.ChampionListBox.Location = new System.Drawing.Point(6, 19);
            this.ChampionListBox.MaximumSize = new System.Drawing.Size(158, 237);
            this.ChampionListBox.Name = "ChampionListBox";
            this.ChampionListBox.Size = new System.Drawing.Size(158, 225);
            this.ChampionListBox.TabIndex = 15;
            this.ChampionListBox.SelectedIndexChanged += new System.EventHandler(this.Champions_SelectedIndexChanged);
            // 
            // ChampionPointsBox
            // 
            this.ChampionPointsBox.Controls.Add(this.label3);
            this.ChampionPointsBox.Controls.Add(this.label2);
            this.ChampionPointsBox.Controls.Add(this.label1);
            this.ChampionPointsBox.Controls.Add(this.TotalPointsBox);
            this.ChampionPointsBox.Controls.Add(this.CurrentPointsBox);
            this.ChampionPointsBox.Controls.Add(this.NeededPointsBox);
            this.ChampionPointsBox.Location = new System.Drawing.Point(191, 105);
            this.ChampionPointsBox.Name = "ChampionPointsBox";
            this.ChampionPointsBox.Size = new System.Drawing.Size(139, 156);
            this.ChampionPointsBox.TabIndex = 15;
            this.ChampionPointsBox.TabStop = false;
            this.ChampionPointsBox.Text = "Champion Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Champion Points Needed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Current Champion Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Champion Points";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.apikey_Box);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RoomDescriptionLabel);
            this.panel1.Controls.Add(this.ChampionNameBox);
            this.panel1.Controls.Add(this.TokensEarnedBox);
            this.panel1.Controls.Add(this.ChampionPointsBox);
            this.panel1.Controls.Add(this.ID_Box);
            this.panel1.Controls.Add(this.LevelBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 266);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Enter Riot API Key";
            // 
            // apikey_Box
            // 
            this.apikey_Box.Location = new System.Drawing.Point(191, 23);
            this.apikey_Box.Name = "apikey_Box";
            this.apikey_Box.Size = new System.Drawing.Size(244, 20);
            this.apikey_Box.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tokens Earned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Champion Level";
            // 
            // RoomDescriptionLabel
            // 
            this.RoomDescriptionLabel.AutoSize = true;
            this.RoomDescriptionLabel.Location = new System.Drawing.Point(284, 52);
            this.RoomDescriptionLabel.Name = "RoomDescriptionLabel";
            this.RoomDescriptionLabel.Size = new System.Drawing.Size(68, 13);
            this.RoomDescriptionLabel.TabIndex = 16;
            this.RoomDescriptionLabel.Text = "Champion ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Champion Mastery- LOL API";
            ((System.ComponentModel.ISupportInitialize)(this.LevelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeededPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokensEarnedBox)).EndInit();
            this.ChampionNameBox.ResumeLayout(false);
            this.ChampionPointsBox.ResumeLayout(false);
            this.ChampionPointsBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LevelBox;
        private System.Windows.Forms.NumericUpDown TotalPointsBox;
        private System.Windows.Forms.NumericUpDown CurrentPointsBox;
        private System.Windows.Forms.NumericUpDown NeededPointsBox;
        private System.Windows.Forms.NumericUpDown TokensEarnedBox;
        private System.Windows.Forms.GroupBox ChampionNameBox;
        private System.Windows.Forms.ListBox ChampionListBox;
        private System.Windows.Forms.GroupBox ChampionPointsBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoomDescriptionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apikey_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ID_Box;
    }
}

