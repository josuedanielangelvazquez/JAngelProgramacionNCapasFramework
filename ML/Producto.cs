using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public ML.Proveedor IdProveedor { get; set; }
        public int ProveedorId { get; set; }
        public ML.Departamento IdDepartamento { get; set; }
        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
    }
}
