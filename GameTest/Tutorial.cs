using System;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FrmTutorial : Form
    {
        public FrmTutorial()
        {
            InitializeComponent();
        }

        //Starts the game when pressed and closes both Game and Tutorial
        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActions.Visible = true;
            cboActions.Items.Clear();
            cboActions.Text = "";

            if (cboItems.SelectedIndex == 0)
            {
                cboActions.Items.Add("Look at bed");
                cboActions.Items.Add("Sleep");
            }

            if (cboItems.SelectedIndex == 1)
            {
                cboActions.Items.Add("Examine the bars");
                cboActions.Items.Add("Look around");
            }

            if (cboItems.SelectedIndex == 2)
            {
                cboActions.Items.Add("Examine cards");
                cboActions.Items.Add("Shuffle");
            }
        }

        private void cboActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActions.Visible = false;

            if((string)cboActions.SelectedItem == "Look at bed")
            {
                txtContext.Text = "The sheets' fabrics are completely frayed, but looks comfortable enough.";
            }

            if ((string)cboActions.SelectedItem == "Sleep")
            {
                txtContext.Text = "You only slept for 4 hours because of how unconfortable it felt during the night.";
            }

            if ((string)cboActions.SelectedItem == "Examine the bars")
            {
                txtContext.Text = "Ordinary black iron prison bars from your cell.";
            }

            if ((string)cboActions.SelectedItem == "Look around")
            {
                txtContext.Text = "From the bars, you can only see other dark cells around your cell block.";
            }

            if ((string)cboActions.SelectedItem == "Examine cards")
            {
                txtContext.Text = "Just your classic 52-card Poker pack.";
            }

            if ((string)cboActions.SelectedItem == "Shuffle")
            {
                txtContext.Text = "You shuffled your cards and separated them in decks for your next Poker match at Saturday.";
            }
        }

        private void FrmTutorial_Load(object sender, EventArgs e)
        {
            FrmPrincipal.playSimpleSound(Properties.Resources.GameTutorial);
        }
    }
}
