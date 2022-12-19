using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProducto" in both code and config file together.
    [ServiceContract]
    public interface IProducto
    {
        
        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))]
        SL.Result GETALL();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))]
        SL.Result GETBYID(int producto);

        [OperationContract]
        SL.Result ADD(ML.Producto producto);
        [OperationContract]
        SL.Result UPDATE(ML.Producto producto);
        [OperationContract]
        SL.Result DELETE(int producto);

    }
}
