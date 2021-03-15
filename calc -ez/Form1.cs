using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc__ez
{
    public partial class Form1 : Form
    {
        float pervaya_peremennaya, vtoraya_peremennaya;
        int count;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    vtoraya_peremennaya = pervaya_peremennaya + float.Parse(textBox1.Text);
                    textBox1.Text = vtoraya_peremennaya.ToString();
                    break;
                case 2:
                    vtoraya_peremennaya = pervaya_peremennaya - float.Parse(textBox1.Text);
                    textBox1.Text = vtoraya_peremennaya.ToString();
                    break;
                case 3:
                    vtoraya_peremennaya = pervaya_peremennaya * float.Parse(textBox1.Text);
                    textBox1.Text = vtoraya_peremennaya.ToString();
                    break;
                case 4:
                    vtoraya_peremennaya = pervaya_peremennaya / float.Parse(textBox1.Text);
                    textBox1.Text = vtoraya_peremennaya.ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_tochka_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            pervaya_peremennaya = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = pervaya_peremennaya.ToString() + "-";
            znak = true;
        }

        private void button_umnojenie_Click(object sender, EventArgs e)
        {
            pervaya_peremennaya = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = pervaya_peremennaya.ToString() + "*";
            znak = true;
        }

        private void button_delenie_Click(object sender, EventArgs e)
        {
            pervaya_peremennaya = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = pervaya_peremennaya.ToString() + "/";
            znak = true;
        }
          
        private void button_plus_Click(object sender, EventArgs e)
        {
            pervaya_peremennaya = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = pervaya_peremennaya.ToString() + "+";
            znak = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button_minys_pred_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button_module_Click(object sender, EventArgs e)
        {
            if (znak = true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak = false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button_ravno_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
    }

}
