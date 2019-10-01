using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        SnakeTail head;//declaro la cabeza
        Graphics g;
        Food food;
        int score = 0;
        //para moverse solo en 4 direcciones posibles y solo 1 cada vez
        int direcx = 0;
        int direcy = 0;
        Boolean ejex = true;
        Boolean ejey = true;
        int Tile = 20;
       

        public Form1()
        {
            InitializeComponent();
            head = new SnakeTail(10, 10);//instancio cabeza
            g = Canvas.CreateGraphics();
            food = new Food();
        }
        public void movimientos()
        {
            head.mover(head.getx() + direcx, head.gety() + direcy);
        }

        private void bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            head.Draw(g);
            food.Draw(g);
            movimientos();
            eatItself();
            wallcrash();
            if (head.Colision(food))
            {
                food.newFood();
                head.eat();
                score++;
                Puntos.Text = score.ToString();
            }
        }
        public void End()
        {
            score = 0;
            Puntos.Text = "0";
            direcx = 0;
            direcy = 0;
            ejex = true;
            ejey = true;
            food = new Food();
            head = new SnakeTail(10, 10);
            MessageBox.Show("GAME OVER");

        }
        public void wallcrash()
        {
            if (head.getx() < 0 || head.getx() > Canvas.Width || head.gety() < 0 || head.gety() > Canvas.Height)
            {
                End();
            }
        }
        public void eatItself()
        {
            SnakeTail temp;
            try
            {
                temp = head.tail().tail();
            }
            catch (Exception err)
            {

                temp = null;
            }
            while (temp != null)
            {
                if (head.Colision(temp))
                {
                    End();
                }
                else
                {
                    temp = temp.tail();
                }
            }
            
        }
        public int getAltCanvas()
        {
            return (int)Canvas.Height;
        }
        public int getAnchoCanvas()
        {
            return (int)Canvas.Width;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex == true)
            {
                if(e.KeyCode == Keys.Up)
                {
                    direcy = -Tile;
                    direcx =  0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    direcy = Tile;
                    direcx = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey == true)
            {
                if (e.KeyCode == Keys.Right)
                {
                    direcy = 0;
                    direcx = Tile;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    direcy = 0;
                    direcx = -Tile;
                    ejex = true;
                    ejey = false;
                }
            }
        }

        
    }
}
