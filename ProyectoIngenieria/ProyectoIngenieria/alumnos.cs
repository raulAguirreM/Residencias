using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIngenieria
{
    public partial class alumnos : Form
    {
        public alumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Datos obj = new Datos();
            bool f = obj.AgregarAlumnos(Convert.ToInt32(mtb_matricula.Text), txb_nombre.Text, txb_paterno.Text, txb_materno.Text, cb_carrera.Text, mtb_tel.Text, txb_correo.Text, txb_proyecto.Text, txb_empresa.Text);
            if (f == true)
            {
                MessageBox.Show("Datos agregados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
