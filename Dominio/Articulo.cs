using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String imagen { get; set; }
        public float precio { get; set; }
        public Categoria categoria { get; set; }
        public Marca marca { get; set; }
        public String  descripcion { get; set; }
    }

   
}
