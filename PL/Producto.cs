using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public  class Producto
    {
        static public void GETALL()
        {
            ML.Result result = BL.Producto.GETALL();

            foreach(ML.Producto producto in result.Objects)
            {
                Console.WriteLine("El id de producto es:" + producto.IdProducto);
                Console.WriteLine("El producto es:" + producto.Nombre);
                Console.WriteLine("El producto es:" + producto.PrecioUnitario);
                Console.WriteLine("El Stock es:" + producto.Stock);
                Console.WriteLine("El Id de Proveedor es:" + producto.IdProveedor.IdProveedor);
                Console.WriteLine("El Proveedor es:" + producto.IdProveedor.Nombre);
                Console.WriteLine("El Proveedor es:" + producto.IdProveedor.Telefono);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.Iddepartamento);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.Nombre);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.IdArea.IdArea);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.IdArea.Nombre);
                Console.WriteLine("Descripcion: " + producto.Descripcion);
            }


        }
        static public void GETBYID()
        {
            Console.WriteLine("Ingrese el Id del Producto");
                int ProductoId = int.Parse(Console.ReadLine());
            ML.Result result = BL.Producto.GETBYID(ProductoId);

            if (result.Correct)
            {
                ML.Producto producto = (ML.Producto)result.Object;
                Console.WriteLine("El id de producto es:" + producto.IdProducto);
                Console.WriteLine("El producto es:" + producto.Nombre);
                Console.WriteLine("El producto es:" + producto.PrecioUnitario);
                Console.WriteLine("El Stock es:" + producto.Stock);
                Console.WriteLine("El Id de Proveedor es:" + producto.IdProveedor.IdProveedor);
                Console.WriteLine("El Proveedor es:" + producto.IdProveedor.Nombre);
                Console.WriteLine("El Proveedor es:" + producto.IdProveedor.Telefono);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.Iddepartamento);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.Nombre);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.IdArea.IdArea);
                Console.WriteLine("El Proveedor es:" + producto.IdDepartamento.IdArea.Nombre);
                Console.WriteLine("Descripcion: " + producto.Descripcion);

            }
            else
            {
                Console.WriteLine("Ocurrio un error" + result.ErrorMessage);
            }
            Console.ReadLine();
        }
        static public void ADD()
        {
            ML.Producto producto = new ML.Producto();
            Console.WriteLine("Ingresa el Nombre del Porducto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el Precio del Producto");
            producto.PrecioUnitario = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el el stock");
            producto.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Id del Proveedor");
            producto.ProveedorId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Id del Departamento al que pertenece");
            producto.DepartamentoId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa una pequeña Descripcion");
            producto.Descripcion = Console.ReadLine();
            ML.Result result = BL.Producto.ADD(producto);
            if (result.Correct)
            {
                Console.WriteLine("usuario agregado");
            }
            else
            {
                Console.WriteLine("usuario no agregado");
            }

        }
        static public void UPDATE()
        {
            ML.Producto producto = new ML.Producto();
            Console.WriteLine("Ingresa el Id Del Producto");
            producto.IdProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Nombre del Porducto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el Precio del Producto");
            producto.PrecioUnitario = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el el stock");
            producto.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Id del Proveedor");
            producto.ProveedorId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Id del Departamento al que pertenece");
            producto.DepartamentoId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa una pequeña Descripcion");
            producto.Descripcion = Console.ReadLine();
            ML.Result result = BL.Producto.ADD(producto);
            if (result.Correct)
            {
                Console.WriteLine("usuario agregado");
            }
            else
            {
                Console.WriteLine("usuario no agregado");
            }
        }
        static public void DELETE()
        {
            Console.WriteLine("Ingrese el Id del Producto a eliminar");
            int ProductoId = int.Parse(Console.ReadLine());
            // ML.Result result =  BL.Usuario.DELETE(idusuario);
            //  ML.Result result = BL.Usuario.DELETESP(idusuario);
            ML.Result result = BL.Producto.DELETE(ProductoId);
            // ML.Result result = BL.Usuario.DELETELINQ(idusuario);
            if (result.Correct)
            {
                Console.WriteLine("Uusario Eliminado");
            }
            else
            {
                Console.WriteLine("USUARIO no eliminado");
            }
        }
    }
}
