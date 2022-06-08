namespace Ping_Pong
{
    public partial class frmPong : Form
    {
        bool goUp;
        bool goDown;
        int pPaddleSpeed;
        int cPaddleSpeed;
        int pScore;
        int cScore;
        int timeytick;
        Random random;
        BallXY ballXy;

        struct BallXY 
        {
            public int x;
            public int y;
        }
        public frmPong()
        {
            InitializeComponent();
            cPaddleSpeed = 5;
            pPaddleSpeed = 5;
            pScore = 0;
            cScore = 0;
            random = new Random();
            ballXy.x = 5;
            ballXy.y = 5;
            timeytick = 1;
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void frmPong_Load(object sender, EventArgs e)
        {
            this.Text = "Player Score " + pScore + "        |        Computer Score " + cScore;
            picPlayer.Left = 0;
            picPlayer.Top = (ClientSize.Height / 2) - picPlayer.Height / 2;
            picComp.Left = (ClientSize.Width) - picComp.Width / 2;
            picComp.Top = (ClientSize.Height / 2) - picComp.Height / 2;
            picWall.Top = 0;
            picWall.Left = (ClientSize.Width / 2) - picWall.Width / 2;
            picWall.Height = ClientSize.Height;
            picBall.Left = (ClientSize.Width / 2) + 40;
            picBall.Top = (ClientSize.Height / 2) + 40;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void frmPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                picPlayer.BackColor = Color.Yellow;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                picPlayer.BackColor = Color.Blue;
            }
        }

        private void frmPong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
                picPlayer.BackColor = Color.Lime;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                picPlayer.BackColor = Color.Lime;

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Player Score " + pScore + "        |        Computer Score " + cScore;
            picBall.Left -= ballXy.x;
            picBall.Top -= ballXy.y;
            picComp.Top -= cPaddleSpeed;
            
            
            if (picComp.Top < 0 || picComp.Top > ClientSize.Height - picComp.Height)
            {
                cPaddleSpeed = -cPaddleSpeed;
            } 
            if (picBall.Top < 0 || picBall.Top > ClientSize.Height - picBall.Height)
            {
                ballXy.y = -ballXy.y;
            }
            if (picBall.Left < 0)
            {
                picBall.Left = ClientSize.Width / 2 - 200;
                picBall.Top = random.Next(20, ClientSize.Height - 20);
                cScore += 1;
            }
            if (picBall.Left > ClientSize.Width - picBall.Width)
            {
                picBall.Left = ClientSize.Width / 2 + 200;
                picBall.Top = random.Next(20, ClientSize.Height - 20);
                pScore += 1;
            }
            if (picBall.Bounds.IntersectsWith(picPlayer.Bounds) || picBall.Bounds.IntersectsWith(picComp.Bounds))
            {
                ballXy.x =-ballXy.x;
                if (picBall.Bounds.IntersectsWith(picPlayer.Bounds))
                {
                    picBall.BackColor = Color.LimeGreen;
                }
                if (picBall.Bounds.IntersectsWith(picComp.Bounds))
                {
                    picBall.BackColor = Color.IndianRed;
                }
            }
            
            if (picPlayer.Top > 0 && goUp)
            {
                picPlayer.Top -= pPaddleSpeed;
            }
            if (picPlayer.Top < ClientSize.Height - picPlayer.Height && goDown)
            {
                picPlayer.Top += pPaddleSpeed;
            }
            if (pScore >= 10)
            {
                timer1.Stop();
                DialogResult = MessageBox.Show("YOU WIN!", " Play again?", MessageBoxButtons.YesNo);

            }
            if (cScore >= 10)
            {
                timer1.Stop();
                DialogResult  = MessageBox.Show("Computer Wins!", " Play again?" , MessageBoxButtons.YesNo);
            }
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Ok");
                    Application.Restart();

                    break;
                case DialogResult.No:
                    Application.Exit();
                    break;
            }
            timeytick = timeytick + 1 / 2;
            ballXy.y = ballXy.y + timeytick;
            ballXy.x = ballXy.x + timeytick;
        }
        
    }
}