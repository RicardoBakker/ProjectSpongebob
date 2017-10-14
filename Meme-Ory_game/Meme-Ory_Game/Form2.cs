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
            int numberCards = 16; // deze variable moet door user ingevoerd kunnen worden uiteindelijk om grootte te kunnen veranderen (vanuit ComboBox?)
            int[] randomarray = random(numberCards);        // Running 'Random' method from below to fix position numbers
            
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
                button.Name = Convert.ToString(randomarray[i]);
                button.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(button);
                button.Click += new System.EventHandler(button_Click);
            }
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int nummer = Convert.ToInt32(clickedButton.Name);
            clickedButton.BackgroundImage = KrijgImage(nummer); //nummer = naam van button = het nummer uit de random array.
            clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static Image KrijgImage(int nummer) //Method voor de BackgroundImage
        {
            
            switch (nummer)
            {
                //elk paar krijgt dezelfde achtergrond via button_Click
                //moet langer worden voor grotere spellen dan 4x4
                case 1:
                case 2:
                    Image image1 = Properties.Resources.image_1;
                    return image1;
                case 3:
                case 4:
                    Image image2 = Properties.Resources.image_2;
                    return image2;
                case 5:
                case 6:
                    Image image3 = Properties.Resources.image_3;
                    return image3;
                case 7:
                case 8:
                    Image image4 = Properties.Resources.image_4;
                    return image4;
                case 9:
                case 10:
                    Image image5 = Properties.Resources.image_5;
                    return image5;
                case 11:
                case 12:
                    Image image6 = Properties.Resources.image_6;
                    return image6;
                case 13:
                case 14:
                    Image image7 = Properties.Resources.image_7;
                    return image7;
                case 15:
                case 16:
                    Image image8 = Properties.Resources.image_8;
                    return image8;
                default:
                    Image dickbutt = null;
                    return dickbutt;
            }
            
            }
        public static int[] random(int aantal)         // Method die een array maakt voor aantal als lengte
        {
            var random = new Random();
            int[] randomArray = Enumerable.Range(1, aantal).OrderBy(x => random.Next()).ToArray();
            return randomArray;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
