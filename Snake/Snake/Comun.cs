using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Comun
    {
        protected int x;
        protected int y;
        protected int ancho;
        public Comun()
        {
            ancho = 20;
        }
        //calculo de colision
        public Boolean Colision(Comun o)
        {
            int compX = Math.Abs(this.x - o.x);
            int compY = Math.Abs(this.y - o.y);
            if (compX >= 0 && compX < ancho && compY >= 0 && compY < ancho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
