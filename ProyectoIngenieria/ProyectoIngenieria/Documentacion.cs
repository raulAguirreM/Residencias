using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace ProyectoIngenieria
{
    public partial class Documentacion : Form
    {
        public Documentacion()
        {
            InitializeComponent();
        }

        private void asesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bttnAgreg_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.InsertarDoc(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, checkBox9.Checked, checkBox10.Checked, checkBox11.Checked, checkBox12.Checked);
            if (f == true)
                MessageBox.Show("Datos Agregados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (f == false)
                MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
