﻿using System;

                        result.Correct = true;
            }
            catch (Exception ex)


                    }


                    cmd.Parameters.AddRange(collection);
                result.ErrorMessage = "Error";


            return result;
            ML.Result result = new ML.Result();

                    var query = context.UsuarioInsert(usuario.IdUsuario.UserName, usuario.IdUsuario.Nombre, usuario.IdUsuario.ApellidoPaterno, usuario.IdUsuario.ApellidoMaterno, usuario.IdUsuario.Email,
        }

        static public ML.Result GetAllEF()
                            //usuario.IdUsuario = objusuario;
                            usuario.UserName = objusuario.UserName;

                    result.Object = new List<object>();

                        usuario.UserName = objusuario.UserName;
                        usuario.Nombre = objusuario.Nombre;
                        usuario.ApellidoPaterno = objusuario.ApellidoPaterno;
                        usuario.ApellidoMaterno = objusuario.ApellidoMaterno;
                        usuario.Email = objusuario.Email;
                        usuario.Password = objusuario.Password;
                        usuario.FechaNacimiento = objusuario.FechaNacimiento;
                        usuario.Sexo = objusuario.Sexo;
                        usuario.Telefono = objusuario.Telefono;
                        usuario.Celular = objusuario.Celular;
                        usuario.Curp = objusuario.Curp;

                        result.Correct = true;

                    usuarioD.UserName = usuario.UserName;
                    usuarioD.Telefono = usuario.Telefono;

            return result;
        {

            ML.Result result = new ML.Result();
        {
            ML.Result result = new ML.Result();

                    result.Object = new List<object>();


                        ML.Direccion usuario = new ML.Direccion();
                        usuario.IdUsuario = new ML.Usuario();

                        usuario.IdUsuario.UserName = objusuario.UserName;
                        usuario.IdUsuario.Nombre = objusuario.Nombre;
                        usuario.IdUsuario.ApellidoPaterno = objusuario.ApellidoPaterno;
                        usuario.IdUsuario.ApellidoMaterno = objusuario.ApellidoMaterno;
                        usuario.IdUsuario.Email = objusuario.Email;
                        usuario.IdUsuario.Password = objusuario.Password;
                        usuario.IdUsuario.FechaNacimiento = objusuario.FechaNacimiento;
                        usuario.IdUsuario.Sexo = objusuario.Sexo;
                        usuario.IdUsuario.Telefono = objusuario.Telefono;
                        usuario.IdUsuario.Celular = objusuario.Celular;
                        usuario.IdUsuario.Curp = objusuario.Curp;
                        usuario.IdUsuario.IdRol = new ML.Rol();
                        usuario.IdUsuario.IdRol.IdRol = objusuario.IdRol;
                        usuario.IdUsuario.IdRol.Nombre = objusuario.Rol;
                        usuario.IdDireccion = objusuario.IdDireccion;
                        usuario.Calle = objusuario.Calle;
                        usuario.NumeroInterior = objusuario.NUmeroInterior;
                        usuario.NumeroExterior = objusuario.NUmeroExterior;
                        usuario.IdColonia = new ML.Colonia();
                        usuario.IdColonia.IdColonia = objusuario.IdColonia;
                        usuario.IdColonia.Nombre = objusuario.Colonia;
                        usuario.IdColonia.CodigoPostal = objusuario.CodigoPostal;
                        usuario.IdColonia.IdMunicipio = new ML.Municipio();
                        usuario.IdColonia.IdMunicipio.IdMunicipio = objusuario.IdMUnicipio;
                        usuario.IdColonia.IdMunicipio.Nombre = objusuario.Municipio;
                        usuario.IdColonia.IdMunicipio.IdEstado = new ML.Estado();
                        usuario.IdColonia.IdMunicipio.IdEstado.IdEstado = objusuario.IdEstado;
                        usuario.IdColonia.IdMunicipio.IdEstado.Nombre = objusuario.Estado;
                        usuario.IdColonia.IdMunicipio.IdEstado.idPais = new ML.Pais();
                        usuario.IdColonia.IdMunicipio.IdEstado.idPais.IdPais = objusuario.IdPais;
                        usuario.IdColonia.IdMunicipio.IdEstado.idPais.Nombre = objusuario.Pais;

                        result.Correct = true;

        static public ML.Result GETALLLINQINNER()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.ProgramacionNCapasEntities context = new DL_EF.ProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios 
                                 join Direccion  in context.Direccions on Usuario.IdUsuario equals Direccion.IdUsuario
                                 join Colonia in context.Colonias on Direccion.IdColonia equals Colonia.IdColonia
                                 join Municipio in context.Municipios on Colonia.IdMunicipio equals Municipio.IdMunicipio
                                 join Estado in context.Estadoes on Municipio.IdEstado equals Estado.IdEstado
                                 join Pais in context.Pais on Estado.IDPais equals Pais.IdPais
                                 join Rol in context.Rols on Usuario.IdRol equals Rol.IdRol
                                 select new { Usuario.IdUsuario, Usuario.UserName, Usuario.Nombre, Usuario.ApellidoPaterno, Usuario.ApellidoMaterno, Usuario.Email,
                                 Usuario.Password, Usuario.FechaNacimiento, Usuario.Sexo, Usuario.Telefono, Usuario.Celular, Usuario.Curp, Rol.IdRol, Rol = Rol.Nombre, 
                                 Direccion.IdDireccion, Direccion.Calle, Direccion.NumeroInterior, Direccion.NumeroExterior, Colonia.IdColonia, Colonia = Colonia.Nombre,
                                     Colonia.CodigoPostal, Municipio.IdMunicipio, Municipio =  Municipio.Nombre, Estado.IdEstado, Estado = Estado.Nombre, Pais.IdPais, Pais = Pais.Nombre }).ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objusuario in query)
                        {
                            ML.Direccion usuario = new ML.Direccion();
                            usuario.IdUsuario = new ML.Usuario();
                            usuario.IdUsuario.IdUsuario = objusuario.IdUsuario;
                            usuario.IdUsuario.UserName = objusuario.UserName;
                            usuario.IdUsuario.Nombre = objusuario.Nombre;
                            usuario.IdUsuario.ApellidoPaterno = objusuario.ApellidoPaterno;
                            usuario.IdUsuario.ApellidoMaterno = objusuario.ApellidoMaterno;
                            usuario.IdUsuario.Email = objusuario.Email;
                            usuario.IdUsuario.Password = objusuario.Password;
                            usuario.IdUsuario.FechaNacimiento = objusuario.FechaNacimiento;
                            usuario.IdUsuario.Sexo = objusuario.Sexo;
                            usuario.IdUsuario.Telefono = objusuario.Telefono;
                            usuario.IdUsuario.Celular = objusuario.Celular;
                            usuario.IdUsuario.Curp = objusuario.Curp;
                            usuario.IdUsuario.IdRol = new ML.Rol();
                            usuario.IdUsuario.IdRol.IdRol = objusuario.IdRol;
                            usuario.IdUsuario.IdRol.Nombre = objusuario.Rol;
                            usuario.IdDireccion = objusuario.IdDireccion;
                            usuario.Calle = objusuario.Calle;
                            usuario.NumeroExterior = objusuario.NumeroExterior;
                            usuario.NumeroInterior = objusuario.NumeroInterior;
                            usuario.IdColonia = new ML.Colonia();
                            usuario.IdColonia.IdColonia = objusuario.IdColonia;
                            usuario.IdColonia.Nombre = objusuario.Colonia;
                            usuario.IdColonia.IdMunicipio = new ML.Municipio();
                            usuario.IdColonia.IdMunicipio.IdMunicipio = objusuario.IdMunicipio;
                            usuario.IdColonia.IdMunicipio.Nombre = objusuario.Municipio;
                            usuario.IdColonia.IdMunicipio.IdEstado = new ML.Estado();
                            usuario.IdColonia.IdMunicipio.IdEstado.IdEstado = objusuario.IdEstado;
                            usuario.IdColonia.IdMunicipio.IdEstado.Nombre = objusuario.Estado;
                            usuario.IdColonia.IdMunicipio.IdEstado.idPais = new ML.Pais();
                            usuario.IdColonia.IdMunicipio.IdEstado.idPais.IdPais = objusuario.IdPais;
                            usuario.IdColonia.IdMunicipio.IdEstado.idPais.Nombre = objusuario.Pais;

                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;
                    }
                    else {
                        result.Correct = false;
                        result.ErrorMessage = "Error al cargar";
                    }
                }
            }
            catch (Exception ex){ 
            result.Correct=false;
                result.ErrorMessage=ex.Message;
                result.Ex=ex;
            }
            return result;
        }


        static public ML.Result GETBYIDINNER(int IdUsuario)
        {
            ML.Result result = new ML.Result();
                    var objusuario = (from Usuario in context.Usuarios
                                 join Direccion in context.Direccions on Usuario.IdUsuario equals Direccion.IdUsuario
                                 join Colonia in context.Colonias on Direccion.IdColonia equals Colonia.IdColonia
                                 join Municipio in context.Municipios on Colonia.IdMunicipio equals Municipio.IdMunicipio
                                 join Estado in context.Estadoes on Municipio.IdEstado equals Estado.IdEstado
                                 join Pais in context.Pais on Estado.IDPais equals Pais.IdPais
                                 join Rol in context.Rols on Usuario.IdRol equals Rol.IdRol where Usuario.IdUsuario == IdUsuario
                                 select new
                                 {
                                     Usuario.UserName,
                                     Usuario.Nombre,
                                     Usuario.ApellidoPaterno,
                                     Usuario.ApellidoMaterno,
                                     Usuario.Email,
                                     Usuario.Password,
                                     Usuario.FechaNacimiento,
                                     Usuario.Sexo,
                                     Usuario.Telefono,
                                     Usuario.Celular,
                                     Usuario.Curp,
                                     Rol.IdRol,
                                     Rol = Rol.Nombre,
                                     Direccion.IdDireccion,
                                     Direccion.Calle,
                                     Direccion.NumeroInterior,
                                     Direccion.NumeroExterior,
                                     Colonia.IdColonia,
                                     Colonia = Colonia.Nombre,
                                     Colonia.CodigoPostal,
                                     Municipio.IdMunicipio,
                                     Municipio = Municipio.Nombre,
                                     Estado.IdEstado,
                                     Estado = Estado.Nombre,
                                     Pais.IdPais,
                                     Pais = Pais.Nombre
                                 }).Single();

                    result.Object = new List<object>();
                        ML.Direccion usuario = new ML.Direccion();
                        usuario.IdUsuario = new ML.Usuario();
                        usuario.IdUsuario.UserName = objusuario.UserName;
                        usuario.IdUsuario.Nombre = objusuario.Nombre;
                        usuario.IdUsuario.ApellidoPaterno = objusuario.ApellidoPaterno;
                        usuario.IdUsuario.ApellidoMaterno = objusuario.ApellidoMaterno;
                        usuario.IdUsuario.Email = objusuario.Email;
                        usuario.IdUsuario.Password = objusuario.Password;
                        usuario.IdUsuario.FechaNacimiento = objusuario.FechaNacimiento;
                        usuario.IdUsuario.Sexo = objusuario.Sexo;
                        usuario.IdUsuario.Telefono = objusuario.Telefono;
                        usuario.IdUsuario.Celular = objusuario.Celular;
                        usuario.IdUsuario.Curp = objusuario.Curp;
                        usuario.IdUsuario.IdRol = new ML.Rol();
                        usuario.IdUsuario.IdRol.IdRol = objusuario.IdRol;
                        usuario.IdUsuario.IdRol.Nombre = objusuario.Rol;
                        usuario.IdDireccion = objusuario.IdDireccion;
                        usuario.Calle = objusuario.Calle;
                        usuario.NumeroExterior = objusuario.NumeroExterior;
                        usuario.NumeroInterior = objusuario.NumeroInterior;
                        usuario.IdColonia = new ML.Colonia();
                        usuario.IdColonia.IdColonia = objusuario.IdColonia;
                        usuario.IdColonia.Nombre = objusuario.Colonia;
                        usuario.IdColonia.IdMunicipio = new ML.Municipio();
                        usuario.IdColonia.IdMunicipio.IdMunicipio = objusuario.IdMunicipio;
                        usuario.IdColonia.IdMunicipio.Nombre = objusuario.Municipio;
                        usuario.IdColonia.IdMunicipio.IdEstado = new ML.Estado();
                        usuario.IdColonia.IdMunicipio.IdEstado.IdEstado = objusuario.IdEstado;
                        usuario.IdColonia.IdMunicipio.IdEstado.Nombre = objusuario.Estado;
                        usuario.IdColonia.IdMunicipio.IdEstado.idPais = new ML.Pais();
                        usuario.IdColonia.IdMunicipio.IdEstado.idPais.IdPais = objusuario.IdPais;
                        usuario.IdColonia.IdMunicipio.IdEstado.idPais.Nombre = objusuario.Pais;

                        result.Objects.Add(usuario);
        }
    }