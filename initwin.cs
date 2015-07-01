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
    public partial class initwin : Form
    {
        public initwin()
        {
            InitializeComponent();
        }

        private void initwin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            aNewPlayer np = new aNewPlayer();
            np.Show();
        }
    }
}
