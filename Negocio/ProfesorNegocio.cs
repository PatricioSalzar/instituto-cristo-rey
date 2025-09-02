using DOMINIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class ProfesorNegocio
    {
        public void agregarProfesor(Profesor nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Profesor (DNI,NOMBRE,APELLIDO) " +
                                     "values (@DNI,@NOMBRE,@APELLIDO)");
                datos.setearParamtro("@DNI", nuevo.dni);
                datos.setearParamtro("@NOMBRE", nuevo.nombre);
                datos.setearParamtro("@APELLIDO", nuevo.apellido);
                
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Profesor> listarProfesor()
        {
            List<Profesor> lista = new List<Profesor>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select DNI, NOMBRE, APELLIDO from Profesor");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Profesor aux = new Profesor();
                    aux.dni = (int)datos.Lector["DNI"];
                    aux.nombre = (string)datos.Lector["NOMBRE"];
                    aux.apellido = (string)datos.Lector["APELLIDO"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



    }
}
