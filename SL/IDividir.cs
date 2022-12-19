using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDividir" in both code and config file together.
    [ServiceContract]
    public interface IDividir
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        float divide(int dato1, int dato2);
    }
}
