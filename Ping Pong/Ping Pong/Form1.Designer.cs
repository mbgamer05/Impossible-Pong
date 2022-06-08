namespace Ping_Pong
{
    partial class frmPong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPong));
            this.picComp = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picComp
            // 
            this.picComp.BackColor = System.Drawing.Color.Red;
            this.picComp.Location = new System.Drawing.Point(925, 209);
            this.picComp.Name = "picComp";
            this.picComp.Size = new System.Drawing.Size(40, 100);
            this.picComp.TabIndex = 0;
            this.picComp.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Lime;
            this.picPlayer.Location = new System.Drawing.Point(12, 183);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(40, 126);
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // picWall
            // 
            this.picWall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picWall.Location = new System.Drawing.Point(497, 12);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(22, 519);
            this.picWall.TabIndex = 2;
            this.picWall.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(351, 194);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(40, 40);
            this.picBall.TabIndex = 3;
            this.picBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(977, 543);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picComp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picComp;
        private PictureBox picPlayer;
        private PictureBox picWall;
        private PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
    }
}