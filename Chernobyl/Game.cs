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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elegir frm21 = new Elegir();

            frm21.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
