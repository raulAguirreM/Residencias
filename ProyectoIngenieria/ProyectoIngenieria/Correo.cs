using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ProyectoIngenieria
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos corr = new Datos();
            MailMessage mnsj = new MailMessage();
            try
            {
                corr.correo(textBox1.Text, textBox2.Text);

                mnsj.Subject = textBox4.Text;

                mnsj.To.Add(new MailAddress(textBox3.Text));

                mnsj.From = new MailAddress(textBox1.Text, "Departamento de Residensias del Instituto Tecnologico Superior de San Pedro");

                mnsj.Body = textBox5.Text;
                corr.MandarCorreo(mnsj);
                MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
            


        }
    }
}
