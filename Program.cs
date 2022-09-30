using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        static void Main(string[] args)
        {
            Form mForm = new Form();
            mForm.Text = "Calculator 1.0";
            mForm.Size = new System.Drawing.Size(500, 850);
            mForm.AutoSize = false;
            mForm.MaximizeBox = false;
            mForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            mForm.StartPosition = FormStartPosition.CenterScreen;


            mForm.Controls.Add(resultTextBox);
            resultTextBox.Text = button_zero.Text;
            resultTextBox.Size = new System.Drawing.Size(500,500);
            resultTextBox.Font = new Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Point);
            resultTextBox.Enabled = true;
            resultTextBox.BackColor = Color.Orange;


            Panel buttonControl = new Panel();
            mForm.Controls.Add(buttonControl);
            buttonControl.BackColor = Color.Gray;
            buttonControl.Location = new Point(0, resultTextBox.Height + 10);
            buttonControl.Size = new System.Drawing.Size(500, 850);



            button_C.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_C.Text = "C";
            button_C.Size = new System.Drawing.Size(500, 50);
            buttonControl.Controls.Add(button_C);
            button_C.Click += new EventHandler(act_button_C);

            //=============================================================================
            
            button_7.Text = "7";
            button_7.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_7.Size = new System.Drawing.Size(80, 80);
            button_7.Location = new Point(10, button_C.Height + 10);
            buttonControl.Controls.Add(button_7);

            button_8.Text = "8";
            button_8.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_8.Size = new System.Drawing.Size(80, 80);
            button_8.Location = new Point(10+ button_7.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_8);

            button_9.Text = "9";
            button_9.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_9.Size = new System.Drawing.Size(80, 80);
            button_9.Location = new Point(10 + button_8.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_9);

            button_div.Text = "/";
            button_div.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_div.Size = new System.Drawing.Size(80, 80);
            button_div.Location = new Point(10 + button_9.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_div);



            //=============================================================================

            button_4.Text = "4";
            button_4.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_4.Size = new System.Drawing.Size(80, 80);
            button_4.Location = new Point(10, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_4);

            button_5.Text = "5";
            button_5.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_5.Size = new System.Drawing.Size(80, 80);
            button_5.Location = new Point(10 + button_4.Right, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_5);

            button_6.Text = "6";
            button_6.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_6.Size = new System.Drawing.Size(80, 80);
            button_6.Location = new Point(10 + button_5.Right, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_6);

            button_mul.Text = "x";
            button_mul.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_mul.Size = new System.Drawing.Size(80, 80);
            button_mul.Location = new Point(10 + button_6.Right, button_C.Height + 40 + button_7.Top);
            buttonControl.Controls.Add(button_mul);

            //=============================================================================

            button_1.Text = "1";
            button_1.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_1.Size = new System.Drawing.Size(80, 80);
            button_1.Location = new Point(10, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_1);

            button_2.Text = "2";
            button_2.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_2.Size = new System.Drawing.Size(80, 80);
            button_2.Location = new Point(10 + button_1.Right, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_2);

            button_3.Text = "3";
            button_3.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_3.Size = new System.Drawing.Size(80, 80);
            button_3.Location = new Point(10 + button_2.Right, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_3);

            button_sub.Text = "-";
            button_sub.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_sub.Size = new System.Drawing.Size(80, 80);
            button_sub.Location = new Point(10 + button_3.Right, button_C.Height + 40 + button_4.Top);
            buttonControl.Controls.Add(button_sub);

            //=============================================================================

            button_zero.Text = "0";
            button_zero.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_zero.Size = new System.Drawing.Size(170, 80);
            button_zero.Location = new Point(10, button_C.Height + 40 + button_1.Top);
            buttonControl.Controls.Add(button_zero);

            button_result.Text = "=";
            button_result.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_result.Size = new System.Drawing.Size(170, 80);
            button_result.Location = new Point(10 + button_zero.Right, button_C.Height + 40 + button_1.Top);
            buttonControl.Controls.Add(button_result);

            //=============================================================================
            Button button_plus = new Button();
            button_plus.Text = "+";
            button_plus.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            button_plus.Size = new System.Drawing.Size(80, 80 * 4 + 30);
            button_plus.Location = new Point(10 + button_div.Right, button_C.Height + 10);
            buttonControl.Controls.Add(button_plus);






            mForm.Show();

            Application.Run(mForm);
        }
        static void btn_C_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_0_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }

        static void btn_1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_3_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_4_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_6_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_7_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_8_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
        static void btn_9_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + button_zero.Text;
        }
                static void act_button_C(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
        }
    }
}
