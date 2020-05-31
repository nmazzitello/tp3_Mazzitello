using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public List<Articulo> listaCarrito { get; set; }

        public Carrito()
        {
            listaCarrito = new List<Articulo>();
        }
    }
}
