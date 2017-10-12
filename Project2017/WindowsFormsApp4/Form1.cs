using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int CardFlipCount = 0;
        

        public Form1()
        {
            InitializeComponent();
        }
      

            public void Images()
        {
            PictureBox CardBackground = new PictureBox();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            PictureBox CardImage = sender as PictureBox;
            label1.Text = Convert.ToString(CardFlipCount);
            CardImage.Image = Image.FromFile("C:\\Users\\Jelle\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\Resources\\Image1.png");
            CardFlipCount = CardFlipCount + 1;

        }

    }
} 
