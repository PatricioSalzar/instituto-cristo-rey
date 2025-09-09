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
    public partial class AltaAlumno : Form
    {
        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void dniAlum_Click(object sender, EventArgs e)
        {

        }

        private void CancelarAltaAlum_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarAltaAlum_Click(object sender, EventArgs e)
        {
            Alumno nuevo = new Alumno();
            AlumnoNegocio negocio = new AlumnoNegocio();

            try
            {

                nuevo.dni = textDniAlum.Text;
                nuevo.nombre = textNombreAlum.Text;
                nuevo.apellido = textApellidoAlum.Text;
                nuevo.estado = true;
                //nuevo.anioIng = textAñoIngAlum.Text;


                negocio.agregarAlumno(nuevo);

                MessageBox.Show("Alumno agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }
    }
}
