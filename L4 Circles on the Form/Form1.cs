using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_Circles_on_the_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

        

    public class Figure
    {
        private LinkedList<Circle> circles = new LinkedList<Circle>();

        public void add_circle(int x, int y, Color color)
        {
            // Переход статуса на обычный и выделенный
            transite_addition();
            // -----------

            circles.AddLast(new Circle(x, y, color));
        }
        public void add_circle(Circle circle)
        {
            // Переход статуса на обычный и выделенный
            transite_addition();
            // -----------

            circles.AddLast(circle);
        }
        public void del_circle(Circle circle)
        {
            circles.Remove(circle);

            // Переход текущего статуса
            transite_deleting();
            // -----------
        }
        public void del_circle(Color color)
        {
            foreach (Circle circle in circles)
            {
                if (circle.Color == color)
                    circles.Remove(circle);
            }
            // Переход текущего статуса
            transite_deleting();
            // -----------
        }
        private void transite_addition()
        {
            if (circles.Last.Value.Color == Color.Blue)
                circles.Last.Value.Color = Color.Red;
            else circles.Last.Value.Color = Color.Green;
        }
        private void transite_deleting()
        {
            int rand = new Random().Next(0, circles.Count);
            int count = 0;
            foreach (Circle c in circles)
            {
                if (rand == count)
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

        private const int radius = 25;
        public int Radius { get { return radius; } }

        private Color color;
        public Color Color { set { color = value; } get { return color; } }

        public Circle(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}
