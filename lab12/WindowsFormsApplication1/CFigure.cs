using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    abstract class CFigure
    {
        // Поля
        protected Graphics graphics;
        // Властивості
        public int X { get; set; } // Координата X центра фігури
        public int Y { get; set; } // Координата Y центра фігури
        // Абстрактний метод: малює фігуру на поверхні малювання GDI+
        abstract protected void Draw(Pen pen);
        // Показує фігуру (малює на поверхні малювання GDI+ кольором
        // переднього плану)
        public void Show()
        {
            Draw(Pens.Red);
        }
        // Приховує фігуру (малює на поверхні малювання GDI+ кольором фону)
        public void Hide()
        {
            Draw(Pens.White);
        }
        // Переміщує фігуру
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
        // Розширює фігуру
        abstract public void Expand(int dR);
        // Стискає фігуру
        abstract public void Collapse(int dR);
    } // Кінець опису класу
}
