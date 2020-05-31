using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace intentoTp2
{
    public partial class frmProducto : Form
    {
        String codigo;
        String nombre;
        String imagen;
        String precio;
        float pre;  //va a almacenar la conversion del String precio
        String descripcion;
        int cat;    //va a almacenar el id de la categoria seleccionada
        int mar;    //va a almacenar el id de marca seleccionada

        int opc;    //guarda en que opcion se ingreso en frmPrincipal. Si es 1, editable=true

        //CONSTRUCTOR VACIO QUE SE UTILIZA PARA AGREGAR UN ARTICULO SOLAMENTE --> 100 %
        public frmProducto()
        {
            InitializeComponent();

            NegocioCategoria negoc = new NegocioCategoria();
            NegocioMarca negom = new NegocioMarca();

            List<Categoria> list = negoc.traerCategorias();
            cmbCategoria.DataSource = negoc.traerCategorias();
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "categoria";

            List<Marca> list2 = negom.traerMarca();
            cmbMarca.DataSource = list2;
            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "marca";
        }

        //CONSTRUCTOR QUE SE UNA PARA CARGARLE LOS CAMPOS DE UN ARTICULO PARA CARGAR LOS CAMPOS DE TEXTO --> 
        public frmProducto(Articulo art)
        {
            InitializeComponent();
            opc = frmPrincipal.opc;
            String codAct;
            codAct = art.codigo;
            NegocioCategoria negoc = new NegocioCategoria();
            NegocioMarca negom = new NegocioMarca();

            List<Categoria> list = negoc.traerCategorias();
            cmbCategoria.DataSource = negoc.traerCategorias();
            cmbCategoria.SelectedIndex = art.categoria.id -1;

            NegocioMarca negMarca = new NegocioMarca();
            cmbMarca.DataSource = negMarca.traerMarca();
            cmbMarca.SelectedIndex = art.marca.id - 1;

            txtCodigo.Text = art.codigo;
            txtNombre.Text = art.nombre;
            txtImagen.Text = art.imagen;

            try
            {
                picImagen.Load(art.imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la foto");
            }

            txtPrecio.Text = art.precio.ToString();
            txtDescripcion.Text = art.descripcion;

            if (opc == 1 || opc == 4)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtImagen.Enabled = false;
                cmbCategoria.Enabled = false;
                cmbMarca.Enabled = false;
                txtPrecio.Enabled = false;
                txtDescripcion.Enabled = false;
                btnAceptar.Visible = false;
                btnAgCat.Enabled = false;
                btnAgMar.Enabled = false;

                if(opc==4)
                {
                    btnEliMod.Visible = true;
                    btnCancelar.Visible = true;
                }
            }
            else
            {
                cmbCategoria.DataSource = negoc.traerCategorias();
                cmbCategoria.SelectedIndex = art.categoria.id - 1;

                cmbMarca.DataSource = negMarca.traerMarca();
                cmbMarca.SelectedIndex = art.marca.id - 1;

                btnAceptar.Visible = false;
                btnEliMod.Visible = true;
                btnEliMod.Text = "MODIFICAR";
                btnCancelar.Visible = true;
            }
        }

        //EVENTO PARA EL BOTON ACEPTAR --> 100%
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negoa = new NegocioArticulo();
           
            codigo = txtCodigo.Text;
            nombre = txtNombre.Text;
            imagen = txtImagen.Text;
            precio = txtPrecio.Text;
            cat = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());   //guarda el id de la opcion elegida --> 100%
            mar = Convert.ToInt32(cmbMarca.SelectedValue.ToString());       //guarda el id de la opcion elegida --> 100%
            descripcion = txtDescripcion.Text;                                                              

            if (!codigo.Equals("") && !nombre.Equals("") && !imagen.Equals("") && !precio.Equals("") && !descripcion.Equals("") )
            {
                if (negoa.existeArticulo(codigo) == false)
                {
                    pre = float.Parse(precio);
                    negoa.guardarArticulo(codigo, nombre, descripcion, mar, cat, imagen, pre);

                    MessageBox.Show("Artículo agregado con exito");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("El código de artículo ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para continuar");
            }
        }

        //METODO PARA LIMPIAR TODOS LOS CAMPOS --> 100% 
        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtImagen.Text = "";
            picImagen.Image = null;
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
        }

        //METODO QUE PERMITA SOLO NUMEROS y LA TECLA DE BORRAR --> 100%
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //METODO QUE PERMITE SOLO NUMEROS Y LA TECLA DE BORRAR --> 100%
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //EVENTO QUE CARGA LA IMAGEN EN EL PIC --> 100%
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!txtImagen.Text.Equals(""))
                {
                    picImagen.Load(txtImagen.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la foto");
            }
        }

        //EVENTO AL PRESIONAR EL BOTON AGREGAR CATEGORIA y ACTUALIZA LA BASE DE DATOS AL FINALIZAR --> 100%
        private void btnAgCat_Click(object sender, EventArgs e)
        {
            int opci;
            opci = 1;

            frmAgregarCM ac = new frmAgregarCM(opci);
            ac.ShowDialog();

            NegocioCategoria negoc = new NegocioCategoria();
            List<Categoria> list = negoc.traerCategorias();
            cmbCategoria.DataSource = list;
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "categoria";

        }

        //EVENTO AL PRESIONAR EL BOTON AGREGAR MARCA Y ACTUALIZA LA BASE DE DATOS AL FINALIZAR --> 100%
        private void btnAgMar_Click(object sender, EventArgs e)
        {
            int opci;
            opci = 2;

            frmAgregarCM ac = new frmAgregarCM(opci);
            ac.ShowDialog();

            NegocioMarca negom = new NegocioMarca();
            List<Marca> list2 = negom.traerMarca();
            cmbMarca.DataSource = list2;
            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "marca";
        }

        //EVENTO AL PRESIONAR EL BOTON ELIMINAR/MODIFICAR --> 100%
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negoa = new NegocioArticulo();
            String cood;
            cood = frmBusqueda.codigoDelProducto;   //trae el codigo del producto que se uso para la busqueda

            if (opc == 4)
            {
                var res = MessageBox.Show("¿Está seguro desea eliminar este artículo?", "AVISO", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    negoa.eliminarArt(cood);
                    MessageBox.Show("Artículo eliminado exitosamente");
                    Dispose();
                }
            }
            if(opc==2)
            {
                var res = MessageBox.Show("¿Está seguro desea modificar este artículo?", "AVISO", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    float pre;

                    codigo = txtCodigo.Text;
                    nombre = txtNombre.Text;

                    if (!codigo.Equals("") && !nombre.Equals(""))
                    {
                        if (negoa.existeArticulo(codigo) == false || codigo.Equals(cood))
                        {
                            imagen = txtImagen.Text;
                            precio = txtPrecio.Text;
                            cat = Convert.ToInt32(cmbCategoria.SelectedIndex + 1);   //guarda el id de la opcion elegida --> 100%
                            mar = Convert.ToInt32(cmbMarca.SelectedIndex + 1);      //guarda el id de la opcion elegida --> 100%
                            descripcion = txtDescripcion.Text;

                            if (precio.Equals(""))
                            {
                                pre = 0;
                            }
                            else
                            {
                                pre = float.Parse(precio);
                            }
                            negoa.modificarArt(cood, codigo, nombre, descripcion, mar, cat, imagen, pre);
                            MessageBox.Show("Artículo modificado con exito");
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("El código de artículo ya existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre y código son necesarios para continuar");
                    }
                }
            }
        }

        //EVENTO PARA EL BOTON CANCELAR --> 100%
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
