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
    public partial class Requisitos : Form
    {
        public Requisitos()
        {
            InitializeComponent();
            numericUpDown1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();

            try
            {

                bool f = obj.insertarRequisitos(maskedTextBox1.Text, checkBox1.Checked,checkBox2.Checked,Convert.ToInt32(numericUpDown1.Value),checkBox3.Checked,Convert.ToString(dateTimePicker1.Value));
                if (f == true)
                {
                    MessageBox.Show("Agregado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                numericUpDown1.Enabled = true;
            }
            if (checkBox2.Checked==false)
            {
                numericUpDown1.Value = 0;
                numericUpDown1.Enabled = false;
            }
        }
    }
}
