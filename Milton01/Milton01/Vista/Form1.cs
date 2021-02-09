using Milton01.Dominio;
using Milton01.Negocio;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milton01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsNegocio logica = new clsNegocio();
            login dominio = new login();

            dominio.Usuario = txtUsuario.Text;
            dominio.Paswork = txtContraseña.Text;

           Boolean OK= logica.acceder(dominio);

            if (OK == true)
            {
                MessageBox.Show("Acceso Consedido");

            }
            else {
                MessageBox.Show("Acceso NO Consedido");
            }
             
            
                    





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();

        }
    }
}
