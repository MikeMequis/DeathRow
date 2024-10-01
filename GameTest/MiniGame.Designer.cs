namespace GameTest
{
    partial class FrmMiniGame
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
            this.LbPtCpu = new System.Windows.Forms.Label();
            this.LbPtPl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btPaper = new System.Windows.Forms.Button();
            this.btRock = new System.Windows.Forms.Button();
            this.picCpu = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPtCpu
            // 
            this.LbPtCpu.AutoSize = true;
            this.LbPtCpu.BackColor = System.Drawing.Color.Transparent;
            this.LbPtCpu.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtCpu.ForeColor = System.Drawing.Color.White;
            this.LbPtCpu.Location = new System.Drawing.Point(405, 51);
            this.LbPtCpu.Name = "LbPtCpu";
            this.LbPtCpu.Size = new System.Drawing.Size(21, 23);
            this.LbPtCpu.TabIndex = 8;
            this.LbPtCpu.Text = "0";
            this.LbPtCpu.TextChanged += new System.EventHandler(this.LbPtCpu_TextChanged);
            // 
            // LbPtPl
            // 
            this.LbPtPl.AutoSize = true;
            this.LbPtPl.BackColor = System.Drawing.Color.Transparent;
            this.LbPtPl.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtPl.ForeColor = System.Drawing.Color.White;
            this.LbPtPl.Location = new System.Drawing.Point(127, 51);
            this.LbPtPl.Name = "LbPtPl";
            this.LbPtPl.Size = new System.Drawing.Size(21, 23);
            this.LbPtPl.TabIndex = 7;
            this.LbPtPl.Text = "0";
            this.LbPtPl.TextChanged += new System.EventHandler(this.LbPtPl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(379, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "ENEMY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "PLAYER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GameTest.Properties.Resources.ScissorP;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(369, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 130);
            this.button1.TabIndex = 2;
            this.button1.Tag = "2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClickMove);
            // 
            // btPaper
            // 
            this.btPaper.BackColor = System.Drawing.Color.Transparent;
            this.btPaper.BackgroundImage = global::GameTest.Properties.Resources.PaperP;
            this.btPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPaper.Location = new System.Drawing.Point(210, 321);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(130, 130);
            this.btPaper.TabIndex = 1;
            this.btPaper.Tag = "1";
            this.btPaper.UseVisualStyleBackColor = false;
            this.btPaper.Click += new System.EventHandler(this.ClickMove);
            // 
            // btRock
            // 
            this.btRock.BackColor = System.Drawing.Color.Transparent;
            this.btRock.BackgroundImage = global::GameTest.Properties.Resources.RockP;
            this.btRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRock.Location = new System.Drawing.Point(49, 321);
            this.btRock.Name = "btRock";
            this.btRock.Size = new System.Drawing.Size(130, 130);
            this.btRock.TabIndex = 0;
            this.btRock.Tag = "0";
            this.btRock.UseVisualStyleBackColor = false;
            this.btRock.Click += new System.EventHandler(this.ClickMove);
            // 
            // picCpu
            // 
            this.picCpu.BackColor = System.Drawing.Color.Transparent;
            this.picCpu.Location = new System.Drawing.Point(305, 84);
            this.picCpu.Name = "picCpu";
            this.picCpu.Size = new System.Drawing.Size(210, 210);
            this.picCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpu.TabIndex = 13;
            this.picCpu.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(31, 84);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(210, 210);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 11;
            this.picPlayer.TabStop = false;
            // 
            // FrmMiniGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTest.Properties.Resources.MiniGame;
            this.ClientSize = new System.Drawing.Size(550, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPaper);
            this.Controls.Add(this.btRock);
            this.Controls.Add(this.LbPtCpu);
            this.Controls.Add(this.LbPtPl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCpu);
            this.Controls.Add(this.picPlayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMiniGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Death Row - Duel";
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPtCpu;
        private System.Windows.Forms.Label LbPtPl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCpu;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.Button btRock;
    }
}