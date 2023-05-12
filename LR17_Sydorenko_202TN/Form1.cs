using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR17_Sydorenko_202TN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label9.Text = "";
            label10.Text = "";
            label15.Text = "";
            label16.Text = "";
            button1.Text = "OK";
            button2.Text = "OK";
            button3.Text = "OK";
        }
        abstract class Figure
        {
            public abstract double Perimeter();
            public abstract double Area();            
        }
        class Rectangle : Figure
        {
            public double A { get; set; }
            public double B { get; set; }
            public override double Perimeter()
            {
                return A + B;
            }
            public override double Area()
            {
                return A * B;
            }        

        }
        class Circle : Figure
        {
            public double R { get; set; }
            public override double Perimeter()
            {
                return 2*3.14*R;
            }
            public override double Area()
            {
                return Math.Pow(R,2)*3.14;
            }
        }
        class Trapezium : Figure
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            public double D { get; set; }
            public double H { get; set; }
            public override double Perimeter()
            {
                return A + B + C + D;
            }
            public override double Area()
            {
                if (B == D && A < C)
                {
                    return ((A + C) / 2) * H;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            double k = Convert.ToDouble(textBox2.Text);
            Figure ter = new Rectangle() { A = f, B = k };
            label5.Text = Convert.ToString(ter.Perimeter());
            label6.Text = Convert.ToString(ter.Area());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox3.Text);
            Figure ter = new Circle() { R = k };
            label10.Text = Convert.ToString(ter.Perimeter());
            label9.Text = Convert.ToString(ter.Area());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox7.Text);
            double k = Convert.ToDouble(textBox6.Text);
            double s = Convert.ToDouble(textBox5.Text);
            double g = Convert.ToDouble(textBox4.Text);           
            double p = Convert.ToDouble(textBox8.Text);
            Figure ter = new Trapezium() { A = f, B = k, C = s, D = g, H = p };
            if(ter.Area() == 0)
            {
                label15.Text = "Бічні сторони повинні бути рівними або верхня поверхня більша нижньої";
                label16.Text = "Бічні сторони повинні бути рівними або верхня поверхня більша нижньої";
            }
            else
            {
                label15.Text = Convert.ToString(ter.Area());
                label16.Text = Convert.ToString(ter.Perimeter());
            }                     
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox3.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
}
