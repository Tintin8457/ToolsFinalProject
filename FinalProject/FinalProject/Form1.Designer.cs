
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
            this.LevelText = new System.Windows.Forms.TextBox();
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.TotalPointsText = new System.Windows.Forms.TextBox();
            this.TotalPointsBox = new System.Windows.Forms.NumericUpDown();
            this.CurrentPointsText = new System.Windows.Forms.TextBox();
            this.CurrentPointsBox = new System.Windows.Forms.NumericUpDown();
            this.NeededPointsText = new System.Windows.Forms.TextBox();
            this.NeededPointsBox = new System.Windows.Forms.NumericUpDown();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.ChampionNameBox = new System.Windows.Forms.GroupBox();
            this.Champions = new System.Windows.Forms.ListBox();
            this.ChampionPointsBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LevelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeededPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.ChampionNameBox.SuspendLayout();
            this.ChampionPointsBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelBox
            // 
            this.LevelBox.Location = new System.Drawing.Point(350, 85);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(87, 20);
            this.LevelBox.TabIndex = 0;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(191, 30);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(246, 20);
            this.ID_Box.TabIndex = 1;
            // 
            // LevelText
            // 
            this.LevelText.Location = new System.Drawing.Point(350, 59);
            this.LevelText.Name = "LevelText";
            this.LevelText.Size = new System.Drawing.Size(87, 20);
            this.LevelText.TabIndex = 2;
            this.LevelText.Text = "Champion Level";
            // 
            // ID_Text
            // 
            this.ID_Text.Location = new System.Drawing.Point(282, 4);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(73, 20);
            this.ID_Text.TabIndex = 3;
            this.ID_Text.Text = "Champion ID";
            // 
            // TotalPointsText
            // 
            this.TotalPointsText.Location = new System.Drawing.Point(6, 19);
            this.TotalPointsText.Name = "TotalPointsText";
            this.TotalPointsText.Size = new System.Drawing.Size(125, 20);
            this.TotalPointsText.TabIndex = 5;
            this.TotalPointsText.Text = "Total Champion Points";
            // 
            // TotalPointsBox
            // 
            this.TotalPointsBox.Location = new System.Drawing.Point(6, 45);
            this.TotalPointsBox.Name = "TotalPointsBox";
            this.TotalPointsBox.Size = new System.Drawing.Size(125, 20);
            this.TotalPointsBox.TabIndex = 4;
            // 
            // CurrentPointsText
            // 
            this.CurrentPointsText.Location = new System.Drawing.Point(6, 84);
            this.CurrentPointsText.Name = "CurrentPointsText";
            this.CurrentPointsText.Size = new System.Drawing.Size(125, 20);
            this.CurrentPointsText.TabIndex = 7;
            this.CurrentPointsText.Text = "Current Champion Points";
            // 
            // CurrentPointsBox
            // 
            this.CurrentPointsBox.Location = new System.Drawing.Point(6, 110);
            this.CurrentPointsBox.Name = "CurrentPointsBox";
            this.CurrentPointsBox.Size = new System.Drawing.Size(125, 20);
            this.CurrentPointsBox.TabIndex = 6;
            // 
            // NeededPointsText
            // 
            this.NeededPointsText.Location = new System.Drawing.Point(5, 146);
            this.NeededPointsText.Name = "NeededPointsText";
            this.NeededPointsText.Size = new System.Drawing.Size(126, 20);
            this.NeededPointsText.TabIndex = 9;
            this.NeededPointsText.Text = "Champion Points Needed";
            // 
            // NeededPointsBox
            // 
            this.NeededPointsBox.Location = new System.Drawing.Point(5, 172);
            this.NeededPointsBox.Name = "NeededPointsBox";
            this.NeededPointsBox.Size = new System.Drawing.Size(126, 20);
            this.NeededPointsBox.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(350, 125);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(87, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Tokens Earned";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(350, 151);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown5.TabIndex = 10;
            // 
            // ChampionNameBox
            // 
            this.ChampionNameBox.Controls.Add(this.Champions);
            this.ChampionNameBox.Location = new System.Drawing.Point(3, 4);
            this.ChampionNameBox.Name = "ChampionNameBox";
            this.ChampionNameBox.Size = new System.Drawing.Size(170, 257);
            this.ChampionNameBox.TabIndex = 14;
            this.ChampionNameBox.TabStop = false;
            this.ChampionNameBox.Text = "Current Champions";
            // 
            // Champions
            // 
            this.Champions.FormattingEnabled = true;
            this.Champions.Location = new System.Drawing.Point(6, 19);
            this.Champions.MaximumSize = new System.Drawing.Size(158, 237);
            this.Champions.Name = "Champions";
            this.Champions.Size = new System.Drawing.Size(158, 225);
            this.Champions.TabIndex = 15;
            // 
            // ChampionPointsBox
            // 
            this.ChampionPointsBox.Controls.Add(this.TotalPointsText);
            this.ChampionPointsBox.Controls.Add(this.TotalPointsBox);
            this.ChampionPointsBox.Controls.Add(this.CurrentPointsText);
            this.ChampionPointsBox.Controls.Add(this.CurrentPointsBox);
            this.ChampionPointsBox.Controls.Add(this.NeededPointsBox);
            this.ChampionPointsBox.Controls.Add(this.NeededPointsText);
            this.ChampionPointsBox.Location = new System.Drawing.Point(191, 56);
            this.ChampionPointsBox.Name = "ChampionPointsBox";
            this.ChampionPointsBox.Size = new System.Drawing.Size(139, 201);
            this.ChampionPointsBox.TabIndex = 15;
            this.ChampionPointsBox.TabStop = false;
            this.ChampionPointsBox.Text = "Champion Points";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChampionNameBox);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.ChampionPointsBox);
            this.panel1.Controls.Add(this.ID_Text);
            this.panel1.Controls.Add(this.LevelText);
            this.panel1.Controls.Add(this.ID_Box);
            this.panel1.Controls.Add(this.LevelBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 266);
            this.panel1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 267);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Champion Mastery- LOL API";
            ((System.ComponentModel.ISupportInitialize)(this.LevelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeededPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ChampionNameBox.ResumeLayout(false);
            this.ChampionPointsBox.ResumeLayout(false);
            this.ChampionPointsBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LevelBox;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox LevelText;
        private System.Windows.Forms.TextBox ID_Text;
        private System.Windows.Forms.TextBox TotalPointsText;
        private System.Windows.Forms.NumericUpDown TotalPointsBox;
        private System.Windows.Forms.TextBox CurrentPointsText;
        private System.Windows.Forms.NumericUpDown CurrentPointsBox;
        private System.Windows.Forms.TextBox NeededPointsText;
        private System.Windows.Forms.NumericUpDown NeededPointsBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.GroupBox ChampionNameBox;
        private System.Windows.Forms.ListBox Champions;
        private System.Windows.Forms.GroupBox ChampionPointsBox;
        private System.Windows.Forms.Panel panel1;
    }
}

