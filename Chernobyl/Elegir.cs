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
    public partial class Elegir : Form
    {
        public Elegir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game frm10 = new Game();

            frm10.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Cherno frm11 = new Cherno();

            frm11.Show();
            this.Hide();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marvel frm12 = new Marvel();

            frm12.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Potter frm13 = new Potter();

            frm13.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gosse frm14 = new Gosse();

            frm14.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Perry frm15 = new Perry();

            frm15.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pytho frm16 = new Pytho();

            frm16.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
           Ja frm17 = new Ja();

            frm17.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            JaScript frm18 = new JaScript();

            frm18.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
