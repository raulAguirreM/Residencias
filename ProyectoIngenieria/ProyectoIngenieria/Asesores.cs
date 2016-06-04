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
    public partial class Asesores : Form
    {
        public Asesores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();

            try
            {

                bool f = obj.insertarStore(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, maskedTextBox2.Text, textBox4.Text, textBox5.Text);
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
    }
}
