using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meme_Ory_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 settingsForm = new Form3();
            settingsForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
