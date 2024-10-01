using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FrmMiniGame : Form
    {
        Image[] imgCpu = new Image[]
        {
            Properties.Resources.RockC,
            Properties.Resources.PaperC,
            Properties.Resources.ScissorC
        };

        public FrmMiniGame()
        {
            InitializeComponent();
        }

        private void ClickMove(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            picPlayer.Image = bt.BackgroundImage;
            Move playermove = ReturnPlayerMove(Convert.ToInt32(bt.Tag));
            Move cpumove = ReturnCpuMove();
            Result result = ReturnWinner(playermove, cpumove);

            if (result == Result.VictoryCpu)
            {
                LbPtCpu.Text = (int.Parse(LbPtCpu.Text) + 1).ToString();
            }
            else if (result == Result.VictoryPlayer)
            {
                LbPtPl.Text = (int.Parse(LbPtPl.Text) + 1).ToString();
            }
        }

        private Result ReturnWinner(Move player, Move cpu)
        {
            if (player == GameTest.Move.Rock)
            {
                if (cpu == GameTest.Move.Paper)
                {
                    return Result.VictoryCpu;
                }
                else if (cpu == GameTest.Move.Scissor)
                {
                    return Result.VictoryPlayer;
                }
            }
            else if (player == GameTest.Move.Paper)
            {
                if (cpu == GameTest.Move.Scissor)
                {
                    return Result.VictoryCpu;
                }
                else if (cpu == GameTest.Move.Rock)
                {
                    return Result.VictoryPlayer;
                }
            }
            else
            {
                if (cpu == GameTest.Move.Rock)
                {
                    return Result.VictoryCpu;
                }
                else if (cpu == GameTest.Move.Paper)
                {
                    return Result.VictoryPlayer;
                }
            }

            return Result.Tie;
        }

        private Move ReturnPlayerMove(int choice)
        {
            return (Move)choice;
        }

        private Move ReturnCpuMove()
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);
            picCpu.Image = imgCpu[choice];
            return (Move)choice;
        }

        private void LbPtCpu_TextChanged(object sender, EventArgs e)
        {
            if(LbPtCpu.Text == "5")
            {
                this.Hide();
                FrmGameOver frm = new FrmGameOver();
                MessageBox.Show("The cop has defeated you.", "Game Over");
                frm.ShowDialog();
            }
        }

        private void LbPtPl_TextChanged(object sender, EventArgs e)
        {
            if (LbPtPl.Text == "5")
            {
                FrmPrincipal.stopSimpleSound();
                this.Hide();
                FrmGameWin frm = new FrmGameWin();
                MessageBox.Show("You won the battle and can be free!", "You Win!");
                frm.ShowDialog();
            }
        }
    }

    enum Move
    {
        Rock = 0,
        Paper = 1,
        Scissor = 2
    }

    enum Result
    {
        VictoryPlayer,
        VictoryCpu,
        Tie
    }
}