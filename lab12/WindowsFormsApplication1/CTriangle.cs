using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CTriangle : CFigure
    {
        // Поля
        private int _side; // Підтримуюче поле для властивості Side
                           // Властивості
        public int Side
        {
            get
            {
                return _side;
            }
            set {
                _side = value >= 200 ? 200 : value;
                _side = value <= 5 ? 5 : value;
            }
            }
        // Конструктор, створює об'єкт трикутника (для заданої поверхні
        // малювання GDI+) з заданими координатами та довжиною сторони
        public CTriangle(Graphics graphics, int X, int Y, int Side)
        {
         this.graphics = graphics;
         this.X = X;
         this.Y = Y;
         this.Side = Side;
        }
        // Малює трикутник на поверхні малювання GDI+
        protected override void Draw(Pen pen)
        {
            double r = (Side / 2) / Math.Sin(Math.PI / 3); Point p1 = new Point(X, Y - (int)r);
            Point p2 = new Point(X - (int)(r * Math.Cos(Math.PI / 6)),
            Y + (int)(r * Math.Sin(Math.PI / 6)));
            Point p3 = new Point(X + (int)(r * Math.Cos(Math.PI / 6)),
            Y + (int)(r * Math.Sin(Math.PI / 6)));
            Point[] triangle = { p1, p2, p3 };
            graphics.DrawPolygon(pen, triangle);
        }
        // Розширює трикутник: збільшує довжину стрін на dX пікселів
        override public void Expand(int dX)
        {
            Hide();
            Side = Side + dX;
            Show();
        }
        // Стискає трикутник: зменшує довжину сторін на dX пікселів
        override public void Collapse(int dX)
        {
            Hide();
            Side = Side - dX;
            Show();
        }
    } // Кінець оголошення класу
}
