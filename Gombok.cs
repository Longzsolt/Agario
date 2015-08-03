﻿using System;
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
        private int xMax;
        private int yMax;
        private string Name;
        private Random rnd = new Random();

        public Gombok()
        {
            this.x = 1;
            this.y =  1;
            this.xMax = 80;
            this.yMax = 60;
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
