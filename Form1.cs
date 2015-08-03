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

namespace Agario
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Matrix matrix1 = new Matrix();
        public int i;

        public Form1()
        {
            i = 0;
            InitializeComponent();

            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }


        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                matrix1.gomb[i].moveLEFT();
                textBox2.Text = matrix1.gomb[i].getX().ToString();
            }

            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                matrix1.gomb[i].moveDOWN();
                textBox3.Text = matrix1.gomb[i].getY().ToString();
            }

            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                matrix1.gomb[i].moveRIGHT();
                textBox2.Text = matrix1.gomb[i].getX().ToString();
            }
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                matrix1.gomb[i].moveUP();
                textBox3.Text = matrix1.gomb[i].getY().ToString();
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "gomb" + i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i >= 9) MessageBox.Show("Sajnos csak ennyi gomb van...");
            else
            {
                i++;
                textBox1.Text = "gomb" + i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i <= 0) MessageBox.Show("Sajnos csak ennyi gomb van...");
            else
            {
                i--;
                textBox1.Text = "gomb" + i;
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox2.Text = matrix1.gomb[i].getX().ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = matrix1.gomb[i].getY().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.gomb[i],6);
            textBox2.Text = matrix1.gomb[i].getX().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.gomb[i],2);
            textBox2.Text = matrix1.gomb[i].getX().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.gomb[i], 0);
            textBox3.Text = matrix1.gomb[i].getY().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.gomb[i], 4);
            textBox3.Text = matrix1.gomb[i].getY().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            matrix1.moveDIR(matrix1.gomb[i],rnd.Next(0,8));
            textBox2.Text = matrix1.gomb[i].getX().ToString();
            textBox3.Text = matrix1.gomb[i].getY().ToString();
        }

       private void button10_Click(object sender, EventArgs e)
        {
            //matrix1.Keyb(matrix1.gomb[i]);
        }
    }
}
