﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        Point head, newHead;
        int direction = 0; //0 - right, 1 - left, 2- bottom, 3- up
        List<Point> snake = new List<Point>();
        Random random = new Random();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        enum Direction { Up, Down, Left, Right };
        Direction currentDirection = Direction.Right;

        public Form1()
        {
            InitializeComponent();
            t.Interval = 150;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
            snake.Add(new Point(20, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Black, 2);
            Brush brush1 = new SolidBrush(Color.ForestGreen);
            Brush brush2 = new SolidBrush(Color.DarkSlateGray);

            // Draw the game boundaries
            g.DrawRectangle(pen1, new Rectangle(0, 0, panel1.Width, panel1.Height));

            for (int j = 0; j < snake.Count; j++)
            {
                Point point = snake[j];
                g.DrawRectangle(pen1, new Rectangle(point.X, point.Y, 20, 20));
                g.FillRectangle(brush1, new Rectangle(point.X, point.Y, 20, 20));
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            AddPoint();
            CheckGameOver();
        }

        private void AddPoint()
        {
            var head = snake.Last();
            newHead = new Point();

            switch (direction)
            {
                case 0: //right
                    newHead = new Point(head.X + 20, head.Y);
                    break;
                case 1: //left
                    newHead = new Point(head.X - 20, head.Y);
                    break;
                case 2: //down
                    newHead = new Point(head.X, head.Y + 20);
                    break;
                case 3: //up
                    newHead = new Point(head.X, head.Y - 20);
                    break;
            }

            snake.Add(newHead);

            if (snake.Count >= 10)
            {
                snake.RemoveAt(0);
            }
            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    direction = 0;
                    break;
                case Keys.Left:
                    direction = 1;
                    break;
                case Keys.Down:
                    direction = 2;
                    break;
                case Keys.Up:
                    direction = 3;
                    break;
            }
        }

        void CheckGameOver()
        {

            if (newHead.X < 0 || newHead.X > panel1.Width - 20 || newHead.Y < 0 || newHead.Y > panel1.Height - 20)
            {
                t.Stop();
                MessageBox.Show("GAME OVER!");
                panel1.Invalidate();
                this.Close();
            }


            panel1.Refresh();
        }
    }
}
