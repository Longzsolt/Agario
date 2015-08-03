using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;



namespace ConsoleApplication1
{
    public class Matrix
    {


        public Gombok[] gomb = new Gombok[10];

        private Random rnd = new Random();

        public Matrix()
        {

            for (int i = 0; i < 10; i++)
            {
                gomb[i] = new Gombok();
            }

            for (int i = 0; i < gomb.Length; i++)
            {

                gomb[i].setX(rnd.Next(0, 80));
                gomb[i].setY(rnd.Next(0, 60));
                gomb[i].setName("gomb" + i);
            }

        }

        public void moveDIR(Gombok gombA, int dir)
        {
            if (dir == 0)
            {
                gombA.moveUP();
            }
            if (dir == 1)
            {
                gombA.moveUP();
                gombA.moveRIGHT();
            }
            if (dir == 2)
            {
                gombA.moveRIGHT();
            }
            if (dir == 3)
            {
                gombA.moveRIGHT();
                gombA.moveDOWN();
            }
            if (dir == 4)
            {
                gombA.moveDOWN();
            }
            if (dir == 5)
            {
                gombA.moveDOWN();
                gombA.moveLEFT();
            }
            if (dir == 6)
            {
                gombA.moveLEFT();
            }
            if (dir == 7)
            {
                gombA.moveLEFT();
                gombA.moveUP();
            }

        }

        public bool collision()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (gomb[i].getX() == gomb[j].getX() && gomb[i].getY() == gomb[j].getY())

                        return true;
                }

            }

            return false;
        }

       /* public void Keyb(Gombok gomb)
        {
            // while ((Console.ReadKey(true).Key == ConsoleKey.W) || (Console.ReadKey(true).Key == ConsoleKey.A) || (Console.ReadKey(true).Key == ConsoleKey.D) || (Console.ReadKey(true).Key == ConsoleKey.S))
            // {
            if (Console.KeyAvailable)
            {
                if (Keyboard.IsKeyPressed(Key.W))
                {
                    {
                        gomb.moveUP();
                    }
                }

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.A)
                    {
                        gomb.moveLEFT();
                    }
                }

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.D)
                    {
                        gomb.moveRIGHT();
                    }
                }

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.S)
                    {
                        gomb.moveDOWN();
                    }
                    // }
                }
            }*/


        }

    }

