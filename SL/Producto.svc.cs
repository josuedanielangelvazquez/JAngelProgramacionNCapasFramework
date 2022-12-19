using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Producto" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Producto.svc or Producto.svc.cs at the Solution Explorer and start debugging.
    public class Producto : IProducto
    {
   public SL.Result GETALL()
        {
         ML.Result result = BL.Producto.GETALL(); 

            return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects};
        }

    public SL.Result GETBYID(int producto)
        {
            ML.Result result = BL.Producto.GETBYID(producto);
            return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
    public SL.Result ADD(ML.Producto producto)
        {
            ML.Result result = BL.Producto.ADD(producto);
            return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };


        }
    public SL.Result UPDATE(ML.Producto producto)
        {
            ML.Result result = BL.Producto.UPDATE(producto);
            return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };

        }

    public SL.Result DELETE(int producto)
        {
            ML.Result result = BL.Producto.DELETE(producto);
             return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };

        }

    }
}
