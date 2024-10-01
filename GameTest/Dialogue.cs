using System;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FrmDialogue : Form
    {
        public FrmDialogue()
        {
            InitializeComponent();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            lblPolice.Text = "You think I was born yesterday, stupid? You have one in YOUR CELL.";
            btnAnswer1.Visible = false;
            btnAnswer2.Visible = true;
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            lblPolice.Text = "You have to go to the noose. I'm sending you right now.";
            btnAnswer2.Visible = false;
            btnAnswer3.Visible = true;
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            lblPolice.Text = "Over my dead body, knucklehead.";
            btnAnswer3.Visible = false;
            btnAnswer4.Visible = true;
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMiniGame frm = new FrmMiniGame();
            frm.ShowDialog();
        }

        private void FrmDialogue_Load(object sender, EventArgs e)
        {
            FrmPrincipal.playSimpleSound(Properties.Resources.Over);
        }
    }
}
