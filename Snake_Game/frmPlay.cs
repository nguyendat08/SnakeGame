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
            //GameTimer.Interval = 1000 / Setting.Speed;
            //GameTimer.Tick += UpdateScreen();
            //GameTimer.Start();
            UpdateScreen();
            StartGame();

        }

        private void UpdateScreen()
        {
            throw new NotImplementedException();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if(Setting.GameOver == true)
           {
              //Check if Enter is pressed
                if(Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }

            else

            {
                if (Input.KeyPressed(Keys.Right) && Setting.direction != Direction.Left)
                    Setting.direction = Direction.Right;
                if (Input.KeyPressed(Keys.Right) && Setting.direction != Direction.Left)
                    Setting.direction = Direction.Right;
                if (Input.KeyPressed(Keys.Right) && Setting.direction != Direction.Left)
                    Setting.direction = Direction.Right;
                if (Input.KeyPressed(Keys.Right) && Setting.direction != Direction.Left)
                    Setting.direction = Direction.Right;

                MovePlayer();

            }

            pnlPlay.Invalidate();
        }

        private void MovePlayer()
        {
            throw new NotImplementedException();
        }

        private void StartGame()
        {
            //Set setting to default
            new Setting();

            // Create new player project 
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);
            
            //When lblScore have setup, we could use code 
            //lblScore.Text = Setting.Score.ToString();
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

        private void PnlPlay_Paint(object sender, PaintEventArgs e)
        {
            Graphics play = e.Graphics;

            if(Setting.GameOver != false)
            {
                Brush snakeColour;

                //Draw Snake

            for(int i = 1; i < Snake.Count; i++ )
                {
                    if(i == 0)
                    {
                        snakeColour = Brushes.Red;// Draw đầu 
                    }
                    else
                    {
                        snakeColour = Brushes.Orange;
                    }

                    //Draw Sanke
                    play.FillEllipse(snakeColour,
                        new Rectangle(food.X = Setting.Width,
                        food.Y = Setting.Height, Setting.Width, Setting.Height));

                    //Draw Food
                    play.FillEllipse(Brushes.Black,
                        new Rectangle(food.X = Setting.Width,
                        food.Y = Setting.Height, Setting.Width, Setting.Height));
                }
            }
            else
            {
                string GameOver = "Game Over";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
