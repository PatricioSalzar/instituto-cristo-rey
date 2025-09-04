using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace Negocio
{
    public class MateriaNegoio
    {
        public List<Materia> listar()
        {
            List<Materia> lista = new List<Materia>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_MATERIA,NOMBRE_MATERIA from Materi");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Materia aux = new Materia();
                    aux.id_materia = (int)datos.Lector["ID_MATERIA"];
                    aux.nombre = (string)datos.Lector["NOMBRE_MATERIA"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
