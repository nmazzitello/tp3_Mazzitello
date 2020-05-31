using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

//FALTA:        *ELIMINAR ARTICULO
//              *BOTON CONFIRMAR COMPRA

namespace Web
{
    public partial class pantallaDos : System.Web.UI.Page
    {
        public Carrito carrito2 = new Carrito();
        int cantItemsCarrito;
        float total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            carrito2 = (Carrito)Session[Session.SessionID + "carrito"];
            

            if (!IsPostBack)    //si es la primera vez que carga la pagina
            {
                if (carrito2!=null)
                {
                    repeaterCarri.DataSource = carrito2.listaCarrito;
                    repeaterCarri.DataBind();
                    cantItemsCarrito += carrito2.listaCarrito.Count;

                    for (int x = 0; x < cantItemsCarrito; x++)
                    {
                        total += carrito2.listaCarrito[x].precio;
                    }

                    lblTotal.Text = "EL TOTAL A PAGAR ES $" + total;
                }
            }
        }

        //EVENTO PARA SEGUIR AGREGANDO COSAS AL CARRITO --> 100%
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        //EVENTO QUE FINALIZA LA CARGA DE ARTICULOS AL CARRITO --> 0%
        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("finalizada.aspx");
        }

        //EVENTO PARA ELIMINAR ARTICULO DEL CARRITO --> 
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //List<Articulo> nuevaLista = carrito2.listaCarrito;
            carrito2 = (Carrito)Session[Session.SessionID + "carrito"];
            String codArt = ((Button)sender).CommandArgument;
            carrito2.listaCarrito.RemoveAt(carrito2.listaCarrito.FindIndex(x => x.codigo == codArt));
            Session.Add(Session.SessionID + "carrito", carrito2);
        }
    }
}