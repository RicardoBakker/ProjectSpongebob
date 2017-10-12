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
            int[] nummers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int[] randomarray = random(nummers);
            
            int Row = 4;
            int Column = 4;
            tableLayoutPanel1.RowCount = Row;
            tableLayoutPanel1.ColumnCount = Column;
            for (int i = 0; i < Row; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            }
            for (int i = 0; i < 16; i++)
            {
                var button = new Button();
                button.Text = Convert.ToString(randomarray[i]);
                button.Name = string.Format("Button_{0}", (randomarray[i]));
                button.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(button);
                button.Click += new System.EventHandler(button_Click);
            }            
        }
        public static int[] random(int[] array)
        {
            var random = new Random();

            int[] randomArray = Enumerable.Range(1, array.Length).OrderBy(x => random.Next()).ToArray();
            return randomArray;
        }
        private void button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
