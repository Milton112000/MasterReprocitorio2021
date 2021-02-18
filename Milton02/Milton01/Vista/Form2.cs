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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void misionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void visionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInfromacion fr = new  FrmInfromacion();
            fr.Show();
        }

        private void misionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmImformacion2 fr = new FrmImformacion2();
            fr.Show();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualDeUsuario fr = new FrmListaVisualDeUsuario();
               
                fr.Show();
        }
    }
}
