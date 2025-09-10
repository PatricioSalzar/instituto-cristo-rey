using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO;
using Negocio;

namespace InstitutoCristoRey
{
    public partial class ListarProfesor : Form
    {
        public ListarProfesor()
        {
            InitializeComponent();
        }

        private void volverProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarFiltros_Click(object sender, EventArgs e)
        {
            ProfesorNegocio negocio = new ProfesorNegocio();

            string nombre = textFiltroNomP.Text;
            string apellido = textFiltroApeP.Text;
            string dni = textFiltroDniP.Text;

            List<Profesor> lista = negocio.BuscarProfesores(nombre, apellido, dni);

            ListadoProf.DataSource = lista;
        }
    }
}
