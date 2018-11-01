using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CRectangle : CFigure
    {
        // Поля
        private int _sideA; // Підтримуюче поле для властивості SideA
        private int _sideB; // Підтримуюче поле для властивості SideB
        // Властивості
        public int SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                _sideA = value >= 200 ? 200 : value;
                _sideA = value <= 5 ? 5 : value;
            }
        }
        public int SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                _sideB = value >= 200 ? 200 : value; _sideB = value <= 5 ? 5 : value;
            }
        }
        // Конструктор, створює об'єкт прямокутника (для заданої поверхні
        // малювання GDI+) з заданими координатами та довжиною сторін
        public CRectangle(Graphics graphics, int X, int Y, int SideA, int SideB)
        {
            this.graphics = graphics; this.X = X;
            this.Y = Y;
            this.SideA = SideA;
            this.SideB = SideB;
        }
        // Малює прямокутник на поверхні малювання GDI+
        protected override void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - SideA / 2, Y - SideB / 2, SideA, SideB);
            graphics.DrawRectangle(pen, rectangle);
        }
        // Розширює прямокутник: збільшує довжину стрін на dX пікселів
        override public void Expand(int dX)
        {
            Hide();
            SideA = SideA + dX; SideB = SideB + dX;
            Show();
        }
        // Стискає прямокутник: зменшує довжину сторін на dX пікселів
        override public void Collapse(int dX)
        {
            Hide();
            SideA = SideA - dX;
            SideB = SideB - dX;
            Show();
        }
    } // Кінець оголошення класу
}
