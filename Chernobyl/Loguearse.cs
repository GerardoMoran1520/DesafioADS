using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Chernobyl
{
    public partial class Loguearse : Form
    {
        public Loguearse()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            //TIEMPO DE CARGA DE ESPERA DE LA SPLASH SCREEN(15 SEG)

            Thread.Sleep(15000);
            this.Hide();
            InitializeComponent();

            t.Abort();

        }
        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        string cc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\Downloads\DASVisual\Chernobyl\Base de datos\Usuarios.mdf;Integrated Security=True";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="" || txtContrasena.Text=="")
            {
                MessageBox.Show("Por favor escriba el usuario Y/O la contraseña");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cc);
                SqlCommand cmd = new SqlCommand("Select * from Usuario where Usuario=@usuario and Contrasena=@contrasena", con);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int contar = ds.Tables[0].Rows.Count;
                if( contar == 1)
                {
                    MessageBox.Show("Ingreso Exitoso");
                    this.Hide();
                    Elegir frm = new Elegir();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectas, o no sé encuentra registrado");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
