using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;//esto tengo que ponerlo por la referencia, click derecho en mi clase sobre el explorador de soluciones
using System.Data.SqlClient;

namespace Negocio
{
    internal class AlumnoNegocio
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
                                     "values (@DNI_ALUMNO,@NOMBRE_ALUMNO,@APELLIDO_ALUMNO");
                datos.setearParamtro("@DNI_ALUMNO", nuevo.dni);
                datos.setearParamtro("@NOMBRE_ALUMNO", nuevo.nombre);
                datos.setearParamtro("@APELLIDO_ALUMNO", nuevo.apellido);
                ///NO LE PUSE ESTADO TODAVIA AL ALUMNO, DESPUES LE ARMO UN ESTADO BOOL
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
    }
}
