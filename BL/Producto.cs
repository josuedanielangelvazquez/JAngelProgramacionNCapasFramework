using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {
       static public ML.Result GETALL()
        {
            ML.Result result = new ML.Result(); 
            try {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                { 
                var query = context.GetAllProducto().ToList();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var objProducto in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = objProducto.IdProducto;
                            producto.Nombre = objProducto.Nombre;
                            producto.PrecioUnitario = objProducto.PrecioUnitario;
                            producto.Stock = objProducto.Stock;
                            producto.IdProveedor = new ML.Proveedor();
                            producto.IdProveedor.IdProveedor = objProducto.IdProveedor;
                            producto.IdProveedor.Nombre = objProducto.Proveedor;
                            producto.IdProveedor.Telefono = objProducto.Telefono;
                            producto.IdDepartamento = new ML.Departamento();
                            producto.IdDepartamento.Iddepartamento = objProducto.IdDepartamento;
                            producto.IdDepartamento.Nombre = objProducto.Departamento;
                            producto.IdDepartamento.IdArea = new ML.Area();
                            producto.IdDepartamento.IdArea.IdArea = objProducto.IdArea;
                            producto.IdDepartamento.IdArea.Nombre = objProducto.Area;
                            producto.Descripcion = objProducto.Descripcion;
                            

                            result.Objects.Add(producto);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No Contienen registros";
                    }
                }
                  
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        static public ML.Result GETBYID(int ProductoId)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                {
                    var objProducto = context.GetByIdProducto(ProductoId).First();
                    result.Object = new List<object>();
                    if (objProducto != null)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.IdProducto = objProducto.IdProducto;
                        producto.Nombre = objProducto.Nombre;
                        producto.PrecioUnitario = objProducto.PrecioUnitario;
                        producto.Stock = objProducto.Stock;
                        producto.IdProveedor = new ML.Proveedor();
                        producto.IdProveedor.IdProveedor = objProducto.IdProveedor;
                        producto.IdProveedor.Nombre = objProducto.Proveedor;
                        producto.IdProveedor.Telefono = objProducto.Telefono;
                        producto.IdDepartamento = new ML.Departamento();
                        producto.IdDepartamento.Iddepartamento = objProducto.IdDepartamento;
                        producto.IdDepartamento.Nombre = objProducto.Departamento;
                        producto.IdDepartamento.IdArea = new ML.Area();
                        producto.IdDepartamento.IdArea.IdArea = objProducto.IdArea;
                        producto.IdDepartamento.IdArea.Nombre = objProducto.Area;
                        producto.Descripcion = objProducto.Descripcion;

                        result.Object = producto;

                        result.Correct = true;
                    }
                }
                    result.Correct = true;

            }
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMessage = ex.Message;
                result.Ex= ex;
            }
            return result;
        }
        static public ML.Result ADD(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                {

                    var query = context.AddProducto(producto.Nombre, producto.PrecioUnitario, producto.Stock, producto.ProveedorId, producto.DepartamentoId, producto.Descripcion);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al insertar eln producto";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        static public ML.Result UPDATE(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                {
                    var query = context.ProductoUpdate(producto.IdProducto, producto.Nombre, producto.PrecioUnitario, producto.Stock, producto.ProveedorId, producto.DepartamentoId, producto.Descripcion);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al actualizar el usuario";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        static public ML.Result DELETE(int ProductoId)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                {
                    var query = context.DeleteProducto(ProductoId);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al actualizar el usuario";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
    }
}
