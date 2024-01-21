using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;

        protected void btnOne_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
        }

        protected void btnTwo_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnTwo.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnTwo.Text;
            }
        }

        protected void btnThree_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnThree.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnThree.Text;
            }
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnFour.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnFour.Text;
            }
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnFive.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnFive.Text;
            }
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnSix.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnSix.Text;
            }
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnSeven.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnSeven.Text;
            }
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnEight.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnEight.Text;
            }
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnNine.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnNine.Text;
            }
        }

        protected void btnZero_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnZero.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnZero.Text;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void btnDone_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            if (b == '/')
            {
                d = a / c;
                TextBox1.Text += d;
                a = d;
            }
            else if (b == '+')
            {
                d = a + c;
                TextBox1.Text += d;
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                TextBox1.Text += d;
                a = d;
            }
            else
            {
                d = a * c;
                TextBox1.Text += d;
                a = d;
            }
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '/';
            TextBox1.Text += b;
        }

        protected void btnMulti_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '*';
            TextBox1.Text += b;
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '-';
            TextBox1.Text += b;
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '+';
            TextBox1.Text += b;
        }
    }
}