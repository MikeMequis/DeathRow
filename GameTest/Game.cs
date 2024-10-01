using System;
using System.Windows.Forms;
using System.Media;

namespace GameTest
{
    public partial class FrmPrincipal : Form
    {
        private POI[] Object = new POI[4];
        private Inventory[] Items = new Inventory [2];
        private int Timer = 80;
        public static int Turns = 0;
        FrmGameOver frmGameOver = new FrmGameOver();
        public static SoundPlayer simpleSound;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            playSimpleSound(Properties.Resources.Price);
            Time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblCounter.Text = Timer--.ToString() + " seconds until execution.";

            if (Timer == -1)
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Break);
                MessageBox.Show("Your time is up. Time to send you to the noose.");
                stopSimpleSound();
                PlayerLose();
            }
        }

        private void btnRoom_Click(Object sender, EventArgs e)
        {
            ClearData();

            Object[0] = new POI("Shower");
            FillPOI(Object[0]);
            Object[0].addActions(
                new Action("Take a bath", "YOU DIED", false),
                new Action("Look at drain", "You noticed that there is the key part Head. " +
                "Fortunately, you took out the drain plug and easily got the part.", true));

            Object[1] = new POI("Toilet Seat");
            FillPOI(Object[1]);
            Object[1].addActions(
                new Action("Open its lid", "You took its lid out and found the " +
                "key part Shoulder. You should clean it before using it...", true),
                new Action("Use it", "YOU DIED", false));

            Object[2] = new POI("Garbage Bin");
            FillPOI(Object[2]);
            Object[2].addActions(
                new Action("Examine", "A rusty old garbage bin.", false),
                new Action("Scavenge", "You threw everything at the ground and tried your best to " +
                "look for something. You found nothing...", false));

            Object[3] = new POI("Sink");
            FillPOI(Object[3]);
            Object[3].addActions(
                new Action("Turn its valve", "There was nothing but dust " +
                "coming from its head.", false),
                new Action("Break", "YOU DIED", false));

            Items[0] = new Inventory("Head");
            Items[1] = new Inventory("Shoulder");

            lblBathroom.Visible = true;
            lblWindow.Visible = false;
            lblEntrance.Visible = false;

            btnRoom.Visible = false;
            btnEntrance.Visible = true;
            btnWindow.Visible = true;

            cboPOI.Text = "";

            txtContext.Text = "Filthy and smelly. You notice that its walls are " +
                "filled with cracks and bugs.";
        }

        private void btnEntrance_Click(Object sender, EventArgs e)
        {
            ClearData();

            Object[0] = new POI("Bed");
            FillPOI(Object[0]);
            Object[0].addActions(
                new Action("Examine", "The sheets' fabrics are completely frayed, " +
                "but looks comfortable enough.", false), 
                new Action("Sleep", "YOU DIED", false),
                new Action("Look under", "You found the Rod part near the spiderweb below your bed. " +
            "You didn't notice the big spider until now.", true));

            Object[1] = new POI("Cell Bars");
            FillPOI(Object[1]);
            Object[1].addActions(
                new Action("Examine the bars", "Ordinary black iron prison bars from your cell.", false),
                new Action("Look around the cell block", "From the bars, you can see nothing but " +
                "the other dark cells around your cell block.", false));

            Object[2] = new POI("Cards");
            FillPOI(Object[2]);
            Object[2].addActions(
                new Action("Examine cards", "Just your classic 52-card Poker pack.", false),
                new Action("Shuffle", "YOU DIED", false));

            Items[0] = new Inventory("Rod");

            lblEntrance.Visible = true;
            lblBathroom.Visible = false;
            lblWindow.Visible = false;
            btnRoom.Visible = true;
            btnEntrance.Visible = false;
            btnWindow.Visible = false;
            cboPOI.Text = "";
            txtContext.Text = "You have to get the cell door's key quickly. " +
                "There's no time to waste!";
        }

        private void btnWindow_Click(Object sender, EventArgs e)
        {
            ClearData();

            Object[0] = new POI("Window Bars");
            FillPOI(Object[0]);
            Object[0].addActions(
            new Action("Examine", "Sturdy bars that interferes your view. " +
            "From a distance, you can see that there is something " +
            "hanging but can't tell exactly what is it.", false),
            new Action("Cut Bars", "YOU DIED", false),
            new Action("Extend your hand", "You reach your hand to get the mysterious item " +
            "hanging near your window. You grabbed it and noticed it is the key part Wards!", true));

            Items[0] = new Inventory("Wards");

            lblWindow.Visible = true;
            lblBathroom.Visible = false;
            lblEntrance.Visible = false;
            btnRoom.Visible = true;
            btnEntrance.Visible = false;
            btnWindow.Visible = false;
            cboPOI.Text = "";
            txtContext.Text = "You can feel the breeze chilling up your spine.";
        }

        private void ClearData()
        {
            cboPOI.Items.Clear();
            cboActionPOI.Items.Clear();
            txtContext.Clear();
        }

        private void FillPOI(POI Objects)
        {
            cboActionPOI.Visible = false;

            cboPOI.Items.Add(Objects.getName());
        }

        private void FillData(POI Objects)
        {
            foreach (Action action in Objects.getActions())
            {
                cboActionPOI.Items.Add(action.getActions());
            }
        }

        private void cboPOI_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (cboPOI.SelectedIndex >= 0)
            {
                cboActionPOI.Visible = true;

                cboActionPOI.Text = "";

                cboActionPOI.Items.Clear();

                FillData(Object[cboPOI.SelectedIndex]);
            }
        }

        private void cboActionPOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActionPOI.Visible = false;

            foreach (Action action in Object[cboPOI.SelectedIndex].getActions())
            {
                if (action.getActions() == (string)cboActionPOI.SelectedItem)
                {
                    txtContext.Text = action.getContext();

                    if (action.getYes())
                    {
                        InsertVerify(Items[cboPOI.SelectedIndex].getName());
                    }
                    break;
                }

            }

            if ((string)cboActionPOI.SelectedItem == "Sleep")
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Sleep);
                MessageBox.Show("You spent the rest of your precious time sleeping " +
                    "until a guard woke you up and sent you to the noose.");
                stopSimpleSound();
                PlayerLose();
            }
            else if ((string)cboActionPOI.SelectedItem == "Break")
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Break);
                MessageBox.Show("You broke the sink (along with both your hands) and looked at its hole." +
                    " There was nothing there. You couldn't do anything but scream" +
                    " for help until a guard came and sent you to the noose in order to" +
                    " keep you quiet.");
                stopSimpleSound();
                PlayerLose();
            }
            else if ((string)cboActionPOI.SelectedItem == "Shuffle")
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Cards);
                MessageBox.Show("You shuffled your cards in order to relieve your stress. " +
                    "However, you've ended up having paper cuts over your dirty hands. " +
                    "You can't do anything with your hands in this state.");
                stopSimpleSound();
                PlayerLose();
            }
            else if ((string)cboActionPOI.SelectedItem == "Take a bath")
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Bath);
                MessageBox.Show("You took a bath to feel more calm, but you've spent too" +
                    " much time because you've kept your head busy strategizing a way" +
                    " out of here. A guard interrupted your bath and sent you to the noose.");
                stopSimpleSound();
                PlayerLose();
            }
            else if ((string)cboActionPOI.SelectedItem == "Use it")
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Shock);
                MessageBox.Show("You pressed its button. However, its water started rising more and more..." +
                    " and it didn't stop rising. You tried to get away from the water as much as you " +
                    "could because the water reached the loose electrical wires at the other side of " +
                    "the bathroom. You are stuck.");
                stopSimpleSound();
                PlayerLose();
            }
            else if ((string)cboActionPOI.SelectedItem == "Cut Bars")
            {
                stopSimpleSound();
                playSimpleSound(Properties.Resources.Window);
                MessageBox.Show("You used a hand file that you found near the bars. Unfortunately, " +
                    "when cutting one of the bars, you noticed that it was heavier than you expected " +
                    "and you fell forward and dropped a really high altitude. You didn't survive.");
                PlayerLose();
            }
        }

        private void InsertVerify(string Text)
        {
            bool FlagExit = false;

            foreach (var item in cboInv.Items)
            {
                if ((string)item == Items[cboPOI.SelectedIndex].getName())
                {
                    FlagExit = true;
                    break;
                }
            }

            if (!FlagExit) cboInv.Items.Add(Items[cboPOI.SelectedIndex].getName());
            Craft();
        }

        private void txtContext_TextChanged(object sender, EventArgs e)
        {
            if(txtContext.Text != "")
            {
                Turns++;
            }
        }
                
        public void Craft()
        {
            if(cboInv.Items.Count == 4)
            {
                btnLeave.Visible = true;
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            stopSimpleSound();
            Time.Stop();
            this.Hide();
            playSimpleSound(Properties.Resources.Key);
            MessageBox.Show("You crafted the key and got out of your cell. But wait! What's that?");
            stopSimpleSound();
            FrmDialogue frm = new FrmDialogue();
            frm.ShowDialog();
        }

        public void PlayerLose()
        {
            Time.Stop();
            this.Hide();
            frmGameOver.ShowDialog();
        }

        public static void playSimpleSound(System.IO.Stream Sound)
        {
            simpleSound = new SoundPlayer(Sound);
            simpleSound.Play();
        }

        public static void stopSimpleSound()
        {
            simpleSound.Stop();
        }
    }
}