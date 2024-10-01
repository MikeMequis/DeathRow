namespace GameTest
{
    partial class FrmTutorial
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblText4 = new System.Windows.Forms.Label();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.cboActions = new System.Windows.Forms.ComboBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.BackColor = System.Drawing.Color.Transparent;
            this.lblText1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText1.Location = new System.Drawing.Point(12, 9);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(456, 16);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Welcome to DEATH ROW. Here, we will explain how to play.";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(412, 425);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(69, 44);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Start Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.BackColor = System.Drawing.SystemColors.Control;
            this.lblText2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(11, 38);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(443, 40);
            this.lblText2.TabIndex = 2;
            this.lblText2.Text = "The game consists of mainly interacting with objects in your\r\nsurroundings after " +
    "selecting a location in your map.";
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.Location = new System.Drawing.Point(11, 91);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(431, 40);
            this.lblText3.TabIndex = 3;
            this.lblText3.Text = "In order to interact with them, first select the object in the\r\n\"Point of Interes" +
    "t\" box and choose the action.";
            // 
            // lblText4
            // 
            this.lblText4.AutoSize = true;
            this.lblText4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText4.Location = new System.Drawing.Point(12, 268);
            this.lblText4.Name = "lblText4";
            this.lblText4.Size = new System.Drawing.Size(466, 20);
            this.lblText4.TabIndex = 4;
            this.lblText4.Text = "After your choice, the box at the bottom will display the effect.";
            // 
            // cboItems
            // 
            this.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Items.AddRange(new object[] {
            "Bed",
            "Prison Bars",
            "Cards"});
            this.cboItems.Location = new System.Drawing.Point(173, 144);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(120, 84);
            this.cboItems.TabIndex = 30;
            this.cboItems.SelectedIndexChanged += new System.EventHandler(this.cboItems_SelectedIndexChanged);
            // 
            // cboActions
            // 
            this.cboActions.FormattingEnabled = true;
            this.cboActions.Location = new System.Drawing.Point(173, 234);
            this.cboActions.Name = "cboActions";
            this.cboActions.Size = new System.Drawing.Size(120, 21);
            this.cboActions.TabIndex = 31;
            this.cboActions.Visible = false;
            this.cboActions.SelectedIndexChanged += new System.EventHandler(this.cboActions_SelectedIndexChanged);
            // 
            // txtContext
            // 
            this.txtContext.Location = new System.Drawing.Point(12, 301);
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(469, 20);
            this.txtContext.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "And that\'s all. Be careful to pick your options or else you\'ll lose.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Good luck.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 38);
            this.label3.TabIndex = 35;
            this.label3.Text = "Your objective is to get out of prison by collecting key pieces\r\nscattered around" +
    " your cell before you\'re sent to execution.";
            // 
            // FrmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTest.Properties.Resources.Tutorial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContext);
            this.Controls.Add(this.cboActions);
            this.Controls.Add(this.cboItems);
            this.Controls.Add(this.lblText4);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to Play";
            this.Load += new System.EventHandler(this.FrmTutorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblText4;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.ComboBox cboActions;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}