using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telecomandino
{
    public partial class Form1 : Form
    {
        private Class1 chann;
        private Class1 vol;
        private Class1 acc;
        public Form1()
        {
            InitializeComponent();
            chann = new Class1();
            vol = new Class1();
            acc = new Class1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chann.setCanale(int.Parse(textBox1.Text));
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = chann.getCanale().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox2.Text);
            if (a >= 0 && a <= 100)
            {
                vol.setVolume(int.Parse(textBox2.Text));
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Inserisci un numero compreso tra 0 e 100");
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = vol.getVolume().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Acceso")
            {
                acc.setAcc(comboBox1.Text);
            }
            else if(comboBox1.Text == "Spento")
            {
                acc.setAcc(comboBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = acc.getAcc().ToString();
        }
    }
}
