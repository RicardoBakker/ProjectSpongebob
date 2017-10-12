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
                button.Text = "Flip";
                button.Name = string.Format("Button_{0}", (i + 1));
                button.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(button);
                button.Click += new System.EventHandler(button_Click);
            }            
        }

        private void button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
