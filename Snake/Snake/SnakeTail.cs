using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakeTail:Comun
    {
        SnakeTail next;
        
        public SnakeTail(int x , int y1)
        {
            this.x = x;
            this.y = y;
           
            

        }
        public void Draw(Graphics g)
        {
            if (next != null)
            {
                next.Draw(g);
            }
            //dibujamos la serpiente y su cola
            g.FillRectangle(new SolidBrush(Color.DarkGoldenrod), this.x, this.y, this.ancho, this.ancho);
        }
        public SnakeTail tail()
        {
            return next;
        }
        public void mover(int x , int y)
        {
            if (next != null)
            {
                next.mover(this.x, this.y);
            }
            
            this.x = x;
            this.y = y;
            
        }
        public void eat()
        {
            if (next == null)
            {
                next = new SnakeTail(this.x, this.y);
            }
           
            else
            {
                next.eat();
            }
        }
        public int getx()
        {
            return x;
        }
        public int gety()
        {
            return y;
        }
        
    }
} 
