using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelsiusAndFahrenheit;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Из Цельсия в фаренгейт
        {
            string t;
            if (textBox1.Text.Length == 0)
                textBox2.Text = "";
            else if (textBox1.Focused)
            {
                t = textBox1.Text;
                textBox2.Text = CelsiusAndFahrenheit.Main.CelsiusToFahrenheit(Convert.ToDouble(t)).ToString();
            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Из Фаренгейта в Цельсий
        {
            string t;
            if (textBox2.Text.Length ==0)
                textBox1.Text = "";
            else if (textBox2.Focused)
            {
                t = textBox2.Text;
                textBox1.Text = CelsiusAndFahrenheit.Main.FahrenheitToCelsius(Convert.ToDouble(t)).ToString();
            };
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Ограничение на вводимые символы у 1го бокса
        {
            char number = e.KeyChar;
            if (e.KeyChar == ',' && (string.IsNullOrEmpty((sender as TextBox).Text) || (sender as TextBox).Text.Contains(',')) ||
                (!Char.IsDigit(number) && number != 8 && number != 44))
                e.Handled = true; //Запрет на ввод букв, нескольких запятых и запятой в начале
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //Ограничение на вводимые символы у 2го бокса
        {
            char number = e.KeyChar;
            if (e.KeyChar == ',' && (string.IsNullOrEmpty((sender as TextBox).Text) || (sender as TextBox).Text.Contains(',')) || 
                (!Char.IsDigit(number) && number != 8 && number != 44))
                e.Handled = true;
        }
    }
}
