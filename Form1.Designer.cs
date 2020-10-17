namespace chpt9
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblYou = new System.Windows.Forms.Label();
            this.txtYourScore = new System.Windows.Forms.TextBox();
            this.txtComScore = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.picDiamond = new System.Windows.Forms.PictureBox();
            this.picClub = new System.Windows.Forms.PictureBox();
            this.picSpade = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Label();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.pnlComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.White;
            this.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayer.Controls.Add(this.lblPlayer);
            this.pnlPlayer.Controls.Add(this.picPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(121, 9);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(200, 142);
            this.pnlPlayer.TabIndex = 0;
            this.pnlPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(3, 69);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 29);
            this.lblPlayer.TabIndex = 12;
            this.lblPlayer.Tag = "";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer.Click += new System.EventHandler(this.LblPlayer_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(-1, -1);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(200, 67);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 12;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.PicPlayer_Click);
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(12, 9);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(33, 17);
            this.lblYou.TabIndex = 1;
            this.lblYou.Text = "You";
            this.lblYou.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtYourScore
            // 
            this.txtYourScore.BackColor = System.Drawing.Color.White;
            this.txtYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourScore.Location = new System.Drawing.Point(12, 25);
            this.txtYourScore.Multiline = true;
            this.txtYourScore.Name = "txtYourScore";
            this.txtYourScore.ReadOnly = true;
            this.txtYourScore.Size = new System.Drawing.Size(100, 126);
            this.txtYourScore.TabIndex = 2;
            this.txtYourScore.Text = "0";
            this.txtYourScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComScore
            // 
            this.txtComScore.BackColor = System.Drawing.Color.White;
            this.txtComScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComScore.Location = new System.Drawing.Point(12, 174);
            this.txtComScore.Multiline = true;
            this.txtComScore.Name = "txtComScore";
            this.txtComScore.ReadOnly = true;
            this.txtComScore.Size = new System.Drawing.Size(100, 125);
            this.txtComScore.TabIndex = 4;
            this.txtComScore.Text = "0";
            this.txtComScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComScore.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(12, 158);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(69, 17);
            this.lblCom.TabIndex = 3;
            this.lblCom.Text = "Computer";
            this.lblCom.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // pnlComputer
            // 
            this.pnlComputer.BackColor = System.Drawing.Color.White;
            this.pnlComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputer.Controls.Add(this.lblComputer);
            this.pnlComputer.Controls.Add(this.picComputer);
            this.pnlComputer.Location = new System.Drawing.Point(121, 157);
            this.pnlComputer.Name = "pnlComputer";
            this.pnlComputer.Size = new System.Drawing.Size(200, 142);
            this.pnlComputer.TabIndex = 1;
            this.pnlComputer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // picComputer
            // 
            this.picComputer.InitialImage = ((System.Drawing.Image)(resources.GetObject("picComputer.InitialImage")));
            this.picComputer.Location = new System.Drawing.Point(-1, -1);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(200, 67);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer.TabIndex = 13;
            this.picComputer.TabStop = false;
            // 
            // txtOver
            // 
            this.txtOver.BackColor = System.Drawing.Color.White;
            this.txtOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOver.ForeColor = System.Drawing.Color.Red;
            this.txtOver.Location = new System.Drawing.Point(327, 9);
            this.txtOver.Multiline = true;
            this.txtOver.Name = "txtOver";
            this.txtOver.ReadOnly = true;
            this.txtOver.Size = new System.Drawing.Size(173, 67);
            this.txtOver.TabIndex = 5;
            this.txtOver.Text = "Game Over";
            this.txtOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOver.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(327, 128);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(173, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(327, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // picHeart
            // 
            this.picHeart.Location = new System.Drawing.Point(327, 186);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(75, 50);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHeart.TabIndex = 8;
            this.picHeart.TabStop = false;
            this.picHeart.Visible = false;
            // 
            // picDiamond
            // 
            this.picDiamond.Location = new System.Drawing.Point(425, 186);
            this.picDiamond.Name = "picDiamond";
            this.picDiamond.Size = new System.Drawing.Size(75, 50);
            this.picDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDiamond.TabIndex = 9;
            this.picDiamond.TabStop = false;
            this.picDiamond.Visible = false;
            this.picDiamond.Click += new System.EventHandler(this.PicDiamond_Click);
            // 
            // picClub
            // 
            this.picClub.Location = new System.Drawing.Point(327, 249);
            this.picClub.Name = "picClub";
            this.picClub.Size = new System.Drawing.Size(75, 50);
            this.picClub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClub.TabIndex = 10;
            this.picClub.TabStop = false;
            this.picClub.Visible = false;
            // 
            // picSpade
            // 
            this.picSpade.Location = new System.Drawing.Point(425, 251);
            this.picSpade.Name = "picSpade";
            this.picSpade.Size = new System.Drawing.Size(75, 48);
            this.picSpade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSpade.TabIndex = 11;
            this.picSpade.TabStop = false;
            this.picSpade.Visible = false;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(3, 69);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 29);
            this.lblComputer.TabIndex = 13;
            this.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(327, 79);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(74, 13);
            this.debug.TabIndex = 12;
            this.debug.Text = "Cards Used: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 318);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.picSpade);
            this.Controls.Add(this.picClub);
            this.Controls.Add(this.picDiamond);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtOver);
            this.Controls.Add(this.pnlComputer);
            this.Controls.Add(this.txtComScore);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.txtYourScore);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.pnlPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Wars";
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.pnlComputer.ResumeLayout(false);
            this.pnlComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.TextBox txtYourScore;
        private System.Windows.Forms.TextBox txtComScore;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Panel pnlComputer;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picDiamond;
        private System.Windows.Forms.PictureBox picClub;
        private System.Windows.Forms.PictureBox picSpade;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label debug;
    }
}

