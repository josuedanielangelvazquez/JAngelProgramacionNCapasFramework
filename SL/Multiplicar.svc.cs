using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Multiplicar" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Multiplicar.svc or Multiplicar.svc.cs at the Solution Explorer and start debugging.
    public class Multiplicar : IMultiplicar
    {
        public void DoWork()
        {
        }
        public int Multiplica(int dato1, int dato2)
        {
           
            return  dato1 * dato2;
        }
    }
}
