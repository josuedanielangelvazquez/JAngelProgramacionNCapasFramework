using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Dividir" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Dividir.svc or Dividir.svc.cs at the Solution Explorer and start debugging.
    public class Dividir : IDividir
    {
        public void DoWork()
        {
        }

       public float divide(int dato1, int dato2)
        {
            return dato1 / dato2;
        }
    }
}
