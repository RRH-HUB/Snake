using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food:Comun
    {
       
        
        public Food()
        {
            this.x = Generate(110);
            this.y = Generate(50);
            this.x1 = Generate(110);
            this.y1 = Generate(50);

        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.LimeGreen) , this.x, this.y, this.ancho,  this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), this.x1, this.y1, this.ancho, this.ancho);
        }
        public void newFood()
        {
            this.x = Generate(110);
            this.y = Generate(50);
        }
        public void multipleFood()
        {
            this.x1 = Generate(110);
            this.y1 = Generate(50);
            this.x = Generate(110);
            this.y = Generate(50);

        }

            
       
        public int Generate(int n)
        {
            Random R = new Random();
            int num = R.Next(0, n) * 10;
            return num;
        }

    }
  
}
