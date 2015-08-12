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

        public Gombok collgomb;
        public int pozicio;

        public List <Gombok> GombList = new List <Gombok>();

        private Random rnd = new Random();

        public Matrix()
        {
            collgomb = new Gombok();
            Add(0);
            GombList.ElementAt(0).setSize(20);
            GombList.ElementAt(0).setX(400);
            GombList.ElementAt(0).setY(300);
        }


        public void Add(int i)
        {

            Gombok gomb = new Gombok();
            gomb.setSize(rnd.Next(0, 20));
            gomb.setX(rnd.Next(0,gomb.xMax-gomb.getSize()-1));
            gomb.setY(rnd.Next(0,gomb.yMax-gomb.getSize()-1));
            gomb.setName("gomb" + i);
            GombList.Add(gomb);

        }

        public void Remove (int gomb)
        {

            GombList.RemoveAt(gomb);

        }

        public void moveDIR(Gombok gombA, int dir)
        {
            switch (dir)
            {
                case 0: 
                    if (gombA.getY() > 0)gombA.moveUP();
                    break;
                case 1:
                    if (gombA.getY() > 0) gombA.moveUP();
                    if (gombA.getX()+gombA.getSize() < gombA.xMax) gombA.moveRIGHT();
                      break;
                case 2:
                      if (gombA.getX() + gombA.getSize() < gombA.xMax) gombA.moveRIGHT();
                      break;
                case 3:
                      if (gombA.getX() + gombA.getSize() < gombA.xMax) gombA.moveRIGHT();
                      if (gombA.getY() + gombA.getSize() < gombA.yMax) gombA.moveDOWN();
                      break;
                case 4:
                      if (gombA.getY() + gombA.getSize() < gombA.yMax) gombA.moveDOWN();
                      break;
                case 5:
                      if (gombA.getY() + gombA.getSize() < gombA.yMax) gombA.moveDOWN();
                      if (gombA.getX() > 0) gombA.moveLEFT();
                      break;
                case 6:
                      if (gombA.getX() > 0) gombA.moveLEFT();
                      break;
                case 7:
                      if (gombA.getX() > 0) gombA.moveLEFT();
                      if (gombA.getY() > 0) gombA.moveUP();
                      break;
            }

        }

        public bool collision()
        {
                foreach(var gombj in GombList)
                {
                    if (GombList.ElementAt(0) != gombj)
                    {

                        if ((GombList.ElementAt(0).getY() >= gombj.getY() && GombList.ElementAt(0).getY() <= gombj.getY() + gombj.getSize()) && (GombList.ElementAt(0).getX() >= gombj.getX() && GombList.ElementAt(0).getX() <= gombj.getX() + gombj.getSize())) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                        if ((GombList.ElementAt(0).getY() >= gombj.getY() && GombList.ElementAt(0).getY() <= gombj.getY() + gombj.getSize()) && (GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() >= gombj.getX() && GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() <= gombj.getX() + gombj.getSize())) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                        if ((GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() >= gombj.getY() && GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() <= gombj.getY() + gombj.getSize()) && (GombList.ElementAt(0).getX() >= gombj.getX() && GombList.ElementAt(0).getX() <= gombj.getX() + gombj.getSize())) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                        if ((GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() >= gombj.getY() && GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() <= gombj.getY() + gombj.getSize()) && (GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() >= gombj.getX() && GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() <= gombj.getX() + gombj.getSize())) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                    
                    }
                }
            return false;
        }

        public bool eat ()
        {
            foreach (var gombj in GombList)
            {
                if (gombj.getSize() >= GombList.ElementAt(0).getSize()) return false;
                if (GombList.ElementAt(0) != gombj)
                {

                    if ((GombList.ElementAt(0).getY() >= gombj.getY() && GombList.ElementAt(0).getY() <= gombj.getY() + gombj.getSize()/2) && (GombList.ElementAt(0).getX() >= gombj.getX() && GombList.ElementAt(0).getX() <= gombj.getX() + gombj.getSize()/2)) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                    if ((GombList.ElementAt(0).getY() >= gombj.getY() && GombList.ElementAt(0).getY() <= gombj.getY() + gombj.getSize()/2) && (GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() >= gombj.getX() && GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() <= gombj.getX() + gombj.getSize()/2)) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                    if ((GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() >= gombj.getY() && GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() <= gombj.getY() + gombj.getSize()/2) && (GombList.ElementAt(0).getX() >= gombj.getX() && GombList.ElementAt(0).getX() <= gombj.getX() + gombj.getSize()/2)) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                    if ((GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() >= gombj.getY() && GombList.ElementAt(0).getY() + GombList.ElementAt(0).getSize() <= gombj.getY() + gombj.getSize()/2) && (GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() >= gombj.getX() && GombList.ElementAt(0).getX() + GombList.ElementAt(0).getSize() <= gombj.getX() + gombj.getSize()/2)) { pozicio = GombList.IndexOf(gombj); collgomb = gombj; return true; }
                    

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

