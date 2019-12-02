using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class frmPlay : Form
    {

        private List<Circle> Snake = new List<Circle>();

        private Circle food = new Circle();


        public frmPlay()
        {
            InitializeComponent();

            //Set setting to default
            new Setting();

            //set fame speed and start timer
            //Set time will come back when project already // Timer is one event should have in our project. So i will add it in project for test
            GameTimer.Interval = 1000 / Setting.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            StartGame();

        }

        private void StartGame()
        {
            lblGameOver.Visible = false;
            //Set setting to default
            new Setting();

            // Create new player project 
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            //When lblScore have setup, we could use code 
            lblScore.Text = Setting.Score.ToString();
            GenerateFood();
        }

        //Play food random game
        private void GenerateFood()
        {
            int maxXpos = pnlPlay.Size.Width / Setting.Width;
            int maxYPos = pnlPlay.Size.Height / Setting.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXpos);
            food.Y = random.Next(0, maxYPos);


        }

        //private void UpdateScreen()
        //{
        //}

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Setting.GameOver)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }

            else

            {
                if (Input.KeyPressed(Keys.Right) && Setting.direction != Direction.Left)
                    Setting.direction = Direction.Right;
                if (Input.KeyPressed(Keys.Left) && Setting.direction != Direction.Right)
                    Setting.direction = Direction.Left;
                if (Input.KeyPressed(Keys.Up) && Setting.direction != Direction.Down)
                    Setting.direction = Direction.Up;
                if (Input.KeyPressed(Keys.Down) && Setting.direction != Direction.Up)
                    Setting.direction = Direction.Down;

                MovePlayer();

            }

            pnlPlay.Invalidate();
        }

        private void PnlPlay_Paint(object sender, PaintEventArgs e)
        {
            Graphics play = e.Graphics;

            if (Setting.GameOver != false)
            {


                //Draw Snake

                for (int i = 1; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                    {
                        snakeColour = Brushes.Red;// Draw đầu 
                    }
                    else
                    {
                        snakeColour = Brushes.Orange;// Draw thân
                    }

                    //Draw Sanke
                    play.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Setting.Width,
                        Snake[i].Y = Setting.Height * Setting.Width,
                        Setting.Height, Setting.Width));

                    //Draw Food
                    play.FillEllipse(Brushes.Black,
                        new Rectangle(food.X = Setting.Width,
                        food.Y = Setting.Height, Setting.Width, Setting.Height));
                }
            }
            else
            {
                string GameOver = "Game Over \nYour final score is:  " + Setting.Score + "\nPress Enter to try again";
                lblGameOver.Text = GameOver;
                lblGameOver.Visible = true;
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move Head
                if (i == 0)
                {
                    switch (Setting.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                }

                //Get maximum X and Y Pos

                int maxXPos = pnlPlay.Size.Width / Setting.Width;
                int maxYPos = pnlPlay.Size.Height / Setting.Height;

                //Detect collission with game borders
                if (Snake[i].X < 0 || Snake[i].Y < 0
                    || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                {
                    Die();
                }

                //Detect collission with body
                for (int j = 1; j < Snake.Count; j++)
                {
                    if (Snake[i].X == Snake[j].X &&
                        Snake[i].Y == Snake[j].Y)
                    {
                        Die();
                    }
                }

                //Detect collision with food piece
                if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                {
                    Eat();
                }
                else
                {
                    //Move Body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        private void FrmPlay_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void FrmPlay_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void Eat()
        {
            //Add Circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);


            //Update Score
            Setting.Score += Setting.Points;
            lblScore.Text = Setting.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Setting.GameOver = true;
        }


        private void FrmPlay_Load(object sender, EventArgs e)
        {

        }
    }


}

