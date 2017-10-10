using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrick_Star_s_Calculator_pls_don_t_touchhy
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operate = "";
        bool pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((outcome.Text == "0") || (pressed))
             outcome.Clear(); 

            Button b = (Button)sender;
            outcome.Text = outcome.Text + b.Text;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            outcome.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operate = b.Text;
            value = Convert.ToDouble(outcome.Text);
            pressed = true;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operate)
            {
                case "+":
                    outcome.Text = (value + Convert.ToDouble(outcome.Text)).ToString();
                    break;
                case "-":
                    outcome.Text = (value - Convert.ToDouble(outcome.Text)).ToString();
                    break;
                case "/":
                    outcome.Text = (value / Convert.ToDouble(outcome.Text)).ToString();
                    break;
                case "*":
                    outcome.Text = (value * Convert.ToDouble(outcome.Text)).ToString();
                    break;
                default:
                    break;
            }
            pressed = false;
        }
    }
}
