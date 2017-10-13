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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] nummers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] randomarray = random(nummers);        // Running 'Random' method from below to fix position numbers

            int Row = 4;
            int Column = 4;
            tableLayoutPanel1.RowCount = Row;
            tableLayoutPanel1.ColumnCount = Column;
            for (int i = 0; i < 4; i++)         // Amount of cells, 4rows by 4columns
            {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            }
            for (int i = 0; i < 16; i++)        // Amount of buttons, 4x4=16 here       
            {
                var button = new Button();
                //button.Text kan weg bij oplevering, is alleen voor duidelijkheid bij programmeren
                button.Text = Convert.ToString(randomarray[i]);
                button.Name = string.Format("Button_{0}", (randomarray[i]));
                button.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(button);
                button.Click += new System.EventHandler(button_Click);
            }
        }
        public static int[] random(int[] array)         // Method to refill the 0,0 array with random non-duplicate numbers between from 1 to 16
        {
            var random = new Random();

            int[] randomArray = Enumerable.Range(1, array.Length).OrderBy(x => random.Next()).ToArray();
            return randomArray;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int nummer = Convert.ToInt32(clickedButton.Text);
            clickedButton.BackgroundImage = KrijgImage(nummer);
            clickedButton.BackgroundImageLayout = ImageLayout.Stretch;

        }
        public static Image KrijgImage(int nummer)
        {
            switch (nummer)
            {
                //elke knop krijgt andere image. button_1 en button_2 = paar etc...
                
                
                case 1:
                    Image image1 = Properties.Resources.image_1;
                    return image1;
                case 2:
                    Image image2 = Properties.Resources.image_2;
                    return image2;
                case 3:
                    Image image3 = Properties.Resources.image_3;
                    return image3;
                case 4:
                    Image image4 = Properties.Resources.image_4;
                    return image4;
                case 5:
                    Image image5 = Properties.Resources.image_5;
                    return image5;
                case 6:
                    Image image6 = Properties.Resources.image_6;
                    return image6;
                case 7:
                    Image image7 = Properties.Resources.image_7;
                    return image7;
                case 8:
                    Image image8 = Properties.Resources.image_8;
                    return image8;
                case 9:
                    Image image9 = Properties.Resources.image_9;
                    return image9;
                case 10:
                    Image image10 = Properties.Resources.image_10;
                    return image10;
                case 11:
                    Image image11 = Properties.Resources.image_11;
                    return image11;
                case 12:
                    Image image12 = Properties.Resources.image_12;
                    return image12;
                case 13:
                    Image image13 = Properties.Resources.image_13;
                    return image13;
                case 14:
                    Image image14 = Properties.Resources.image_14;
                    return image14;
                case 15:
                    Image image15 = Properties.Resources.image_15;
                    return image15;
                case 16:
                    Image image16 = Properties.Resources.image_16;
                    return image16;
                default:
                    Image dickbutt = null;
                    return dickbutt;
            }
            
            }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
