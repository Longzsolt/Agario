using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;



namespace Agario
{
    public partial class Form1 : Form
    {
        private List<Keys> pressedKeys = new List<Keys>();

        Random rnd = new Random();
        Matrix matrix1 = new Matrix();
        public int i;
        private int curX, curY;
        Image<Bgr, Byte> img = new Image<Bgr, Byte>(800, 600, new Bgr(255, 255, 255));

        

        public Form1()
        {
            InitializeComponent();

          //  img[200, 300] = new Bgr(0, 0, 0);

            imageBox1.Image = img;
            curX = matrix1.GombList.ElementAt(0).getX();
            curY = matrix1.GombList.ElementAt(0).getY();
            i = 0;
            Image_move();
            imageBox1.Image = img;


            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            //this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            textBox1.Text = "gomb" + i;



        }

        private void Image_move()
        {
            if (curX != matrix1.GombList.ElementAt(0).getX() || curY != matrix1.GombList.ElementAt(0).getY())
            {
                for (int i = curY; i < curY + matrix1.GombList.ElementAt(0).getSize(); i++)
                {
                    for (int j = curX; j < curX + matrix1.GombList.ElementAt(0).getSize(); j++)
                    {
                        img[i, j] = new Bgr(255, 255, 255);
                    }
                }

            }
            curX = matrix1.GombList.ElementAt(0).getX();
            curY = matrix1.GombList.ElementAt(0).getY();

            if (matrix1.collision())
            {

                for (int a = matrix1.collgomb.getY(); a < matrix1.collgomb.getY() + matrix1.collgomb.getSize(); a++)
                {
                    for (int b = matrix1.collgomb.getX(); b < matrix1.collgomb.getX() + matrix1.collgomb.getSize(); b++)
                    {
                        img[a, b] = new Bgr(0, 0, 0);
                    }

                }
                imageBox1.Image = img;
               // MessageBox.Show("Oops");

            }

            for (int i = matrix1.GombList.ElementAt(0).getY(); i < matrix1.GombList.ElementAt(0).getY() + matrix1.GombList.ElementAt(0).getSize(); i++)
            {
                for (int j = matrix1.GombList.ElementAt(0).getX(); j < matrix1.GombList.ElementAt(0).getX() + matrix1.GombList.ElementAt(0).getSize(); j++)
                {
                    img[i, j] = new Bgr(0, 0, 0);
                }
            }

            imageBox1.Image = img;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pressedKeys.Count == 0) pressedKeys.Add(e.KeyCode);
            if (e.KeyCode != pressedKeys.ElementAt(pressedKeys.Count - 1)) pressedKeys.Add(e.KeyCode);
            //  if (pressedKeys.Count > 1 ) MessageBox.Show("Menne de nem megy");
            movePressedKeys();


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
            //printPressedKeys();

        }

        private void movePressedKeys()
        {
            foreach (var key in pressedKeys)
            {
                if (key == Keys.W)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(0), 0);
                    //textBox3.Text = matrix1.GombList.ElementAt(0).getY().ToString();
                }
                if (key == Keys.A)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(0), 6);
                    //textBox2.Text = matrix1.GombList.ElementAt(0).getX().ToString();
                }
                if (key == Keys.S)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(0), 4);
                    //textBox3.Text = matrix1.GombList.ElementAt(0).getY().ToString();
                }
                if (key == Keys.D)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(0), 2);
                   // textBox2.Text = matrix1.GombList.ElementAt(0).getX().ToString();
                }
                Image_move();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // MessageBox.Show(matrix1.GombList.Count.ToString());
            matrix1.Add(i);
            foreach(var gomb in matrix1.GombList)
            {
                for (int a = gomb.getY(); a < gomb.getY() + gomb.getSize(); a++)
                {
                    for (int b = gomb.getX(); b < gomb.getX() + gomb.getSize(); b++)
                    {
                        img[a, b] = new Bgr(0, 0, 0);
                    }
                }
            }
                imageBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (matrix1.GombList.Count - 1 <= 0) return;
            for (int a = matrix1.GombList.ElementAt(matrix1.GombList.Count-1).getY(); a < matrix1.GombList.ElementAt(matrix1.GombList.Count-1).getY() + matrix1.GombList.ElementAt(matrix1.GombList.Count-1).getSize(); a++)
            {
                for (int b = matrix1.GombList.ElementAt(matrix1.GombList.Count-1).getX(); b < matrix1.GombList.ElementAt(matrix1.GombList.Count-1).getX() + matrix1.GombList.ElementAt(matrix1.GombList.Count-1).getSize(); b++)
                {
                    img[a, b] = new Bgr(255, 255, 255);
                }
            }
            imageBox1.Image = img;
            matrix1.Remove();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (i <= 0) MessageBox.Show("Sajnos csak ennyi gomb van...");
            else
            {
                i--;
                textBox1.Text = "gomb" + i;
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (i >= matrix1.GombList.Count - 1) MessageBox.Show("Sajnos csak ennyi gomb van...");
            else
            {
                i++;
                textBox1.Text = "gomb" + i;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

    }
}