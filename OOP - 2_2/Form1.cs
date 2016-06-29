using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP___2_2
{
    public partial class Form1 : Form
    {
        double a, b, c, D;//Объявление переменных
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
        /// <summary>
        /// Метод для решения кв.уравнения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Kv_Uravnenie(double a, double b, double c)
        {
            if (D >= 0)
            {
                txt_result_x1.Text = Convert.ToString(Math.Round((((-b) + Math.Sqrt(D)) / (2 * a)), 2));
                txt_result_x2.Text = Convert.ToString(Math.Round((((-b) - Math.Sqrt(D)) / (2 * a)), 2));
            }
            if (D < 0)
            {
                txt_result_x1.Text = Convert.ToString(Math.Round((-b) / (2 * a), 2) + " + " + Math.Round(Math.Sqrt(-D) / (2 * a), 2) + "i");
                txt_result_x2.Text = Convert.ToString(Math.Round((-b) / (2 * a), 2) + " - " + Math.Round(Math.Sqrt(-D) / (2 * a), 2) + "i");
            }
        }
        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Вычисление корней кв.уравнения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try//проверка на корректность данных
            {
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);
            }
            catch//Если ошибка
            {
                MessageBox.Show("Некорректный ввод");
                btn_new.PerformClick();
                return;
            }
                if (a == 0)//Проверка коэффициента при X^2

                {
                    MessageBox.Show("Уравнение не квадратное(a=0)");
                    btn_new.PerformClick();
                }
                else
                {
                    D = (b * b) - (4 * a * c);
                    if (rv_Event.Checked)
                    {
                        if (D >= 0)
                        {
                            txt_result_x1.Text = Convert.ToString(Math.Round((((-b) + Math.Sqrt(D))/ (2 * a)),2));
                            txt_result_x2.Text = Convert.ToString(Math.Round((((-b) - Math.Sqrt(D)) / (2 * a)), 2));
                        }
                        if (D < 0)
                        {
                            txt_result_x1.Text = Convert.ToString(Math.Round((-b) / (2 * a),2) + " + " + Math.Round(Math.Sqrt(-D) / (2 * a),2) + "i");
                            txt_result_x2.Text = Convert.ToString(Math.Round((-b) / (2 * a),2) + " - " + Math.Round(Math.Sqrt(-D) / (2 * a),2) + "i");
                        }
                    }
                    if (rb_Method.Checked)
                    {
                        Kv_Uravnenie(a, b, c);//Вызов метода для вычисления корней
                    }
                    if (rb_Class.Checked)
                    {
                        string x1 = null;
                        string x2 = null;
                        MyClass.Square(a, b, c, ref x1, ref x2);//Вызов метода из отдельного класса
                        txt_result_x1.Text = x1;
                        txt_result_x2.Text = x2;
                    }
                }
            }
        /// <summary>
        /// Очищает textbox(1-6)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            txt_result_x2.Clear();
            txt_result_x1.Clear();
        }
        /// <summary>
        /// Ограничение ввода с клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if ((Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Delete) || (e.KeyChar == ',') || (e.KeyChar == '-')) & (e.KeyChar != '.'))
            {
                if (e.KeyChar == ',')
                {
                    int i = textbox.Text.IndexOf(",", 0, textbox.Text.Length);
                    if (i != (-1))
                    {
                        e.KeyChar = (char)Keys.None;
                    }
                }
                if (e.KeyChar == '-')
                {
                    int i = textbox.Text.Length;
                    if (i > 0)
                        e.KeyChar = (char)Keys.None;
                }
            }
            else
                e.KeyChar = (char)Keys.None;
        }
        /// <summary>
        /// Запрет на щелчок правой кнопки мыши на textbox(1-3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_a.ShortcutsEnabled = false;
            txt_b.ShortcutsEnabled = false;
            txt_c.ShortcutsEnabled = false;
        }

    }
}
