using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Web
{
    public partial class pruebaDos : System.Web.UI.Page
    {
        public List<Articulo> listaArticulo { get; set; }
        public Carrito carri = new Carrito();

        protected void Page_Load(object sender, EventArgs e)
        {
            //carga los datos en la gilla para mostrar todos los articulos
            //dgvDatos.DataSource = listaArticulo;
            //dgvDatos.DataBind();

            if (Session[Session.SessionID + "carrito"] != null)
            {
                carri = (Carrito)Session[Session.SessionID + "carrito"];
            }

            if (!IsPostBack)  //si es la primera vez que carga la pagina
            {
                NegocioArticulo na = new NegocioArticulo();
                listaArticulo = na.listar();
                repetidor.DataSource = listaArticulo;
                repetidor.DataBind();
            }
        }

        //EVENTO DEL BOTON IR AL CARRITO, REDIRECCIONA A LA OTRA PAGINA--> 100%
        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("pantallaDos.aspx");
        }

        //EVENTO DEL BOTON AGREGAR AL CARRITO --> 100%
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negoa = new NegocioArticulo();
            String codArt= ((Button)sender).CommandArgument;
            Articulo arti = new Articulo();

            arti = negoa.traerArtPorCod(codArt);
            carri.listaCarrito.Add(arti);
            carri.listaCarrito.Count();

            Session.Add(Session.SessionID+"carrito", carri);
        }

        //EVENTO PARA EL BOTON BUSCAR POR NOMBRE --> 100%
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negoa = new NegocioArticulo();
            String nomBus = txtBuscar.Text;

            if(!nomBus.Equals(""))
            {
                List<Articulo> buscados = negoa.traerArtPorNom(nomBus);
                if(buscados!=null)
                {
                    repetidor.DataSource= buscados;
                    repetidor.DataBind();
                }
            }
        }

        //EVENTO PARA REINICIAR LOS PRODUCTOS --> 100%
        protected void btnReiniciar_Click(object sender, EventArgs e)
        {
            NegocioArticulo na = new NegocioArticulo();
            listaArticulo = na.listar();
            repetidor.DataSource = listaArticulo;
            repetidor.DataBind();

            txtBuscar.Text = "";
        }
    }
}