using DOMINIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Negocio
{
    public partial class AltaProfesor : Form
    {
        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void AceptarAltaProf_Click(object sender, EventArgs e)
        {
            Profesor nuevo = new Profesor();
            ProfesorNegocio negocio = new ProfesorNegocio();

            try
            {
                
                nuevo.dni = int.Parse(textDNIprof.Text);
                nuevo.nombre = textNombreProf.Text;
                nuevo.apellido = textApellidoProf.Text;

                
                negocio.agregarProfesor(nuevo);

                MessageBox.Show("Profesor agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        
    }
    }
}
