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


        public List <Gombok> GombList = new List <Gombok>();

        private Random rnd = new Random();

        public Matrix()
        {

            Add(0);

        }


        public void Add(int i)
        {

            Gombok gomb = new Gombok();
            gomb.setX(rnd.Next(0, 80));
            gomb.setY(rnd.Next(0, 60));
            gomb.setName("gomb" + i);
            GombList.Add(gomb);

        }

        public void Remove ()
        {

            GombList.RemoveAt(GombList.Count);

        }

        public void moveDIR(Gombok gombA, int dir)
        {
            switch (dir)
            {
                case 0: 
                    gombA.moveUP();
                    break;
                case 1:
                      gombA.moveUP();
                      gombA.moveRIGHT();
                      break;
                case 2:
                      gombA.moveRIGHT();
                      break;
                case 3:
                      gombA.moveRIGHT();
                      gombA.moveDOWN();
                      break;
                case 4:
                      gombA.moveDOWN();
                      break;
                case 5:
                      gombA.moveDOWN();
                      gombA.moveLEFT();
                      break;
                case 6:
                      gombA.moveLEFT();
                      break;
                case 7:
                      gombA.moveLEFT();
                      gombA.moveUP();
                      break;
            }

        }

        public bool collision()
        {
            for (var it = 0; it < GombList.Count - 1 ; it++)
            {
                for (var i = 0; i < GombList.Count; i++)
                {
                    if (GombList[it].getX() == GombList[i].getX() && GombList[it].getY() == GombList[i].getY()) return true;
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

