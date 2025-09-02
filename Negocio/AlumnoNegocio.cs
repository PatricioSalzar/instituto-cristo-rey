using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;//esto tengo que ponerlo por la referencia, click derecho en mi clase sobre el explorador de soluciones
using System.Data.SqlClient;

namespace Negocio
{
    public class AlumnoNegocio
    {
        List<Alumno> lista()
        {
            List<Alumno> lista = new List<Alumno>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\\\SQLEXPRESS; database=BD ICR; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select DNI_ALUMNO, NOMBRE_ALUMNO, APELLIDO_ALUMNO from Alumno";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())//habria que ver que otros datos podemos mostrar sobre los alumnos /*DESPUES LO HABLAMOS*/
                {
                    Alumno aux = new Alumno();
                    aux.dni = (int)lector["DNI_ALUMNO"];
                    aux.nombre = (string)lector["NOMBRE_ALUMNO"];
                    aux.apellido = (string)lector["APELLIDO_ALUMNO"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agrgar(Alumno nuevo)
        {
            AccesoDatos datos  = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Alumno (DNI_ALUMNO,NOMBRE_ALUMNO,APELLIDO_ALUMNO,ESTADO_ALUMNO) " +
                                     "values (@DNI_ALUMNO,@NOMBRE_ALUMNO,@APELLIDO_ALUMNO,@ESTADO_ALUMNO");
                datos.setearParamtro("@DNI_ALUMNO", nuevo.dni);
                datos.setearParamtro("@NOMBRE_ALUMNO", nuevo.nombre);
                datos.setearParamtro("@APELLIDO_ALUMNO", nuevo.apellido);
                datos.setearParamtro("@ESTADO_ALUMNO", nuevo.estado);
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

        public void modificar(Alumno nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Alumno set NOMBRE_ALUMNO = @nombre, APELLIDO_ALUMNO = @apellido, ESTADO_ALUMNO = @estado where DNI_ALUMNO = @dni");
                datos.setearParamtro("@nombre", nuevo.nombre);
                datos.setearParamtro("@apellido", nuevo.apellido);
                datos.setearParamtro("@estado", nuevo.estado);
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

        public void eliminar(int dni)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Alumno where DNI_ALUMNO = @dni");
                datos.setearParamtro("dni", dni);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void bajaLogica(int dni)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Alumno set ESTADO_ALUMNO = 0 where DNI_ALUMNO = @dni");
                datos.setearParamtro("@dni", dni);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
