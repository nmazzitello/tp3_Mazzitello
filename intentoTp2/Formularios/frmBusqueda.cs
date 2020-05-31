using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace intentoTp2
{
    public partial class frmBusqueda : Form
    {
        int opc;
        int num;
        public static String codigoDelProducto;

        public frmBusqueda()
        {
            InitializeComponent();
            opc = frmPrincipal.opc;

            if(opc==1)
            {
                Text = "VER ARTICULOS";
            }
            else if(opc==2)
            {
                Text = "MODIFICAR ARTICULOS";
            }
            else
            {
               Text ="ELIMINAR ARTICULOS";
            }
        }

        //EVENTO PARA EL BOTON BUSCAR --> %
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String bus = txtBuscar.Text;

            if (bus.Equals(""))
            {
                MessageBox.Show("Ingrese el articulo que desea buscar");
            }
            else
            {
                NegocioArticulo negoa = new NegocioArticulo();
                Articulo art = new Articulo();

                if (rbCodigo.Checked)
                {
                    art = negoa.traerArtPorCod(bus);

                    if(art==null)
                    {
                         MessageBox.Show("El articulo no existe");
                    }
                    else
                    {
                        frmProducto fp = new frmProducto(art);
                        codigoDelProducto = art.codigo;
                        this.Dispose();
                        fp.ShowDialog();
                    }
                }
                else if (rbNombre.Checked)
                {
                    List<Articulo> listaArt = new List<Articulo>();

                    listaArt = negoa.traerArtPorNom(bus);

                    if(listaArt==null)
                    {
                        MessageBox.Show("El articulo no existe");
                    }
                    else
                    {
                        dgvArticulos.DataSource = listaArt;
                    }
                }
                else if( rbCategoria.Checked)
                {
                    List<Articulo> listaArt = new List<Articulo>();

                    listaArt = negoa.traerArtPorCat(bus);

                    if (listaArt == null)
                    {
                        MessageBox.Show("El articulo no existe");
                    }
                    else
                    {
                        dgvArticulos.DataSource = listaArt;
                    }
                }
                else
                {
                    List<Articulo> listaArt = new List<Articulo>();

                    listaArt = negoa.traerArtPorMar(bus);

                    if (listaArt == null)
                    {
                        MessageBox.Show("El articulo no existe");
                    }
                    else
                    {
                        dgvArticulos.DataSource = listaArt;
                    }
                }
            }
        }


        //METODO QUE CARGA EL GRIDVIEW CON LOS ARTICULOS --> 100%
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            NegocioArticulo negoa = new NegocioArticulo();
            dgvArticulos.DataSource = negoa.listar();
           // dgvArticulos.Columns[4].Visible = false;
            //dgvArticulos.Columns[6].Visible = false;
        }

        //METODO QUE MUESTRA EL ARTICULO SELECCIONADO DEL GRIDVIEW --> 100%
        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            NegocioArticulo negoa = new NegocioArticulo();
            Articulo art = new Articulo();

            art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            art= negoa.traerArtPorCod(art.codigo);
            
            frmProducto fp = new frmProducto(art);
            codigoDelProducto = art.codigo;
            this.Dispose();
            fp.ShowDialog();
        }
    }
}
