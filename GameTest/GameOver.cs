using System;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FrmGameOver : Form
    {
        public FrmGameOver()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            FrmPrincipal.stopSimpleSound();
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGameOver_Load(object sender, EventArgs e)
        {
            FrmPrincipal.playSimpleSound(Properties.Resources.Over);
        }
    }
}
