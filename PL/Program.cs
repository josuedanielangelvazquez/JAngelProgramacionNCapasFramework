using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validacion;

            Console.WriteLine("1 = Usuario ||  2 = Producto");
            validacion = int.Parse(Console.ReadLine());
            if(validacion == 1) {
                Console.WriteLine("1 = Insertar  ||  2 = GetAll  ||  3 = GetById  ||  4 = Update  ||  5 = Delete");
                validacion = int.Parse(Console.ReadLine());

                if (validacion == 1)
                    PL.Usuario.Add();
                if (validacion == 2)
                    PL.Usuario.GetAll();
                if (validacion == 3)
                    PL.Usuario.GetById();
                if (validacion == 4)
                    PL.Usuario.Update();
                if (validacion == 5)
                    PL.Usuario.Delete();

            }
            else
            {
                Console.WriteLine("1 = Insertar  ||  2 = GetAll  ||  3 = GetById  ||  4 = Update  ||  5 = Delete");
                validacion = int.Parse(Console.ReadLine());
                if (validacion == 1)
                    PL.Producto.ADD();
                if (validacion == 2)
                    PL.Producto.GETALL();
                if(validacion == 3)
                    PL.Producto.GETBYID();
                if(validacion == 4)
                    PL.Producto.UPDATE();
                if (validacion == 5)
                    PL.Producto.DELETE();
            }
        }
    }
}
