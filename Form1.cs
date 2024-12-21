using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //pipes ki speed kay liyay
        int speed = 5;
        //bird ki movement kay liyay
        int movement = 5;
        //bird ko jump karanay kay liyay
        int jump = 75;
        int score = 0;

        bool IsGameOver = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreLabel.Text = "Score" + score;
            pipeUp.Left -= speed;
            pipeDown.Left -= speed;
            bird.Top += movement;


            if(pipeUp.Left < -60)
            {
                pipeUp.Left = 500;
                score++;
            }

            if(score == 10)
            {
                speed = 10;

            }
            if(score == 20)
            {
                speed = 20;
            }

            if (pipeDown.Left < -60)
            {
                pipeDown.Left = 500;
                score++;
            }

            if (bird.Bounds.IntersectsWith(pipeUp.Bounds)||bird.Bounds.IntersectsWith(pipeDown.Bounds)|| bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsGameOver)
            {
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                bird.Top -= jump;
            }

        }

        public void endGame()
        {
            timer1.Stop();
            gameStatus.Text = "Game Over!!";
            restartLabel.Text = "Restart!!";
            IsGameOver = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void restartLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
