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


namespace intentoTp2
{
    public partial class frmAgregarCM : Form
    {
        String opcion;

        public frmAgregarCM(int opc)
        {
            InitializeComponent();

            if (opc==1)
            {
                opcion="CATEGORIAS";
                Text = opcion;
            }
            else
            {
                opcion = "MARCAS";
                Text = opcion;
            }
        }

        //METODO PARA EL BOTON AGREGAR --> 100%
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String texto;

            texto = txtCaja.Text;

            if (texto.Equals(""))
            {
                MessageBox.Show("Nombre requerido");
            }
            else
            {
                if (opcion.Equals("CATEGORIAS"))
                {
                    NegocioCategoria negoc = new NegocioCategoria();

                    if (negoc.existeCategoria(texto) == false)
                    {
                        negoc.agregarCategoria(texto);
                        MessageBox.Show("Categoria agregada correctamente");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Categoria ya existente;");
                        txtCaja.Text = "";
                    }
                }
                else
                {
                    NegocioMarca negom = new NegocioMarca();

                    if (negom.existeMarca(texto) == false)
                    {
                        negom.agregarMarca(texto);
                        MessageBox.Show("Marca agregada correctamente");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Marca ya existente");
                        txtCaja.Text = "";
                    }
                }
            }
        }

        //METODO PARA EL BOTON CANCELAR --> 100%
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
