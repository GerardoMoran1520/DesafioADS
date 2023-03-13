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
    public partial class Marvel : Form
    {
        public Marvel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegir frm25 = new Elegir();

            frm25.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
