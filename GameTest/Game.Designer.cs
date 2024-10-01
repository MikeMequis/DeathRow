
namespace GameTest
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPOI = new System.Windows.Forms.Label();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnWindow = new System.Windows.Forms.Button();
            this.cboActionPOI = new System.Windows.Forms.ComboBox();
            this.cboInv = new System.Windows.Forms.ComboBox();
            this.lblInv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.cboPOI = new System.Windows.Forms.ComboBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.lblWindow = new System.Windows.Forms.Label();
            this.lblBathroom = new System.Windows.Forms.Label();
            this.lblEntrance = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPOI
            // 
            this.lblPOI.AutoSize = true;
            this.lblPOI.BackColor = System.Drawing.Color.Transparent;
            this.lblPOI.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOI.ForeColor = System.Drawing.Color.Transparent;
            this.lblPOI.Location = new System.Drawing.Point(35, 9);
            this.lblPOI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPOI.Name = "lblPOI";
            this.lblPOI.Size = new System.Drawing.Size(124, 16);
            this.lblPOI.TabIndex = 1;
            this.lblPOI.Text = "Point of Interest";
            // 
            // btnEntrance
            // 
            this.btnEntrance.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrance.Location = new System.Drawing.Point(234, 62);
            this.btnEntrance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(71, 63);
            this.btnEntrance.TabIndex = 4;
            this.btnEntrance.Text = "Cell\r\nEntrance";
            this.btnEntrance.UseVisualStyleBackColor = true;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(234, 128);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(71, 63);
            this.btnRoom.TabIndex = 5;
            this.btnRoom.Text = "Bathroom";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Visible = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnWindow
            // 
            this.btnWindow.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindow.Location = new System.Drawing.Point(234, 202);
            this.btnWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Size = new System.Drawing.Size(71, 63);
            this.btnWindow.TabIndex = 6;
            this.btnWindow.Text = "Window";
            this.btnWindow.UseVisualStyleBackColor = true;
            this.btnWindow.Click += new System.EventHandler(this.btnWindow_Click);
            // 
            // cboActionPOI
            // 
            this.cboActionPOI.BackColor = System.Drawing.Color.Gray;
            this.cboActionPOI.ForeColor = System.Drawing.Color.White;
            this.cboActionPOI.FormattingEnabled = true;
            this.cboActionPOI.Location = new System.Drawing.Point(15, 255);
            this.cboActionPOI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboActionPOI.Name = "cboActionPOI";
            this.cboActionPOI.Size = new System.Drawing.Size(164, 21);
            this.cboActionPOI.TabIndex = 9;
            this.cboActionPOI.Tag = "";
            this.cboActionPOI.Visible = false;
            this.cboActionPOI.SelectedIndexChanged += new System.EventHandler(this.cboActionPOI_SelectedIndexChanged);
            // 
            // cboInv
            // 
            this.cboInv.BackColor = System.Drawing.Color.Black;
            this.cboInv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboInv.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInv.ForeColor = System.Drawing.Color.White;
            this.cboInv.FormattingEnabled = true;
            this.cboInv.Location = new System.Drawing.Point(353, 27);
            this.cboInv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboInv.Name = "cboInv";
            this.cboInv.Size = new System.Drawing.Size(164, 247);
            this.cboInv.TabIndex = 14;
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.BackColor = System.Drawing.Color.Transparent;
            this.lblInv.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.Transparent;
            this.lblInv.Location = new System.Drawing.Point(395, 9);
            this.lblInv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(78, 16);
            this.lblInv.TabIndex = 15;
            this.lblInv.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(250, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Map";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Red;
            this.lblCounter.Location = new System.Drawing.Point(11, 287);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 19);
            this.lblCounter.TabIndex = 18;
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPOI
            // 
            this.cboPOI.BackColor = System.Drawing.Color.Black;
            this.cboPOI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboPOI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPOI.ForeColor = System.Drawing.Color.White;
            this.cboPOI.FormattingEnabled = true;
            this.cboPOI.Location = new System.Drawing.Point(15, 28);
            this.cboPOI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboPOI.Name = "cboPOI";
            this.cboPOI.Size = new System.Drawing.Size(164, 221);
            this.cboPOI.TabIndex = 19;
            this.cboPOI.SelectedIndexChanged += new System.EventHandler(this.cboPOI_SelectedIndexChanged);
            // 
            // txtContext
            // 
            this.txtContext.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContext.ForeColor = System.Drawing.Color.White;
            this.txtContext.Location = new System.Drawing.Point(11, 309);
            this.txtContext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(506, 38);
            this.txtContext.TabIndex = 20;
            this.txtContext.TextChanged += new System.EventHandler(this.txtContext_TextChanged);
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.BackColor = System.Drawing.Color.Black;
            this.lblWindow.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindow.ForeColor = System.Drawing.Color.White;
            this.lblWindow.Location = new System.Drawing.Point(245, 220);
            this.lblWindow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(51, 28);
            this.lblWindow.TabIndex = 21;
            this.lblWindow.Text = "     웃\r\nWindow";
            this.lblWindow.Visible = false;
            // 
            // lblBathroom
            // 
            this.lblBathroom.AutoSize = true;
            this.lblBathroom.BackColor = System.Drawing.Color.Black;
            this.lblBathroom.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBathroom.ForeColor = System.Drawing.Color.White;
            this.lblBathroom.Location = new System.Drawing.Point(240, 146);
            this.lblBathroom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBathroom.Name = "lblBathroom";
            this.lblBathroom.Size = new System.Drawing.Size(59, 28);
            this.lblBathroom.TabIndex = 22;
            this.lblBathroom.Text = "       웃\r\nBathroom";
            this.lblBathroom.Visible = false;
            // 
            // lblEntrance
            // 
            this.lblEntrance.AutoSize = true;
            this.lblEntrance.BackColor = System.Drawing.Color.Black;
            this.lblEntrance.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrance.ForeColor = System.Drawing.Color.White;
            this.lblEntrance.Location = new System.Drawing.Point(243, 73);
            this.lblEntrance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrance.Name = "lblEntrance";
            this.lblEntrance.Size = new System.Drawing.Size(52, 42);
            this.lblEntrance.TabIndex = 23;
            this.lblEntrance.Text = "      웃\r\n    Cell\r\nEntrance";
            this.lblEntrance.Visible = false;
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(353, 280);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(164, 23);
            this.btnLeave.TabIndex = 24;
            this.btnLeave.Text = "Craft Cell Key";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Visible = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTest.Properties.Resources.Game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 359);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lblEntrance);
            this.Controls.Add(this.lblBathroom);
            this.Controls.Add(this.lblWindow);
            this.Controls.Add(this.txtContext);
            this.Controls.Add(this.cboPOI);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.cboInv);
            this.Controls.Add(this.cboActionPOI);
            this.Controls.Add(this.btnWindow);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.lblPOI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Death Row";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Shown += new System.EventHandler(this.btnWindow_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPOI;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnWindow;
        private System.Windows.Forms.ComboBox cboActionPOI;
        private System.Windows.Forms.ComboBox cboInv;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ComboBox cboPOI;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.Label lblBathroom;
        private System.Windows.Forms.Label lblEntrance;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Button btnLeave;
    }
}

