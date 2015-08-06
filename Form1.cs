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



        public Form1()
        {

            i = 0;

            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            //this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            textBox1.Text = "gomb" + i;



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
                    matrix1.moveDIR(matrix1.GombList.ElementAt(i), 0);
                    textBox3.Text = matrix1.GombList.ElementAt(i).getY().ToString();
                }
                if (key == Keys.A)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(i), 6);
                    textBox2.Text = matrix1.GombList.ElementAt(i).getX().ToString();
                }
                if (key == Keys.S)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(i), 4);
                    textBox3.Text = matrix1.GombList.ElementAt(i).getY().ToString();
                }
                if (key == Keys.D)
                {
                    matrix1.moveDIR(matrix1.GombList.ElementAt(i), 2);
                    textBox2.Text = matrix1.GombList.ElementAt(i).getX().ToString();
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            matrix1.Add(i);

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox2.Text = matrix1.GombList.ElementAt(i).getX().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = matrix1.GombList.ElementAt(i).getY().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.GombList.ElementAt(i), 6);
            textBox2.Text = matrix1.GombList.ElementAt(i).getX().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.GombList.ElementAt(i), 2);
            textBox2.Text = matrix1.GombList.ElementAt(i).getX().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.GombList.ElementAt(i), 0);
            textBox3.Text = matrix1.GombList.ElementAt(i).getY().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.GombList.ElementAt(i), 4);
            textBox3.Text = matrix1.GombList.ElementAt(i).getY().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.GombList.ElementAt(i), rnd.Next(0, 8));
            textBox2.Text = matrix1.GombList.ElementAt(i).getX().ToString();
            textBox3.Text = matrix1.GombList.ElementAt(i).getY().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //matrix1.Keyb(matrix1.gomb[i]);
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