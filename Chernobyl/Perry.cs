using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chernobyl
{
    public partial class Perry : Form
    {
        public Perry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegir frm26 = new Elegir();

            frm26.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
