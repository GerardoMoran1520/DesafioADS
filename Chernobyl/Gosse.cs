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
    public partial class Gosse: Form
    {
        public Gosse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegir frm22 = new Elegir();

            frm22.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
