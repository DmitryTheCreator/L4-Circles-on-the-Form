using System;
using System.Collections.Generic;
using System.Drawing;
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
        // Обработчик нажатия кнопкой мыши на форму.
        // Присваивает координаты курсора объекту класса круга.
        // Если нажата ЛКМ, создется новый объект, либо объект, на который
        // нажали меняет свой цвет.
        // Если нажата ПКМ, удаляются выделенные объекты, либо текущий
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
                        var colors = (Color.DeepPink, Color.Orange, Color.Blue);                    
                        figure.del_circle(colors);
                        break;
                    }
            }
            Invalidate();
        }
        // Функция, которая рисует объекты из хранилища
        void draw(Circle circle)
        {
            CreateGraphics().DrawEllipse(new Pen(circle.Color, 2), circle.X - circle.Radius,
                        circle.Y - circle.Radius, 2 * circle.Radius, 2 * circle.Radius);
        }

        // Обработчик события перерисовки элементов формы
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < figure.get_count(); ++i)
                draw(figure.get_circle(i));
        }
        // Обработчик события нажатия на кнопку очистки экрана
        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
        }
        // Обработчик события отображения объектов из хранилища
        private void btnShow_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
        // Класс-хранилище кругов. Имеет следующий методы:
        // добавление круга, удаление круга, получение круга,
        // получение количества кругов, проверка на нахождение
        // точки внутри круга, измение цвета круга, если точка
        // находится внутри него, изменение цвета круга при 
        // добавлении и удалении объекта.
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
                        else if (circle.Color != Color.Orange) 
                            circle.Color = Color.DeepPink;
                    }
                }
            }

            private void transite_addition()
            {
                foreach(Circle circle in circles)
                {
                    if (circle.Color == Color.Blue)
                        circle.Color = Color.Red;
                    if (circle.Color == Color.Orange)
                        circle.Color = Color.DeepPink;
                }
            }
            private void transite_deleting()
            {
                int rand = new Random().Next(0, circles.Count);
                int count = 0;
                bool is_found = false;
                foreach (Circle c in circles)
                {
                    if (c.Color == Color.Blue)
                        is_found = true;
                }
                foreach (Circle c in circles)
                {
                    if (rand == count && is_found == false)
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
        }   
    }
}
