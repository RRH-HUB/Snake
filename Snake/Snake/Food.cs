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
           
            this.x = Generate(80);
            this.y = Generate(60);

        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Green), this.x, this.y, this.ancho,  this.ancho);
        }
        public void newFood()
        {
            this.x = Generate(70);
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
