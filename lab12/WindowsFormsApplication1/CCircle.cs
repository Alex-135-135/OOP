using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CCircle : CFigure
    {
        // Поля
        private int _radius; // Підтримуюче поле для властивості Radius
        // Властивості
        public int Radius
        {
            // Радіус кола
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
        // Конструктор, створює об'єкт кола (для заданої поверхні
        // малювання GDI+) з заданими координатами та радіусом
        public CCircle(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics; this.X = X;
            this.Y = Y; this.Radius = Radius;
        }
        // Малює коло на поверхні малювання GDI+
        protected override void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            graphics.DrawEllipse(pen, rectangle);
        }
        // Розширює коло: збільшує радіус на dR пікселів
        override public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        // Стискає коло: зменшує радіус на dR пікселів
        override public void Collapse(int dR)
        {
            Hide(); Radius = Radius - dR;
            Show();
        }
    } // Кінець оголошення класу
}
