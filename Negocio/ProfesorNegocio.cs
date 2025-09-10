using DOMINIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProfesorNegocio
    {
        public void agregarProfesor(Profesor nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Profesor (DNI_PROFESOR,NOMBRE,APELLIDO) " +
                                     "values (@DNI_PROFESOR,@NOMBRE,@APELLIDO)");
                datos.setearParamtro("@DNI_PROFESOR", nuevo.dni);
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
                    aux.dni = (string)datos.Lector["DNI"];
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


        public void modificarProfesor(Profesor nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Profesor set NOMBRE = @nombre, APELLIDO = @apellido, DNI = @dni");
                datos.setearParamtro("@nombre", nuevo.nombre);
                datos.setearParamtro("@apellido", nuevo.apellido);
                datos.setearParamtro("@dni", nuevo.dni);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarProfesor(int dni)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Profesor where DNI = @dni");
                datos.setearParamtro("dni", dni);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Profesor> BuscarProfesores(string nombre, string apellido, string dni)
        {
            List<Profesor> lista = new List<Profesor>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT DNI_PROFESOR, NOMBRE, APELLIDO FROM Profesor WHERE 1=1";

                if (!string.IsNullOrEmpty(nombre))
                    consulta += " AND NOMBRE LIKE @NOMBRE";

                if (!string.IsNullOrEmpty(apellido))
                    consulta += " AND APELLIDO LIKE @APELLIDO";

                if (!string.IsNullOrEmpty(dni))
                    consulta += " AND DNI LIKE @DNI_PROFESOR";

                datos.setearConsulta(consulta);

                if (!string.IsNullOrEmpty(nombre))
                    datos.setearParamtro("@NOMBRE", "%" + nombre + "%");

                if (!string.IsNullOrEmpty(apellido))
                    datos.setearParamtro("@APELLIDO", "%" + apellido + "%");

                if (!string.IsNullOrEmpty(dni))
                    datos.setearParamtro("@DNI_PROFESOR", "%" + dni + "%");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Profesor prof = new Profesor();
                    prof.dni = datos.Lector["DNI_PROFESOR"].ToString();
                    prof.nombre = datos.Lector["NOMBRE"].ToString();
                    prof.apellido = datos.Lector["APELLIDO"].ToString();

                    lista.Add(prof);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
