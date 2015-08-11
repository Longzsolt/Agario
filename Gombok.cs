using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Gombok
    {
        private int x;
        private int y;
        private int size;
        public int xMax;
        public int yMax;
        private string Name;
        private Random rnd = new Random();

        public Gombok()
        {
            this.x = 1;
            this.y =  1;
            this.size = 4;
            this.xMax = 800;
            this.yMax = 300;
            this.Name = "gomb";

        }
        public void setX(int x)
        {

            this.x = x;
        }

        public int getX()
        {
            return x;
        }

        public void setY(int y)
        {
            if (y > yMax)
            {
                y = rnd.Next(0, 60);
            }
            this.y = y;
        }

        public int getY()
        {
            return y;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return Name;
        }

        public void setSize(int size)
        {

            this.size = size;

        }

        public int getSize()
        {

            return size-1;

        }

        public void moveUP()
        {
            if (y == 0)
            {
              //  moveDOWN();
                return;
            }
            y--;
        }

        public void moveDOWN()
        {
            if (y >= yMax)
            {
            //    moveUP();
                return;
            }
            y++;
        }

        public void moveLEFT()
        {
            if (x == 0)
            {
            //    moveRIGHT();
                return;
            }
            x--;
        }

        public void moveRIGHT()
        {
            if (x >= xMax)
            {
             //   moveLEFT();
                return;
            }
            x++;
        }
    }
}
