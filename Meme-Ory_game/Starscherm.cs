using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Startscherm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void rules_click(object sender, EventArgs e)
        {
            Form2 spelregels = new Form2();
            spelregels.ShowDialog();
        }

        private void scores_click(object sender, EventArgs e)
        {
            Form3 highscores = new Form3();
            highscores.ShowDialog();
        }

        private void start_click(object sender, EventArgs e)
        {
            Form4 memory = new Form4();
            memory.ShowDialog();
        }

        
    }
}
