using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double[,] numbers;

        double[] resulr;


        

        private double MethodM(double[,] mx)
        {
            double r = (mx[0, 0] * mx[1, 1] * mx[2, 2]) +
                  (mx[1, 0] * mx[2, 1] * mx[0, 2]) +
                  (mx[0, 1] * mx[1, 2] * mx[2, 0]) -
                  (mx[2, 0] * mx[1, 1] * mx[0, 2]) -
                  (mx[0, 1] * mx[1, 0] * mx[2, 2]) -
                  (mx[0, 0] * mx[2, 1] * mx[1, 2]);
            return r;
        }

        



        private void button3_Click(object sender, EventArgs e)
        {

            iniNewNum();
        }

        private void iniNewNum()
        {
            numbers = new double[3, 3] { { Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),Convert.ToDouble(textBox3.Text)},
                { Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text)},
                { Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text), Convert.ToDouble(textBox11.Text)}};

            resulr = new double[] { Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox12.Text) };

            label2.Text = numbers[0, 0] + "x" + "+" + numbers[0, 1] + "y" + "+" + numbers[0, 2] + "z = " + resulr[0];
            label3.Text = numbers[1, 0] + "x" + "+" + numbers[1, 1] + "y" + "+" + numbers[1, 2] + "z = " + resulr[1];
            label4.Text = numbers[2, 0] + "x" + "+" + numbers[2, 1] + "y" + "+" + numbers[2, 2] + "z = " + resulr[2];

            label52.Text = numbers[0, 0] + "x" + "+" + numbers[0, 1] + "y" + "+" + numbers[0, 2] + "z = " + resulr[0];
            label51.Text = numbers[1, 0] + "x" + "+" + numbers[1, 1] + "y" + "+" + numbers[1, 2] + "z = " + resulr[1];
            label50.Text = numbers[2, 0] + "x" + "+" + numbers[2, 1] + "y" + "+" + numbers[2, 2] + "z = " + resulr[2];

            label43.Text = numbers[0, 0] + "x" + "+" + numbers[0, 1] + "y" + "+" + numbers[0, 2] + "z = " + resulr[0];
            label42.Text = numbers[1, 0] + "x" + "+" + numbers[1, 1] + "y" + "+" + numbers[1, 2] + "z = " + resulr[1];
            label37.Text = numbers[2, 0] + "x" + "+" + numbers[2, 1] + "y" + "+" + numbers[2, 2] + "z = " + resulr[2];

            label57.Text = numbers[0, 0] + "x" + "+" + numbers[0, 1] + "y" + "+" + numbers[0, 2] + "z = " + resulr[0];
            label56.Text = numbers[1, 0] + "x" + "+" + numbers[1, 1] + "y" + "+" + numbers[1, 2] + "z = " + resulr[1];
            label55.Text = numbers[2, 0] + "x" + "+" + numbers[2, 1] + "y" + "+" + numbers[2, 2] + "z = " + resulr[2];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            iniNewNum();
            
            goooseFull();

        }

      


        private void button1_Click(object sender, EventArgs e)
        {
            iniNewNum();

            double delta = MethodM(numbers);

            double[,] deltax = new double[3, 3] { { resulr[0], numbers[0, 1], numbers[0, 2] },
                { resulr[1], numbers[1, 1], numbers[1, 2] }, { resulr[2], numbers[2, 1], numbers[2, 2] } };
            double dx = MethodM(deltax);

            double[,] deltay = new double[3, 3] { { numbers[0, 0], resulr[0], numbers[0, 2] },
                { numbers[1, 0], resulr[1], numbers[1, 2] }, { numbers[2, 0], resulr[2], numbers[2, 2] } };
            double dy = MethodM(deltay);

            double[,] deltaz = new double[3, 3] { { numbers[0, 0], numbers[0, 1], resulr[0] },
                { numbers[1, 0], numbers[1, 1], resulr[1] }, { numbers[2, 0], numbers[2, 1], resulr[2] } };
            double dz = MethodM(deltaz);

            double x = dx / delta;
            double y = dy / delta;
            double z = dz / delta;
            textBox14.Text = "";


            textBox14.Text += "delta = " + ((numbers[0, 0] + "*" + numbers[1, 1] + "*" + numbers[2, 2]) + "+" +
                (numbers[1, 0] + "*" + numbers[2, 1] + "*" + numbers[0, 2]) + "+" +
                (numbers[0, 1] + "*" + numbers[1, 2] + "*" + numbers[2, 0]) + "-" +
                (numbers[2, 0] + "*" + numbers[1, 1] + "*" + numbers[0, 2]) + "-" +
                (numbers[0, 1] + "*" + numbers[1, 0] + "*" + numbers[2, 2]) + "-" +
                (numbers[0, 0] + "*" + numbers[2, 1] + "*" + numbers[1, 2])).ToString() + "= " + delta.ToString() + Environment.NewLine + Environment.NewLine;


            textBox14.Text += "delta x = " + ((deltax[0, 0] + "*" + deltax[1, 1] + "*" + deltax[2, 2]) + "+" +
                (deltax[1, 0] + "*" + deltax[2, 1] + "*" + deltax[0, 2]) + "+" +
                (deltax[0, 1] + "*" + deltax[1, 2] + "*" + deltax[2, 0]) + "-" +
                (deltax[2, 0] + "*" + deltax[1, 1] + "*" + deltax[0, 2]) + "-" +
                (deltax[0, 1] + "*" + deltax[1, 0] + "*" + deltax[2, 2]) + "-" +
                (deltax[0, 0] + "*" + deltax[2, 1] + "*" + deltax[1, 2])).ToString() + "= " + dx.ToString() + Environment.NewLine;


            textBox14.Text += "delta y = " + ((deltay[0, 0] + "*" + deltay[1, 1] + "*" + deltay[2, 2]) + "+" +
                (deltay[1, 0] + "*" + deltay[2, 1] + "*" + deltay[0, 2]) + "+" +
                (deltay[0, 1] + "*" + deltay[1, 2] + "*" + deltay[2, 0]) + "-" +
                (deltay[2, 0] + "*" + deltay[1, 1] + "*" + deltay[0, 2]) + "-" +
                (deltay[0, 1] + "*" + deltay[1, 0] + "*" + deltay[2, 2]) + "-" +
                (deltay[0, 0] + "*" + deltay[2, 1] + "*" + deltay[1, 2])).ToString() + "= " + dy.ToString() + Environment.NewLine;


            textBox14.Text += "delta z = " + ((deltaz[0, 0] + "*" + deltaz[1, 1] + "*" + deltaz[2, 2]) + "+" +
                (deltaz[1, 0] + "*" + deltaz[2, 1] + "*" + deltaz[0, 2]) + "+" +
                (deltaz[0, 1] + "*" + deltaz[1, 2] + "*" + deltaz[2, 0]) + "-" +
                (deltaz[2, 0] + "*" + deltaz[1, 1] + "*" + deltaz[0, 2]) + "-" +
                (deltaz[0, 1] + "*" + deltaz[1, 0] + "*" + deltaz[2, 2]) + "-" +
                (deltaz[0, 0] + "*" + deltaz[2, 1] + "*" + deltaz[1, 2])).ToString() + "= " + dz.ToString() + Environment.NewLine + Environment.NewLine;


            textBox14.Text += "x = " + dx.ToString() + "/" + delta.ToString() + "= " + x.ToString() + Environment.NewLine + Environment.NewLine;
            textBox14.Text += "y = " + dy.ToString() + "/" + delta.ToString() + "= " + y.ToString() + Environment.NewLine + Environment.NewLine;
            textBox14.Text += "z = " + dz.ToString() + "/" + delta.ToString() + "= " + z.ToString() + Environment.NewLine + Environment.NewLine;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            iniNewNum();
            gooose2();
        }


        public override String ToString()
        {
            String S = "";
            for (int i = 0; i < 3; i++)
            {
                S += "\r\n|  ";
                for (int j = 0; j < 3; j++)
                {
                    S += numbers[i, j].ToString("F02") + "  ";
                }
                S += "|  " + resulr[i].ToString("F02") + "  |";
            }
            return S;
        }



        #region HelpMessage

        
        private void button8_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(textBox14.Text);
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(textBox15.Text);
            newForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Form2 newForm = new Form2(textBox13.Text);
            newForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(textBox16.Text);
            newForm.Show();

            
        }

        #endregion


        void gooose1()
        {
            for (int i = 0; i < 3; i++)
            {

                double del = numbers[i, i];
                textBox13.Text += "Рядок " + (i + 1) + " ділимо на " + del + Environment.NewLine;

                for (int k = 0; k < 3; k++)
                    numbers[i, k] /= del;
                resulr[i] /= del;


                textBox13.Text += ToString() + Environment.NewLine;

                for (int m = i + 1; m < 3; m++)
                {
                    del = numbers[m, i];
                    //Console.WriteLine(del + "-");
                    textBox13.Text += "Рядок " + (i + 1) + " множимо на " + del + " і від рядка " + (m + 1) + " віднімаємо рядок " + (i + 1) + Environment.NewLine;
                    ///textBox13.Text += ToString()+Environment.NewLine;
                    for (int j = 0; j < 3; j++)
                    {
                        numbers[m, j] -= numbers[i, j] * del;
                    }
                    resulr[m] -= resulr[i] * del;

                    textBox13.Text += ToString() + Environment.NewLine;

                }

            }

        }

        void gooose2()
        {

            for (int i = 0; i < 3; i++)
            {

                double del = numbers[i, i];
                textBox16.Text += "Рядок " + (i + 1) + " ділимо на " + del + Environment.NewLine;

                for (int k = 0; k < 3; k++)
                    numbers[i, k] /= del;
                resulr[i] /= del;


                textBox16.Text += ToString() + Environment.NewLine;

                for (int m = i + 1; m < 3; m++)
                {
                    del = numbers[m, i];

                    textBox16.Text += "Рядок " + (i + 1) + " множимо на " + del + " і від рядка " + (m + 1) + " віднімаємо рядок " + (i + 1) + Environment.NewLine;

                    for (int j = 0; j < 3; j++)
                    {
                        numbers[m, j] -= numbers[i, j] * del;
                    }
                    resulr[m] -= resulr[i] * del;

                    textBox16.Text += ToString() + Environment.NewLine;
                }
            }

            textBox16.Text += "Теперь берем и перевертаємо матрицю з ніг на голову і знову вирішуємо за допомогою методу Гаусса" + Environment.NewLine;

            numbers = new double[3, 3]
            {
                { numbers[2, 2], numbers[2, 1], numbers[2, 0] },
                { numbers[1, 2], numbers[1, 1], numbers[1, 0] },
                { numbers[0, 2], numbers[0, 1], numbers[0, 0] }
            };
            resulr = new double[3]
            {
                resulr[2], resulr[1], resulr[0]
            };

            for (int i = 0; i < 3; i++)
            {

                double del = numbers[i, i];
                textBox16.Text += "Рядок " + (i + 1) + " ділимо на " + del + Environment.NewLine;

                for (int k = 0; k < 3; k++)
                    numbers[i, k] /= del;
                resulr[i] /= del;


                textBox16.Text += ToString() + Environment.NewLine;

                for (int m = i + 1; m < 3; m++)
                {
                    del = numbers[m, i];

                    textBox16.Text += "Рядок " + (i + 1) + " множимо на " + del + " і від рядка " + (m + 1) + " віднімаємо рядок " + (i + 1) + Environment.NewLine;

                    for (int j = 0; j < 3; j++)
                    {
                        numbers[m, j] -= numbers[i, j] * del;
                    }
                    resulr[m] -= resulr[i] * del;

                    textBox16.Text += ToString() + Environment.NewLine;
                }
            }

            textBox16.Text += "x: " + resulr[2] + Environment.NewLine;
            textBox16.Text += "y: " + resulr[1] + Environment.NewLine;
            textBox16.Text += "z: " + resulr[0] + Environment.NewLine;
        }

        void goooseFull()
        {
            gooose1();
            double x3 = resulr[2];
            double x2 = resulr[1] - (numbers[1, 2] * x3);
            double x1 = resulr[0] - (numbers[0, 2] * x3) - (numbers[0, 1] * x2);
            textBox13.Text += "x: " + x1 + Environment.NewLine;
            textBox13.Text += "y: " + x2 + Environment.NewLine;
            textBox13.Text += "z: " + x3 + Environment.NewLine;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            iniNewNum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniNewNum();

            double delta = MethodM(numbers);

            textBox15.Text = "";
            textBox15.Text += "Елементи союзної матриці" + Environment.NewLine + Environment.NewLine;
            textBox15.Text += "Delta = " + delta.ToString() + Environment.NewLine + Environment.NewLine;

            double a11, a12, a13, a21, a22, a23, a31, a32, a33;

            a11 = numbers[1, 1] * numbers[2, 2] - numbers[2, 1] * numbers[1, 2];
            a12 = (numbers[1, 0] * numbers[2, 2] - numbers[2, 0] * numbers[1, 2]) * (-1);
            a13 = numbers[1, 0] * numbers[2, 1] - numbers[2, 0] * numbers[1, 1];
            a21 = (numbers[0, 1] * numbers[2, 2] - numbers[2, 1] * numbers[0, 2]) * (-1);
            a22 = numbers[0, 0] * numbers[2, 2] - numbers[2, 0] * numbers[0, 2];
            a23 = (numbers[0, 0] * numbers[2, 1] - numbers[2, 0] * numbers[0, 1]) * (-1);
            a31 = numbers[0, 1] * numbers[1, 2] - numbers[1, 1] * numbers[0, 2];
            a32 = (numbers[0, 0] * numbers[1, 2] - numbers[1, 0] * numbers[0, 2]) * (-1);
            a33 = numbers[0, 0] * numbers[1, 1] - numbers[1, 0] * numbers[0, 1];

            textBox15.Text += "Мінор 11 = " + a11.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 12 = " + a12.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 13 = " + a13.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 21 = " + a21.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 22 = " + a22.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 23 = " + a23.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 31 = " + a31.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 32 = " + a32.ToString() + Environment.NewLine;

            textBox15.Text += "Мінор 33 = " + a33.ToString() + Environment.NewLine + Environment.NewLine;


            double zz12, zz13, zz21, zz23, zz31, zz32;
            a11 = (a11 / delta) * resulr[0];
            zz12 = (a21 / delta) * resulr[1];
            zz13 = (a31 / delta) * resulr[2];
            zz21 = (a12 / delta) * resulr[0];
            a22 = (a22 / delta) * resulr[1];
            zz23 = (a32 / delta) * resulr[2];
            zz31 = (a13 / delta) * resulr[0];
            zz32 = (a23 / delta) * resulr[1];
            a33 = (a33 / delta) * resulr[2];

            double x, y, z;

            x = a11 + zz12 + zz13;
            y = zz21 + a22 + zz23;
            z = zz31 + zz32 + a33;
            textBox15.Text += "Результат" + Environment.NewLine + Environment.NewLine;
            textBox15.Text += "X = " + x.ToString() + Environment.NewLine;
            textBox15.Text += "Y = " + y.ToString() + Environment.NewLine;
            textBox15.Text += "Z = " + z.ToString() + Environment.NewLine;




        }
    }
   
}
