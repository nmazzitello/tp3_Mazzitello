using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intentoTp2
{
    public partial class frmPrincipal : Form
    {
        public static int opc; //indica que boton de la pantalla principal se presiono

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //EVENTO CUANDO TOCA LA X PARA SALIR --> 100%
        private void btnModificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //metodo que cierra la app
        }

        //EVENTO PARA EL PRIMER BOTON- VER ARTICULOS --> 100%
        private void btnVer_Click(object sender, EventArgs e)
        {
            opc = 1;
            frmBusqueda bus = new frmBusqueda();
            bus.ShowDialog();
        }

        //EVENTO PARA EL SEGUNDO BOTON- MODIFICAR -->100%
        private void btnModifi_Click(object sender, EventArgs e)
        {
            opc = 2;
            frmBusqueda fb = new frmBusqueda();
            fb.ShowDialog();
        }

        //EVENTO PARA EL TERCER BOTON- AGREGAR --> 100%
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            opc = 3;
            frmProducto fp = new frmProducto();
            fp.ShowDialog();
        }

        //EVENTO PARA EL CUARTO BOTON- ELIMINAR PRODUCTO --> 100%
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            opc = 4;
            frmBusqueda bus = new frmBusqueda();
            bus.ShowDialog();
        }

        //EVENTO PARA EL QUINTO BOTON- SALIR --> 100%
        private void btnSalir_Click(object sender, EventArgs e)
        {
            opc = 5;
            var res= MessageBox.Show(" ¿Seguro desea salir del programa?", "AVISO", MessageBoxButtons.YesNo);

            if(res== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
