using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Piedra : Comun
    {
        public Piedra()
        {
           
            this.xp=Generate(80);
            this.yp=Generate(40);
        }
        public void Colocar()
        {
            this.xp = Generate(80);
            this.yp = Generate(40);

            this.xp1 = this.xp  +40;
            this.yp1 = this.yp  +40;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Gray), this.xp, this.yp, this.ancho , this.ancho );
        }
        public int Generate(int n)
        {
            Random R = new Random();
            int num = R.Next(0, n) * 10;
            return num;
        }
    }
}

