using Milton01.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milton01.Vista
{
    public partial class FrmListaVisualDeUsuario : Form
    {
        public FrmListaVisualDeUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaVisualDeUsuario_Load(object sender, EventArgs e)
        {
            ClsListasUsuario cls = new ClsListasUsuario();

            foreach (var iteracion in cls.user) {
                dataGridView1.Rows.Add(iteracion.ToString()); // se llama la tabla y filas
            
            }

        }
    }
}
