using System;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FrmGameWin : Form
    {
        public FrmGameWin()
        {
            InitializeComponent();
        }

        private void GameWin_Load(object sender, EventArgs e)
        {
            FrmPrincipal.stopSimpleSound();
            FrmPrincipal.playSimpleSound(Properties.Resources.Sunrise);

            lblTurns.Text = "Turns: " + FrmPrincipal.Turns;

            if (FrmPrincipal.Turns <= 7)
            {
                picRank.Image = Properties.Resources.SRank;
            }
            else if (FrmPrincipal.Turns <= 14)
            {
                picRank.Image = Properties.Resources.ARank;
            }
            else if (FrmPrincipal.Turns <= 20)
            {
                picRank.Image = Properties.Resources.BRank;
            }
            else if (FrmPrincipal.Turns <= 25)
            {
                picRank.Image = Properties.Resources.CRank;
            }
            else
            {
                picRank.Image = Properties.Resources.DRank;
            }
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            FrmPrincipal.stopSimpleSound();
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            FrmPrincipal.stopSimpleSound();
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.ShowDialog();
        }
    }
}