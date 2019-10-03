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
        protected int x1;
        protected int y;
        protected int y1;
        protected int xp;
        protected int yp;
        protected int xp1;
        protected int yp1;
        
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
            int compX1= Math.Abs(this.x - o.x1);
            int compY1 = Math.Abs(this.y - o.y1);
            int compXp = Math.Abs(this.x - o.xp);
            int compYp = Math.Abs(this.y - o.yp);
            int compXp1 = Math.Abs(this.x - o.xp1);
            int compYp1 = Math.Abs(this.y - o.yp1);



            if (compX >= 0 && compX < ancho && compY >= 0 && compY < ancho ||
                compX1 >= 0 && compX1 < ancho && compY1 >= 0 && compY1 < ancho ||
                compXp >= 0 && compXp < ancho && compYp >= 0 && compYp < ancho ||
                compXp1 >= 0 && compXp1 < ancho && compYp1 >= 0 && compYp1 < ancho
                )
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
