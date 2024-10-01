namespace GameTest
{
    partial class FrmGameWin
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picRank = new System.Windows.Forms.PictureBox();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.White;
            this.lblText.ForeColor = System.Drawing.Color.Navy;
            this.lblText.Location = new System.Drawing.Point(12, 256);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(225, 65);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "DEATH ROW by:\r\nMarcelo Mendonça Medeiros, RM 082220035\r\nMatheus Pedroza da Cunha," +
    " RM 081220002\r\nEC 2\r\nTeacher Israel Florentino dos Santos";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.BackColor = System.Drawing.Color.Transparent;
            this.lblTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.ForeColor = System.Drawing.Color.Transparent;
            this.lblTurns.Location = new System.Drawing.Point(110, 216);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(43, 13);
            this.lblTurns.TabIndex = 3;
            this.lblTurns.Text = "Turns:";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.BackColor = System.Drawing.Color.Transparent;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.Color.White;
            this.lblText2.Location = new System.Drawing.Point(151, 5);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(97, 31);
            this.lblText2.TabIndex = 4;
            this.lblText2.Text = "Your Rank:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GameTest.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(254, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picRank
            // 
            this.picRank.BackColor = System.Drawing.Color.Transparent;
            this.picRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRank.Location = new System.Drawing.Point(113, 39);
            this.picRank.Name = "picRank";
            this.picRank.Size = new System.Drawing.Size(170, 174);
            this.picRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRank.TabIndex = 0;
            this.picRank.TabStop = false;
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFree.ForeColor = System.Drawing.Color.Black;
            this.btnFree.Location = new System.Drawing.Point(343, 12);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(53, 35);
            this.btnFree.TabIndex = 5;
            this.btnFree.Text = "Go Free";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(12, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(53, 35);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // FrmGameWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTest.Properties.Resources.Win;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 346);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picRank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGameWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWin";
            this.Load += new System.EventHandler(this.GameWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRank;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnRestart;
    }
}