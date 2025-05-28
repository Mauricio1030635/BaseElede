using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EledeRepaso.Core.Models
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string IdRamo { get; set; }
        public bool? Activo { get; set; }
        public string Esquema { get; set; }
    }
}
