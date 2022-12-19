using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "sumar" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select sumar.svc or sumar.svc.cs at the Solution Explorer and start debugging.
    public class sumar : Isumar
    {
        public void DoWork()
        {
        }

        public int Suma(int Dato1, int Dato2)
        {
            return Dato1 + Dato2;
        }
    
    }
}
