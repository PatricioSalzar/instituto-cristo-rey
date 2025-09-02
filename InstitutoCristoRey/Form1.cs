using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace InstitutoCristoRey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altaProfesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaProfesor formAlta = new AltaProfesor();
            formAlta.ShowDialog();
        }
    }
}
