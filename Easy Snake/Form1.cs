using System;
using System.Drawing;
using System.Windows.Forms;

namespace Easy_Snake
{
    public partial class ESForm1 : Form
    {
        // snake movement direction (DEFAULT = 2 [->])
        int MovDir = 2;
        
        // keep snake segments in separated arrays
        int[] spX = new int[599];
        int[] spY = new int[599];

        // food position
        int FoodX, FoodY;
        
        // PowerUp position & type
        int PwrX, PwrY, PwrT;

        // PowerUp color
        Color cPwr = Color.FromArgb(60, 120, 140);

        // snake length (DEFAULT = 3)
        int SnakeLength = 3;

        // game field sizing
        int fStep = 25;
        int fWidth = 30;
        int fHeight = 20;

        // score and lives
        int Score;
        int CoinFlip = -1;
        bool AllowTurn = true;

        // game colors
        Color clSnakeDefault = Color.FromArgb(60, 140, 120);
        Color clFieldDefault = Color.FromArgb(215, 255, 235);
        Color clCellsDefault = Color.FromArgb(250, 255, 255);
        Color clFoodDefault = Color.FromArgb(54, 225, 138);

        public ESForm1()
        {
            InitializeComponent();
        }

        // draw game field
        public void DrawField()
        {
            Graphics gField = CreateGraphics();
            Pen pField = new Pen(clCellsDefault, 1);

            for (int i = 0; i < fWidth * fStep; i = i + fStep)
            {
                Rectangle Field = new Rectangle(i, 0, i, 500);
                gField.DrawRectangle(pField, Field);
            }
            for (int i = 0; i < fHeight * fStep; i = i + fStep)
            {
                Rectangle Field = new Rectangle(0, i, 750, i);
                gField.DrawRectangle(pField, Field);
            }
            Pen pBorder = new Pen(clSnakeDefault, 1);
            Rectangle fBorder = new Rectangle(0, 501, 750, 39);
            gField.DrawRectangle(pBorder, fBorder);
        }

        // draw the snake
        public void DrawSnake()
        {
            Graphics gSnake = CreateGraphics();
            Brush bSnake = new SolidBrush(clSnakeDefault);

            for (int i = 0; i < SnakeLength; i++)
            {
                Rectangle rSnake = new Rectangle(
                    spX[i]*fStep + 1,
                    spY[i]*fStep + 1,
                    fStep - 2,
                    fStep - 2
                );
                gSnake.FillRectangle(bSnake, rSnake);
            }
        }

        // delete the snake
        public void DelSnake()
        {
            Graphics gDel = CreateGraphics();
            Brush bDel = new SolidBrush(clFieldDefault);
            Rectangle rDel = new Rectangle(
                spX[SnakeLength] * fStep + 1,
                spY[SnakeLength] * fStep + 1,
                fStep - 2,
                fStep - 2
            );
            gDel.FillRectangle(bDel, rDel);
        }

        // draw food
        public void DrawFood()
        {
            Random fRnd = new Random();
            bool B;

            // AVOID CREATING FOOD IN OCCUPIED CELLS
            do
            {
                FoodX = fRnd.Next(fWidth - 1);
                FoodY = fRnd.Next(fHeight - 1);
                B = false;

                for (int i = 0; i <= SnakeLength + 1; i++)
                {
                    if (((spX[i] == FoodX) && (spY[i] == FoodY))
                        || ((FoodX == PwrX) && (FoodY == PwrY)))
                    {
                        B = true;
                    }
                }
            }
            while (B == true);
            
            Graphics gFood = CreateGraphics();
            Brush bFood = new SolidBrush(clFoodDefault);
            Rectangle rFood = new Rectangle(
                FoodX * fStep + 1,
                FoodY * fStep + 1,
                fStep - 2,
                fStep - 2
            );
            gFood.FillRectangle(bFood, rFood);
        }

        // create a PowerUp
        public void PowerUp()
        {
            Random fRnd = new Random();
            bool EmptyCell;

            // set random PowerUp timer interval
            puTimer.Interval = fRnd.Next(12000) + 700;

            PwrT = fRnd.Next(4);

            // set PowerUp color
            // plus 15 score points
            if (PwrT == 3) cPwr = Color.FromArgb(170, 255, 0);
            // slow down
            if (PwrT == 2) cPwr = Color.FromArgb(30, 144, 255);
            // speed up
            if (PwrT == 1) cPwr = Color.FromArgb(237, 118, 14);
            // plus ten segments
            if (PwrT == 0) cPwr = Color.FromArgb(60, 60, 60);

            // AVOID CREATING POWER UPS IN OCCUPIED CELLS
            do
            {
                PwrX = fRnd.Next(fWidth - 1);
                PwrY = fRnd.Next(fHeight - 1);
                EmptyCell = true;

                for (int i = 0; i <= SnakeLength + 1; i++)
                {
                    if (((spX[i] == PwrX) && (spY[i] == PwrY))
                        || ((FoodX == PwrX) && (FoodY == PwrY)))
                    {
                        EmptyCell = false;
                    }
                }
            }
            while (EmptyCell == false);
            puTimer.Enabled = true;
        }

        // draw PowerUp on timer
        private void puTimer_Tick(object sender, EventArgs e)
        {
            Graphics gFood = CreateGraphics();
            Brush bFood = new SolidBrush(cPwr);
            Rectangle rFood = new Rectangle(
                PwrX * fStep + 1,
                PwrY * fStep + 1,
                fStep - 2,
                fStep - 2
            );
            gFood.FillRectangle(bFood, rFood);
            
            ShowPUTimer.Enabled = true;
        }

        // delete PowerUp on timer
        private void ShowPUTimer_Tick(object sender, EventArgs e)
        {
            Graphics gFood = CreateGraphics();
            Brush bFood = new SolidBrush(Color.FromArgb(215, 255, 235));
            Rectangle rFood = new Rectangle(
                PwrX * fStep + 1,
                PwrY * fStep + 1,
                fStep - 2,
                fStep - 2
            );
            gFood.FillRectangle(bFood, rFood);

            ShowPUTimer.Enabled = false;
            PowerUp();
        }

        // game controls
        private void ESForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P)
            {
                if (CoinFlip == -1)
                {
                    tTick.Enabled = false;
                    puTimer.Enabled = false;

                    lGamePaused.Text = "Game is paused";
                    lGamePaused.Visible = true;
                }
                else
                {
                    tTick.Enabled = true;
                    if (Form4Options.UsePowerUps == true) puTimer.Enabled = true;

                    lGamePaused.Visible = false;
                }
                CoinFlip = CoinFlip * (-1);
            }
            if (e.KeyData == Keys.Escape) Restart();
            if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;

            if (((e.KeyData == Keys.Left || e.KeyData == Keys.A)
                && MovDir != 2) && AllowTurn == true)
            {
                MovDir = 0;
                AllowTurn = false;
            }
            if (((e.KeyData == Keys.Up || e.KeyData == Keys.W)
                && MovDir != 3) && AllowTurn == true)
            {
                AllowTurn = false;
                MovDir = 1;
            }
            if (((e.KeyData == Keys.Right || e.KeyData == Keys.D)
                && MovDir != 0) && AllowTurn == true)
            {
                AllowTurn = false;
                MovDir = 2;
            }
            if (((e.KeyData == Keys.Down || e.KeyData == Keys.S)
                && MovDir != 1) && AllowTurn == true)
            {
                AllowTurn = false;
                MovDir = 3;
            }
        }

        // handle "About"
        private void bAbout_Click(object sender, EventArgs e)
        {
            Form2About f2 = new Form2About();
            f2.ShowDialog();
        }

        // handle "Exit"
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // handle "Start"
        private void bStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        // handle "Instructions"
        private void bInstruct_Click(object sender, EventArgs e)
        {
            Form3Instr f3 = new Form3Instr();
            f3.ShowDialog();
        }

        // handle "Options"
        private void bOptions_Click(object sender, EventArgs e)
        {
            Form4Options f4 = new Form4Options();
            f4.ShowDialog();
        }

        // handle "Game over" label click
        private void lGameOver1_Click(object sender, EventArgs e)
        {
            Invalidate();
            Start();
        }

        // STARTING SETUP
        public void Start()
        {
            bStart.Visible = false;
            bOptions.Visible = false;
            bControls.Visible = false; 
            bAbout.Visible = false;  
            bExit.Visible = false;   

            tTick.Interval = Form4Options.DiffToTimer; 
            puTimer.Enabled = false;

            lScore1.Visible = true;
            lScore2.Visible = true;

            lGameOver1.Visible = false;
            lGamePaused.Visible = false;
            lPressEsc.Visible = false;

            spX[0] = 0;
            spY[0] = 0;
            spX[1] = -1;
            spY[1] = 0;
            spX[2] = -2;
            spY[2] = 0;

            // default snake movement direction
            MovDir = 2;

            SnakeLength = 3;
            Score = 0;                                          
            lScore2.Text = "0";                                 
            CoinFlip = -1;                                    

            // Draw field
            DrawField();

            // draw food
            DrawFood();     

            // start PowerUps if enabled
            if (Form4Options.UsePowerUps == true) PowerUp();

            // start tick timer
            tTick.Enabled = true;
        }

        // restart
        private void Restart()
        {
            lGameOver1.Visible = false;

            tTick.Enabled = false;
            tTick.Interval = Form4Options.DiffToTimer;
            puTimer.Enabled = false;
            this.Invalidate();

            bStart.Visible = true;
            bOptions.Visible = true;
            bControls.Visible = true;
            bAbout.Visible = true;
            bExit.Visible = true;
            lGamePaused.Visible = false;
            lPressEsc.Visible = false;

            lScore1.Visible = false;
            lScore2.Visible = false;
            CoinFlip = -1;
        }

        // show the Game Over sign
        public void GameOver()
        {
            tTick.Enabled = false;
            puTimer.Enabled = false;

            lGameOver1.Visible = true;
            lPressEsc.Visible = true;    
        }

        // snake actions on timer tick
        public void sTick()
        {
            AllowTurn = true;
            for (int i = SnakeLength; i > 0; --i)
            {
                spX[i] = spX[i - 1];
                spY[i] = spY[i - 1];                
            }

            // movement direction
            // left
            if (MovDir == 0) spX[0] -= 1;
            // up
            if (MovDir == 1) spY[0] -= 1;
            // right
            if (MovDir == 2) spX[0] += 1;
            // down
            if (MovDir == 3) spY[0] += 1;

            // food collecting
            if ((spX[0] == FoodX) && (spY[0] == FoodY))
            {
                SnakeLength++;
                Score++;
                lScore2.Text = Convert.ToString(Score);
                DrawFood();
            }

            // on picking up PowerUp
            if ((spX[0] == PwrX) && (spY[0] == PwrY))
            {
                if (PwrT == 0)
                {
                    SnakeLength += 10;
                    Score += 10;
                }
                if (PwrT == 1)
                {   
                    if (tTick.Interval > 30) tTick.Interval-=30;
                    Score++;
                }
                if (PwrT == 2)
                {
                    tTick.Interval += 30;
                    Score++;
                }
                if (PwrT == 3)
                {
                    Score += 15;
                }

                lScore2.Text = Convert.ToString(Score);
                PowerUp();
            }
            
            // snake array check
            for (int i = 1; i < SnakeLength; i++)
            {
                if ((spX[0] == spX[i]) && (spY[0] == spY[i]))
                {
                    GameOver();
                }
            }

            // field border check
            if (spX[0] > fWidth - 1 || spX[0] < 0 || spY[0] > fHeight - 1 || spY[0] < 0)
            {
                GameOver();
            }
        }

        // timer tick
        private void tTick_Tick(object sender, EventArgs e)
        {
            // mew coordinates for the snake
            sTick();

            // delete old segments
            DelSnake();

            // draw snake in a new position
            DrawSnake();

            if (Form4Options.ShowDevInfo)
            {
                l1.Visible = true;
                l2.Visible = true;
                l1.Text = "X[0]: " + Convert.ToString(spX[0]) + "  Y[0]: "
                    + Convert.ToString(spY[0]) + " S: " + Convert.ToString(tTick.Interval);
                l2.Text = "L: " + Convert.ToString(SnakeLength) + "  D: "
                    + Convert.ToString(MovDir) + " F[X]: " + Convert.ToString(FoodX)
                    + " F[Y]: " + Convert.ToString(FoodY);
            }
            if (Form4Options.ShowDevInfo == false)
            {
                l1.Visible = false;
                l2.Visible = false;
            }
        }
    }
}
