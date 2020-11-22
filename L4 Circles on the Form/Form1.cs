using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_Circles_on_the_Form
{
    public partial class Form1 : Form
    {
        Figure figure;
        Circle circle;
        public Form1()
        {
            InitializeComponent();
            figure = new Figure();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {      
            circle = new Circle();
            circle.X = e.X;
            circle.Y = e.Y;
            
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {         
                        if (figure.is_inside(e.X, e.Y) == true) 
                            figure.inside_circle(e.X, e.Y);
                        else figure.add_circle(circle);
                        break;
                    }
                case MouseButtons.Right:
                    {
                        var colors = (Color.HotPink, Color.Orange, Color.Blue);                    
                        figure.del_circle(colors);
                        break;
                    }
            }
            Invalidate();
        }
        void draw(Circle circle)
        {
            CreateGraphics().DrawEllipse(new Pen(circle.Color, 2), circle.X - circle.Radius,
                        circle.Y - circle.Radius, 2 * circle.Radius, 2 * circle.Radius);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < figure.get_count(); ++i)
                draw(figure.get_circle(i));
        }

        public class Figure
        {
            private LinkedList<Circle> circles = new LinkedList<Circle>();

            public void add_circle(Circle circle)
             {
                // Переход статуса на обычный и выделенный
                if (circles.Count != 0)
                    transite_addition();
                // -----------
               
                circles.AddLast(circle);
            }

            public void del_circle((Color, Color, Color) colors)
            {
                bool is_del = false;               
                for (int i = 0; i < circles.Count; ++i)
                {
                    var item = circles.First;
                    while (item != null)
                    {
                        if (item.Value.Color == colors.Item1 || item.Value.Color == colors.Item2)
                        {
                            circles.Remove(item);
                            is_del = true;
                            i--;                            
                        }                      
                        item = item.Next;
                    }
                }
                var it = circles.First;
                while (it != null)
                {
                    if (is_del == false && it.Value.Color == colors.Item3) 
                        circles.Remove(it);
                    it = it.Next;
                }

                    // Переход текущего статуса
                if (circles.Count != 0)
                    transite_deleting();
                // -----------
            }
            public Circle get_circle(int index)
            {
                int count = 0;
                foreach(Circle circle in circles)
                {
                    if (index == count) return circle;
                    count++;
                }
                return null;
            }
            public int get_count() { return circles.Count; }

            public bool is_inside(int x, int y)
            {
                foreach (Circle circle in circles)
                {
                    int sum = Convert.ToInt32(Math.Pow(x - circle.X, 2) + Math.Pow(y - circle.Y, 2));
                    int rad = Convert.ToInt32(Math.Pow(circle.Radius, 2));
                    if (sum <= rad)
                        return true;       
                }
                return false;
            }

            public void inside_circle(int x, int y)
            {
                foreach (Circle circle in circles)
                {
                    int sum = Convert.ToInt32(Math.Pow(x - circle.X, 2) + Math.Pow(y - circle.Y, 2));
                    int rad = Convert.ToInt32(Math.Pow(circle.Radius, 2));
                    if (sum <= rad)
                    {
                        if (circle.Color == Color.Blue)
                            circle.Color = Color.Orange;
                        else circle.Color = Color.HotPink;
                    }
                }
            }

            public int check_color()
            {
                foreach(Circle circle in circles)
                {
                    if (circle.Color == Color.HotPink) return 0;
                    if (circle.Color == Color.Orange) return 1;
                }
                return -1;
            }

            private void transite_addition()
            {
                if (circles.Last.Value.Color == Color.Blue)
                    circles.Last.Value.Color = Color.Red;
                else if (circles.Last.Value.Color == Color.Orange) 
                    circles.Last.Value.Color = Color.HotPink;
            }
            private void transite_deleting()
            {
                int rand = new Random().Next(0, circles.Count);
                int count = 0;
                foreach (Circle c in circles)
                {
                    if (rand == count && c.Color != Color.Blue)
                        c.Color = Color.Blue;
                    count++;
                }
            }
        }

        public class Circle
        {
            private int x, y;
            public int X { set { x = value; } get { return x; } }
            public int Y { set { y = value; } get { return y; } }

            private const int radius = 30;
            public int Radius { get { return radius; } }

            private Color color;
            public Color Color { set { color = value; } get { return color; } }

            public Circle() { color = Color.Blue; }

            public Circle(int x, int y, Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }
        }
    }
}
