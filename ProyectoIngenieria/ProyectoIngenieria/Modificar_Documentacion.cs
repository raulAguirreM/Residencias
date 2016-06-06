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
    public partial class Modificar_Documentacion : Form
    {

        int folio;
        public Modificar_Documentacion(int folio, bool Solicitud, bool Anteproyecto, bool Carta, bool Dictamen, bool Asignacion, bool AsesorExt, bool Seguimiento, bool Registro, bool CartaAgrad, bool CDInforme, bool CDRes, bool CartaAcep)
        {
            InitializeComponent();
            this.folio = folio;
            checkBox1.Checked = Solicitud;
            checkBox2.Checked = Anteproyecto;
            checkBox3.Checked = Carta;
            checkBox4.Checked = Dictamen;
            checkBox5.Checked = Asignacion;
            checkBox6.Checked = AsesorExt;
            checkBox7.Checked = Seguimiento;
            checkBox8.Checked = Registro;
            checkBox9.Checked = CartaAgrad;
            checkBox10.Checked = CDInforme;
            checkBox11.Checked = CDRes;
            checkBox12.Checked = CartaAcep;
        }

        private void bttnMod_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.ActualizarDoc(folio, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, checkBox9.Checked, checkBox10.Checked, checkBox11.Checked, checkBox12.Checked);

            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
