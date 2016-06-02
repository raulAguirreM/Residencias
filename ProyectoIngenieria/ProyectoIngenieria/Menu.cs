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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alumnos alu = new alumnos();
            alu.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asesoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Asesores ase = new Asesores();
            ase.Show();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Citas cit = new Citas();
            cit.Show();
        }

        private void documentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentacion doc = new Documentacion();
            doc.Show();
        }

        private void requisitosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Requisitos req = new Requisitos();
            req.Show();
        }
    }
}
