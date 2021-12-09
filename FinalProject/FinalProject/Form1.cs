using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ChampionListBox.Text = "Doof";
            LevelBox.Value = 1;
            TotalPointsBox.Value = 345;
            CurrentPointsBox.Value = 3424;
            NeededPointsBox.Value = 24;
            ID_Box.Text = "48F35G43G";
            TokensEarnedBox.Value = 32;
        }

        private void Champions_SelectedIndexChanged(object sender, EventArgs e)
        {  
            try
            {
                ChampionListBox.Text = "Doof";
            }

            catch
            {
                MessageBox.Show("No champion selected!");
            }

            ChampionListBox.DisplayMember = "Name";
        }
    }
}
