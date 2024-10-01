namespace GameTest
{
    partial class FrmDialogue
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
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.lblPolice = new System.Windows.Forms.Label();
            this.lblPoliceName = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(12, 432);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(348, 47);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Text = "Uhh... I left because I need to go to the bathroom...";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // lblPolice
            // 
            this.lblPolice.AutoSize = true;
            this.lblPolice.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolice.Location = new System.Drawing.Point(111, 37);
            this.lblPolice.Name = "lblPolice";
            this.lblPolice.Size = new System.Drawing.Size(285, 14);
            this.lblPolice.TabIndex = 1;
            this.lblPolice.Text = "Where do you think you are going, partner?";
            // 
            // lblPoliceName
            // 
            this.lblPoliceName.AutoSize = true;
            this.lblPoliceName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPoliceName.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliceName.ForeColor = System.Drawing.Color.White;
            this.lblPoliceName.Location = new System.Drawing.Point(103, 18);
            this.lblPoliceName.Name = "lblPoliceName";
            this.lblPoliceName.Size = new System.Drawing.Size(159, 19);
            this.lblPoliceName.TabIndex = 2;
            this.lblPoliceName.Text = "Officer Robson:";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.BackColor = System.Drawing.Color.Black;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.ForeColor = System.Drawing.Color.White;
            this.lblYou.Location = new System.Drawing.Point(12, 416);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(35, 16);
            this.lblYou.TabIndex = 3;
            this.lblYou.Text = "You:";
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(12, 432);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(348, 47);
            this.btnAnswer2.TabIndex = 4;
            this.btnAnswer2.Text = "The toilet is clogged. I have to go.";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Visible = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(12, 432);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(348, 47);
            this.btnAnswer3.TabIndex = 5;
            this.btnAnswer3.Text = "Ok, I\'ll go to the point. Get out of my way NOW.";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Visible = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(12, 432);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(348, 47);
            this.btnAnswer4.TabIndex = 6;
            this.btnAnswer4.Text = "As you wish, cop.";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Visible = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // FrmDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTest.Properties.Resources.proxy_image__6_;
            this.ClientSize = new System.Drawing.Size(796, 491);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.lblPoliceName);
            this.Controls.Add(this.lblPolice);
            this.Controls.Add(this.btnAnswer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "An officer is blocking your path!";
            this.Load += new System.EventHandler(this.FrmDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Label lblPolice;
        private System.Windows.Forms.Label lblPoliceName;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
    }
}