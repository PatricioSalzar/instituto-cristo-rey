using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace Negocio
{
    public class CursoNegocio
    {
        public List<Cruso> listar()
        {
            List<Cruso> lista = new List<Cruso>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID_CURSO,NOMBRE from curso");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cruso aux = new Cruso();
                    aux.id_curso = (int)datos.Lector["ID_CURSO"];
                    aux.nombre = (string)datos.Lector["NOMBRE"];
                    lista.Add(aux); 
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
        //creo que cursos puede ser un atributo de alumno, por que el, por que no haria falta necesarariamente
        //crear para curso una opcion para agregar,modificar o eliminar
        //DESPUES LO HABLAMOS
    }
}
