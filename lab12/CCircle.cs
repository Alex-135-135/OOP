using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace lab11
{

 
    class CCircle {     
        // Константи     
        const int DefaultRadius = 50; 
        // Радіус кола за замовчуванням, пікс 
 
        // Поля     
        private Graphics graphics;     
        private int _radius;    
        // Підтримуюче поле для властивості Radius 
 
        // Властивості     
        public int X { get; set; }    
        // Координата X центра кола     
        public int Y { get; set; }    
        // Координата Y центра кола     
        public int Radius {             
            // Радіус кола         
            get { 
                 return _radius;         
            }         
            set {             
                _radius = value >= 200 ? 200 : value;             
                _radius = value <= 5  ? 5  : value;         
            }     
        } 
 
        // Конструктор, створює об'єкт кола (для заданої поверхні      
        // малювання GDI+) з заданими координатами.      
        // Радіус кола приймається за замовчуванням     
        public CCircle(Graphics graphics, int X, int Y){         
            this.graphics = graphics;         
            this.X = X;         
            this.Y = Y;         
            this.Radius = DefaultRadius;     
        } 
 
        // Конструктор, створює об'єкт кола (для заданої поверхні      
        // малювання GDI+) з заданими координатами та радіусом     
        public CCircle(Graphics graphics, int X, int Y, int Radius){         
            this.graphics = graphics;         
            this.X = X;         
            this.Y = Y;         
            this.Radius = Radius;     
        } 
 
        // Малює коло на поверхні малювання GDI+.      
        // Параметри кола задає перо pen     
        private void Draw(Pen pen){
            double rk = Radius / Math.Sqrt(2);
            double rki = 2 * Radius / Math.Sqrt(2);
            
            Rectangle Rect = new Rectangle(100, 100, 100, 100);
            //int angle = 45;

            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius,2 * Radius, 2 * Radius);
            Rectangle rectangle1 = new Rectangle(X - (int)rk, Y - (int)rk, (int)rki, (int)rki);
            //Rectangle rectangle2 = new Rectangle(-X - (int)rk, -Y - (int)rk, (int)rki, (int)rki);
            //Rectangle rectangle2 = new Rectangle(X, Y, 2, 2);
            graphics.DrawEllipse(pen, rectangle);
            //graphics.DrawEllipse(pen, rectangle2);
            graphics.DrawRectangle(pen, rectangle1);

            Point[] points = { new Point(X - Radius + Radius / 70, Y - Radius + Radius), 
                               new Point(X - Radius + Radius, Y - Radius + Radius * 2), 
                               new Point(X - Radius + Radius * 2, Y - Radius + Radius), 
                               new Point(X - Radius + Radius, Y - Radius + Radius / 70) };
           // graphics.RotateTransform = (45);
            graphics.DrawPolygon(pen, points);
             
            
            
        } 
 
        // Показує коло (малює на поверхні малювання GDI+ кольором      
        // переднього плану)     
        public void Show(){         
            Draw(Pens.Red);     
        } 
 
        // Приховує коло (малює на поверхні малювання GDI+ кольором фону)     
        public void Hide(){         
            Draw(Pens.White);     
        } 
 
        // Розширює коло: збільшує радіус на один піксель     
        public void Expand(){  
            Hide();         
            Radius++;         
            Show();     } 
 
        // Розширює коло: збільшує радіус на dR пікселів     
        public void Expand(int dR){         
            Hide();         
            Radius = Radius + dR;         
            Show();     
        }

        // Стискає коло: зменшує радіус на один піксель     
        public void Collapse(){         
            Hide();         
            Radius--;         
            Show();     
        } 

        // Стискає коло: зменшує радіус на dR пікселів     
        public void Collapse(int dR){         
            Hide();         
            Radius = Radius - dR;         
            Show();     
        } 

        // Переміщує коло     
        public void Move(int dX, int dY){         
            Hide();         
            X = X + dX;         
            Y = Y + dY;         
            Show();     
        } 

    }  // Кінець оголошення класу
}
