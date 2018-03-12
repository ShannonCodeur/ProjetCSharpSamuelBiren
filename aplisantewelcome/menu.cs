using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplisantewelcome
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            Application.Run(new menu());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serviceAccueilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            Application.Run(new menu());
        }
    }
}
