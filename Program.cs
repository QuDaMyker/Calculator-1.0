using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateWinform
{
    class Program
    {
        static TextBox resultTextBox = new TextBox();

        static Button button_C = new Button();
        static Button button_zero = new Button();
        static Button button_1 = new Button();
        static Button button_2 = new Button();
        static Button button_3 = new Button();
        static Button button_4 = new Button();
        static Button button_5 = new Button();
        static Button button_6 = new Button();
        static Button button_7 = new Button();
        static Button button_8 = new Button();
        static Button button_9 = new Button();
        static Button button_plus = new Button();
        static Button button_sub = new Button();
        static Button button_mul = new Button();
        static Button button_div = new Button();
        static Button button_result = new Button();

        static int temp_1 = 0;
        static int temp_2 = 0;
        static void Main(string[] args)
        {
            Form mForm = new Form();
            mForm.Text = "Calculator 1.0";
            mForm.Size = new System.Drawing.Size(480, 550);
            mForm.AutoSize = false;
            mForm.MaximizeBox = false;
            mForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            mForm.StartPosition = FormStartPosition.CenterScreen;


            mForm.Controls.Add(resultTextBox);
            resultTextBox.Text = button_zero.Text;
            resultTextBox.Size = new System.Drawing.Size(500,500);
            resultTextBox.Font = new Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Point);
            resultTextBox.Enabled = false;
            resultTextBox.BackColor = Color.Orange;


            Panel buttonControl = new Panel();
            mForm.Controls.Add(buttonControl);
            buttonControl.BackColor = Color.Gray;
            buttonControl.Location = new Point(0, resultTextBox.Height + 10);
            buttonControl.Size = new System.Drawing.Size(500, 850);



            button_C.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_C.Text = "C";
            button_C.Size = new System.Drawing.Size(450, 50);
            button_C.Location = new Point(5, 5);
            buttonControl.Controls.Add(button_C);
            button_C.Click += new EventHandler(btn_C_Click);

            //=============================================================================
            
            button_7.Text = "7";
            button_7.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_7.Size = new System.Drawing.Size(80, 80);
            button_7.Location = new Point(10, button_C.Height + 10);
            buttonControl.Controls.Add(button_7);
            button_7.Click += new EventHandler(btn_7_Click);


            button_8.Text = "8";
            button_8.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_8.Size = new System.Drawing.Size(80, 80);
            button_8.Location = new Point(10+ button_7.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_8);
            button_8.Click += new EventHandler(btn_8_Click);


            button_9.Text = "9";
            button_9.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_9.Size = new System.Drawing.Size(80, 80);
            button_9.Location = new Point(10 + button_8.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_9);
            button_9.Click += new EventHandler(btn_9_Click);


            button_div.Text = "/";
            button_div.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_div.Size = new System.Drawing.Size(80, 80);
            button_div.Location = new Point(10 + button_9.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_div);
            button_div.Click += new EventHandler(btn_div_Click);




            //=============================================================================

            button_4.Text = "4";
            button_4.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_4.Size = new System.Drawing.Size(80, 80);
            button_4.Location = new Point(10, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_4);
            button_4.Click += new EventHandler(btn_4_Click);


            button_5.Text = "5";
            button_5.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_5.Size = new System.Drawing.Size(80, 80);
            button_5.Location = new Point(10 + button_4.Right, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_5);
            button_5.Click += new EventHandler(btn_5_Click);


            button_6.Text = "6";
            button_6.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_6.Size = new System.Drawing.Size(80, 80);
            button_6.Location = new Point(10 + button_5.Right, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_6);
            button_6.Click += new EventHandler(btn_6_Click);

            button_mul.Text = "x";
            button_mul.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_mul.Size = new Size(80, 80);
            button_mul.Location = new Point(10 + button_6.Right, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_mul);
            button_mul.Click += new EventHandler(btn_mul_Click);


            //=============================================================================

            button_1.Text = "1";
            button_1.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_1.Size = new System.Drawing.Size(80, 80);
            button_1.Location = new Point(10, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_1);
            button_1.Click += new EventHandler(btn_1_Click);


            button_2.Text = "2";
            button_2.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_2.Size = new System.Drawing.Size(80, 80);
            button_2.Location = new Point(10 + button_1.Right, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_2);
            button_2.Click += new EventHandler(btn_2_Click);

            button_3.Text = "3";
            button_3.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_3.Size = new System.Drawing.Size(80, 80);
            button_3.Location = new Point(10 + button_2.Right, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_3);
            button_3.Click += new EventHandler(btn_3_Click);


            button_sub.Text = "-";
            button_sub.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_sub.Size = new System.Drawing.Size(80, 80);
            button_sub.Location = new Point(10 + button_3.Right, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_sub);
            button_sub.Click += new EventHandler(btn_sub_Click);

            //=============================================================================

            button_zero.Text = "0";
            button_zero.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_zero.Size = new System.Drawing.Size(170, 80);
            button_zero.Location = new Point(10, button_C.Height + 40 + button_1.Top);
            buttonControl.Controls.Add(button_zero);
            button_zero.Click += new EventHandler(btn_0_Click);


            button_result.Text = "=";
            button_result.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_result.Size = new System.Drawing.Size(170, 80);
            button_result.Location = new Point(10 + button_zero.Right, button_C.Height + 40 + button_1.Top);
            buttonControl.Controls.Add(button_result);
            button_result.Click += new EventHandler(btn_result_Click);

            //=============================================================================
            button_plus.Text = "+";
            button_plus.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_plus.Size = new System.Drawing.Size(80, 80 * 4 + 30);
            button_plus.Location = new Point(10 + button_div.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_plus);
            button_plus.Click += new EventHandler(btn_plus_Click);

            //=============================================================================
            

            mForm.Show();

            Application.Run(mForm);
        }
        static void btn_C_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
        }
        static void btn_0_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }

        static void btn_1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_1.Text;
        }
        static void btn_2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_2.Text;
        }
        static void btn_3_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_3.Text;
        }
        static void btn_4_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_4.Text;
        }
        static void btn_5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_5.Text;
        }
        static void btn_6_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_6.Text;
        }
        static void btn_7_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_7.Text;
        }
        static void btn_8_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_8.Text;
        }
        static void btn_9_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_9.Text;
        }
        static void btn_plus_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_plus.Text;
        }
        static void btn_sub_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_sub.Text;
        }
        static void btn_mul_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_mul.Text;
        }
        static void btn_div_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_div.Text;
        }
        static void btn_result_Click(object sender, EventArgs e)
        {
            /*temp_1 = Convert.ToInt32(resultTextBox);
            enabled = true;
            resultTextBox.Text = resultTextBox.Text + button_div.Text;*/


            temp_1 = 0;
            temp_2 = 0;
            string temp_result = resultTextBox.Text;

            int i;
            for (i = 0; i < temp_result.Length; i++) 
            {
                if (temp_result[i] <= '9' && temp_result[i] >= '0' )
                {
                    temp_1 = temp_1 * 10 + Convert.ToInt32(temp_result[i]) - 48;
                }
                else
                {
                    break;
                }
            }
            int flag = i;
            i++;

            for (; i < resultTextBox.Text.Length; i++)
            {
                temp_2 = temp_2 * 10 + Convert.ToInt32(temp_result[i]) - 48;
            }

            if (temp_result[flag] == '+')
            {
                resultTextBox.Text = Convert.ToString(temp_1 + temp_2);
            }
            else if(temp_result[flag] == '-')
            {
                resultTextBox.Text = Convert.ToString(temp_1 - temp_2);
            }
            else if (temp_result[flag] == 'x')
            {
                resultTextBox.Text = Convert.ToString(temp_1 * temp_2);
            }
            else
            {
                resultTextBox.Text = ((double)temp_1 / (double)temp_2).ToString();
            }
        }
    }
}
