using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        static public void Add()
        {


            ML.Direccion usuario = new ML.Direccion();
            usuario.IdUsuario = new ML.Usuario();
            Console.WriteLine("Ingrese los datos del usuario");
            Console.WriteLine("INgrese el Nombre de Usuario ");
            usuario.IdUsuario.UserName = Console.ReadLine();
            Console.WriteLine("INgrese el nombre: ");
            usuario.IdUsuario.Nombre = Console.ReadLine();
            Console.WriteLine("INgrese el ApellidoPaterno: ");
            usuario.IdUsuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("INgrese el ApellidoMaterno ");
            usuario.IdUsuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("INgrese el Email ");
            usuario.IdUsuario.Email = Console.ReadLine();
            Console.WriteLine("INgrese el Password ");
            usuario.IdUsuario.Password = Console.ReadLine();
            Console.WriteLine("INgrese la Fecha de Nacimiento ");
            usuario.IdUsuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("INgrese el Sexo ");
            usuario.IdUsuario.Sexo = Console.ReadLine();
            Console.WriteLine("INgrese el Telefono ");
            usuario.IdUsuario.Telefono = Console.ReadLine();
            Console.WriteLine("INgrese el Celular ");
            usuario.IdUsuario.Celular = Console.ReadLine();
            Console.WriteLine("INgrese el Curp ");
            usuario.IdUsuario.Curp = Console.ReadLine();
            Console.WriteLine("Ingrese El tipo de Rol");
            usuario.IdUsuario.RolId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Calle");
            usuario.Calle = Console.ReadLine();
            Console.WriteLine("Ingrese El Numero Interior de su Domicilio");
            usuario.NumeroInterior = Console.ReadLine();
            Console.WriteLine("Ingrese El NUmero Exterior de su Domicilio");
            usuario.NumeroExterior = Console.ReadLine();
            Console.WriteLine("Ingrese El Id de la Colonia");
            usuario.ColoniaId = int.Parse(Console.ReadLine());
             



            // ML.Result result = BL.Usuario.AddSP(usuario);
            // ML.Result result = BL.Usuario.AddEF(usuario);
            //ML.Result result = BL.Usuario.ADDLINQ(usuario);
            ML.Result result = BL.Usuario.AddEF(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("usuario agregado");
                }
                else
                {
                    Console.WriteLine("usuario no agregado");
                }


            }
          
        static public void Delete()
        {
            Console.WriteLine("Ingrese el Id del usuario a eliminar");
            int idusuario = int.Parse(Console.ReadLine());
            // ML.Result result =  BL.Usuario.DELETE(idusuario);
            //  ML.Result result = BL.Usuario.DELETESP(idusuario);
            ML.Result result = BL.Usuario.DELETEEF(idusuario);
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
        static public void Update()
        {

            ML.Direccion usuario = new ML.Direccion();
            usuario.IdUsuario = new ML.Usuario();
            Console.WriteLine("Ingrese los datos del usuario");
            Console.WriteLine("Ingrese el Id del Usuario");
            usuario.IdUsuario.IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("INgrese el Nombre de Usuario ");
            usuario.IdUsuario.UserName = Console.ReadLine();
            Console.WriteLine("INgrese el nombre: ");
            usuario.IdUsuario.Nombre = Console.ReadLine();
            Console.WriteLine("INgrese el ApellidoPaterno: ");
            usuario.IdUsuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("INgrese el ApellidoMaterno ");
            usuario.IdUsuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("INgrese el Email ");
            usuario.IdUsuario.Email = Console.ReadLine();
            Console.WriteLine("INgrese el Password ");
            usuario.IdUsuario.Password = Console.ReadLine();
            Console.WriteLine("INgrese la Fecha de Nacimiento ");
            usuario.IdUsuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("INgrese el Sexo ");
            usuario.IdUsuario.Sexo = Console.ReadLine();
            Console.WriteLine("INgrese el Telefono ");
            usuario.IdUsuario.Telefono = Console.ReadLine();
            Console.WriteLine("INgrese el Celular ");
            usuario.IdUsuario.Celular = Console.ReadLine();
            Console.WriteLine("INgrese el Curp ");
            usuario.IdUsuario.Curp = Console.ReadLine();
            Console.WriteLine("Ingrese El tipo de Rol");
            usuario.IdUsuario.RolId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Calle");
            usuario.Calle = Console.ReadLine();
            Console.WriteLine("Ingrese El Numero Interior de su Domicilio");
            usuario.NumeroInterior = Console.ReadLine();
            Console.WriteLine("Ingrese El NUmero Exterior de su Domicilio");
            usuario.NumeroExterior = Console.ReadLine();
            Console.WriteLine("Ingrese El Id de la Colonia");
            usuario.ColoniaId = int.Parse(Console.ReadLine());


            // ML.Result result =  BL.Usuario.UPDATE(usuario);
            //  ML.Result result = BL.Usuario.UPDATESP(usuario);
            ML.Result result = BL.Usuario.UpdateEF(usuario);
            //ML.Result result = BL.Usuario.UPDATELINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario Actualizado");
            }
            else
            {
                Console.WriteLine("Usuario No Actualizado");
            }
        }
        static public void GetAll()
        {
            //ML.Result result1 = BL.Usuario.GetSP();
            // ML.Result result = BL.Usuario.Read();
            // ML.Result result = BL.Usuario.GetAllEF();
            // ML.Result result = BL.Usuario.GETALLDEF(); 
            ML.Result result = BL.Usuario.GETALLLINQINNER();
            

            foreach (ML.Direccion usuario in result.Objects)
            {
                Console.WriteLine("Idusuario es: " + usuario.IdUsuario.IdUsuario);
                Console.WriteLine("UserName es: " + usuario.IdUsuario.UserName);
                Console.WriteLine("Nombre es:" + usuario.IdUsuario.Nombre);
                Console.WriteLine("El Apellido Paterno es: " + usuario.IdUsuario.ApellidoPaterno);
                Console.WriteLine("El Apellido Materno es " + usuario.IdUsuario.ApellidoMaterno);
                Console.WriteLine("El Email es: " + usuario.IdUsuario.Email);
                Console.WriteLine("El Password es: " + usuario.IdUsuario.Password);
                Console.WriteLine("La fecha de nacimiento es:" + usuario.IdUsuario.FechaNacimiento);
                Console.WriteLine("El sexo es: " + usuario.IdUsuario.Sexo);
                Console.WriteLine("El telefono es: " + usuario.IdUsuario.Telefono);
                Console.WriteLine("El celular es: " + usuario.IdUsuario.Celular);
                Console.WriteLine("El curp es:" + usuario.IdUsuario.Curp);
                Console.WriteLine("El Id de la direccion es: " + usuario.IdDireccion );
                Console.WriteLine("La Calle es: " + usuario.Calle );
                Console.WriteLine("Numero Interior: " + usuario.NumeroInterior);
                Console.WriteLine("Numero Exterior: " + usuario.NumeroExterior);
                Console.WriteLine("Id Colonia: " + usuario.IdColonia.IdColonia);
                Console.WriteLine("Colonia: " + usuario.IdColonia.Nombre);
                Console.WriteLine("Codigo Postal: " + usuario.IdColonia.CodigoPostal);
                Console.WriteLine("Id Municipio: " + usuario.IdColonia.IdMunicipio.IdMunicipio);
                Console.WriteLine("Municipio: " + usuario.IdColonia.IdMunicipio.Nombre);
                Console.WriteLine("Id Estado; " + usuario.IdColonia.IdMunicipio.IdEstado.IdEstado);
                Console.WriteLine("Estado: " + usuario.IdColonia.IdMunicipio.IdEstado.Nombre);
                Console.WriteLine("Id Pais: " + usuario.IdColonia.IdMunicipio.IdEstado.idPais.IdPais);
                Console.WriteLine("Pais: " + usuario.IdColonia.IdMunicipio.IdEstado.idPais.Nombre);


                Console.WriteLine("---------------------------");


            }
            Console.ReadLine();
        }
        static public void GetById()
        {
            Console.WriteLine("Ingrese el Id del usuario: ");
            int Idusuario = int.Parse(Console.ReadLine());

            // ML.Result result = BL.Usuario.GetById(Idusuario);
            // ML.Result result = BL.Usuario.GetByIdsp(Idusuario);
            // ML.Result result = BL.Usuario.GETBYIDEF(Idusuario);
            //ML.Result result = BL.Usuario.GETBYIDLINQ(Idusuario);
            //ML.Result result = BL.Usuario.GETBYIDDEF(Idusuario);
            ML.Result result = BL.Usuario.GETBYIDINNER(Idusuario);

            if (result.Correct)
            {
                ML.Direccion usuario = (ML.Direccion)result.Object;
                Console.WriteLine("Idusuario es: " + usuario.IdUsuario.IdUsuario);
                Console.WriteLine("UserName es: " + usuario.IdUsuario.UserName);
                Console.WriteLine("Nombre es:" + usuario.IdUsuario.Nombre);
                Console.WriteLine("El Apellido Paterno es: " + usuario.IdUsuario.ApellidoPaterno);
                Console.WriteLine("El Apellido Materno es " + usuario.IdUsuario.ApellidoMaterno);
                Console.WriteLine("El Email es: " + usuario.IdUsuario.Email);
                Console.WriteLine("El Password es: " + usuario.IdUsuario.Password);
                Console.WriteLine("La fecha de nacimiento es:" + usuario.IdUsuario.FechaNacimiento);
                Console.WriteLine("El sexo es: " + usuario.IdUsuario.Sexo);
                Console.WriteLine("El telefono es: " + usuario.IdUsuario.Telefono);
                Console.WriteLine("El celular es: " + usuario.IdUsuario.Celular);
                Console.WriteLine("El curp es:" + usuario.IdUsuario.Curp);
                Console.WriteLine("El Id de la direccion es: " + usuario.IdDireccion);
                Console.WriteLine("La Calle es: " + usuario.Calle);
                Console.WriteLine("Numero Interior: " + usuario.NumeroInterior);
                Console.WriteLine("Numero Exterior: " + usuario.NumeroExterior);
                Console.WriteLine("Id Colonia: " + usuario.IdColonia.IdColonia);
                Console.WriteLine("Colonia: " + usuario.IdColonia.Nombre);
                Console.WriteLine("Codigo Postal: " + usuario.IdColonia.CodigoPostal);
                Console.WriteLine("Id Municipio: " + usuario.IdColonia.IdMunicipio.IdMunicipio);
                Console.WriteLine("Municipio: " + usuario.IdColonia.IdMunicipio.Nombre);
                Console.WriteLine("Id Estado; " + usuario.IdColonia.IdMunicipio.IdEstado.IdEstado);
                Console.WriteLine("Estado: " + usuario.IdColonia.IdMunicipio.IdEstado.Nombre);
                Console.WriteLine("Id Pais: " + usuario.IdColonia.IdMunicipio.IdEstado.idPais.IdPais);
                Console.WriteLine("Pais: " + usuario.IdColonia.IdMunicipio.IdEstado.idPais.Nombre);

            }
            else
            {
                Console.WriteLine("Ocurrio un error" + result.ErrorMessage);
            }
            Console.ReadLine();
        }
    }
}

