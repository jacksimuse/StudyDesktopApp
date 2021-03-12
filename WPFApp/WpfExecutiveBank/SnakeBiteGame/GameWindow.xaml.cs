using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeBiteGame
{
    /// <summary>
    /// GameWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GameWindow : Window
    {
        Random rand = new Random();

        Ellipse[] snake = new Ellipse[30];
        Ellipse egg = new Ellipse();
        private int size = 12; // egg, body
        private int visibleCount = 5;
        private string move = "";
        private int eaten = 0;
        DispatcherTimer playTimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        private bool startFlag = false;


        public GameWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            InitSnake();
            InitEgg();

            move = "Up";
            playTimer.Interval = new TimeSpan(0, 0, 0, 0, 100); // 0.1초
            playTimer.Tick += PlayTimer_Tick;
            playTimer.Start();
        }

        private void InitEgg()
        {
            egg = new Ellipse();
            egg.Tag = new Point(rand.Next(1, 480 / size) * size, rand.Next(1, 380 / size) * size);
            egg.Width = size;
            egg.Height = size;
            egg.Stroke = Brushes.Black;
            egg.Fill = Brushes.Red;

            Point p = (Point)egg.Tag;
            CvsGame.Children.Add(egg);
            Canvas.SetLeft(egg, p.X);
            Canvas.SetTop(egg, p.Y);
        }

        private void InitSnake()
        {
            int x = rand.Next(1, 500 / size) * size;
            int y = rand.Next(1, 400 / size) * size;

            for (int i = 0; i < 30; i++)
            {
                snake[i] = new Ellipse();
                snake[i].Width = snake[i].Height = size;
                if (i == 0)
                    snake[i].Fill = Brushes.Chocolate;
                else if (i % 5 == 0)
                    snake[i].Fill = Brushes.YellowGreen;
                else
                    snake[i].Fill = Brushes.Gold;
                snake[i].Stroke = Brushes.Black;

                CvsGame.Children.Add(snake[i]);
            }

            //뱀길이를 5개, 나머지 화면에서 지움
            for (int i = visibleCount; i < 30; i++)
            {
                snake[i].Visibility = Visibility.Hidden;
            }

            CreateSnake(x, y);
        }

        private void CreateSnake(int x, int y)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                snake[i].Tag = new Point(x, y + i * size);
                Canvas.SetLeft(snake[i], x);
                Canvas.SetTop(snake[i], y + i * size);
            }
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            if (move != "")
            {
                startFlag = true;

                for (int i = visibleCount; i >= 1; i--)
                {
                    Point p = (Point)snake[i - 1].Tag;
                    snake[i].Tag = new Point(p.X, p.Y);
                }

                // 키보드 옮겼을때 처리
                Point pnt = (Point)snake[0].Tag;
                if (move == "Right")
                    snake[0].Tag = new Point(pnt.X + size, pnt.Y);
                else if (move == "Left")
                    snake[0].Tag = new Point(pnt.X - size, pnt.Y);
                else if (move == "Up")
                    snake[0].Tag = new Point(pnt.X, pnt.Y - size);
                else if (move == "Down")
                    snake[0].Tag = new Point(pnt.X, pnt.Y + size);
                // 알을 먹었는지 체크
                EatEgg();
            }

            if (startFlag)
            {
                TimeSpan span = stopwatch.Elapsed;
                TxtTime.Text = $"Time = {span.Minutes}:{span.Seconds}:{span.Milliseconds / 10}";
                DrawSnake();
            }
        }

        private void EatEgg()
        {
            Point pS = (Point)snake[0].Tag;
            Point pE = (Point)egg.Tag;

            if (pS.X == pE.X && pS.Y == pE.Y)
            {
                egg.Visibility = Visibility.Hidden;
                visibleCount++;
                snake[visibleCount - 1].Visibility = Visibility.Visible;   // 꼬리를 하나 늘림
                TxtScore.Text = "Eggs = " + (++eaten).ToString();

                if (visibleCount == 30)
                {
                    playTimer.Stop();
                    stopwatch.Stop();
                    DrawSnake();
                    TimeSpan ts = stopwatch.Elapsed;
                    string TimeElapsed = String.Format("Time = {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    MessageBox.Show("Success!!!  " + TimeElapsed + " sec");
                    this.Close();
                }

                Point p = new Point(rand.Next(1, 480 / size) * size, rand.Next(1, 380 / size) * size);
                egg.Tag = p;
                egg.Visibility = Visibility.Visible;
                Canvas.SetLeft(egg, p.X);
                Canvas.SetTop(egg, p.Y);
            }
        }

        private void DrawSnake()
        {
            for (int i = 0; i < visibleCount; i++)
            {
                Point p = (Point)snake[i].Tag;
                Canvas.SetLeft(snake[i], p.X);
                Canvas.SetTop(snake[i], p.Y);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (move == "")  // 맨 처음 키가 눌렸을 때 sw 시작
                stopwatch.Start();

            if (e.Key == Key.Right)
                move = "Right";
            else if (e.Key == Key.Left)
                move = "Left";
            else if (e.Key == Key.Up)
                move = "Up";
            else if (e.Key == Key.Down)
                move = "Down";
            else if (e.Key == Key.Escape)
                move = "";
        }
    }
}
