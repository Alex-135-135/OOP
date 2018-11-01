using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CEmblem : CFigure
    {
        const int DefaultRadius = 50;
        private int _radius;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }

        }
        // Конструктор, створює об'єкт трикутника (для заданої поверхні
        // малювання GDI+) з заданими координатами та довжиною сторони
        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        // Малює трикутник на поверхні малювання GDI+
        protected override void Draw(Pen pen)
        {
            double rk = Radius / Math.Sqrt(2);
            double rki = 2 * Radius / Math.Sqrt(2);

            Rectangle Rect = new Rectangle(100, 100, 100, 100);
            //int angle = 45;

            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            Rectangle rectangle1 = new Rectangle(X - (int)rk, Y - (int)rk, (int)rki, (int)rki);
            graphics.DrawEllipse(pen, rectangle);
            graphics.DrawRectangle(pen, rectangle1);

            Point[] points = { new Point(X - Radius + Radius / 70, Y - Radius + Radius), 
                               new Point(X - Radius + Radius, Y - Radius + Radius * 2), 
                               new Point(X - Radius + Radius * 2, Y - Radius + Radius), 
                               new Point(X - Radius + Radius, Y - Radius + Radius / 70) };
            graphics.DrawPolygon(pen, points);
        }
        // Розширює трикутник: збільшує довжину стрін на dX пікселів
        override public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        // Стискає трикутник: зменшує довжину сторін на dX пікселів
        override public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
    }
}
