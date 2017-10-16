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
            int[] numberCards = new int[64];        // Atm 6x6, manier zoeken om dit te maken zodat gebruiker kiest hoe groot het speelveld is
            int[] randomarray = random(numberCards);        // Running 'Random' method from below to fix position numbers

            int Row = Convert.ToInt16(Math.Sqrt(numberCards.Length));
            int Column = Convert.ToInt16(Math.Sqrt(numberCards.Length));
            tableLayoutPanel1.RowCount = Row;
            tableLayoutPanel1.ColumnCount = Column;
            for (int i = 0; i < (Row); i++)         // Amount of cells, 4rows by 4columns
            {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            }
            for (int i = 0; i < (Row*Column); i++)        // Amount of buttons      
            {
                var button = new Button();
                button.Text = Convert.ToString(randomarray[i]);
                button.Name = Convert.ToString((randomarray[i]));
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

        private void button_Click(object sender, EventArgs e)       // Way to flip cards based on their #Name
        {
            string ButtonName;
            Button button = sender as Button;
            ButtonName =button.Name;
            
            if (ButtonName=="1"||ButtonName=="2")
                label1.Text = "een"; 
            if (ButtonName == "3" || ButtonName == "4")
                label1.Text = "twee";
            if (ButtonName == "5" || ButtonName == "6")
                label1.Text = "drie";
            if (ButtonName == "7" || ButtonName == "8")
                label1.Text = "vier";
            if (ButtonName == "9" || ButtonName == "10")
                label1.Text = "vijf";
            if (ButtonName == "11" || ButtonName == "12")
                label1.Text = "zes";
            if (ButtonName == "13" || ButtonName == "14")
                label1.Text = "zeven";
            if (ButtonName == "15" || ButtonName == "16")
                label1.Text = "acht";
        } 
    }
}
