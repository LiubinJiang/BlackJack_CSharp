using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assign_final
{
    public partial class aNewPlayer : Form
    {
        private string playername = "init";

        public aNewPlayer()
        {
            InitializeComponent();
        }

        private void begin_btn_Click(object sender, EventArgs e)
        {

            string head = head_list.CheckedItems.ToString();
            MessageBox.Show(head);
            
            
            playername = name_text.Text;
            
            this.Close();
            GameForm gf = new GameForm(playername);
            gf.Show();
        }
    }
}
