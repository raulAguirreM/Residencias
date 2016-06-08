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
    public partial class modAlumno : Form
    {
        public modAlumno()
        {
            InitializeComponent();
        }

        private void modAlumno_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds;
            ds = obj.verAlumno
                ("Select * from Alumnos");

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos objt = new Datos();
            bool f = objt.Elim_Alumnos(Convert.ToInt32(ktb_matr.Text));
            if (f == true)
            {
                MessageBox.Show("REGISTRO ELIMINADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            Datos objT = new Datos();
            DataSet ds;
            ds = objT.verAlumno
                ("Select * from Alumnos");

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            ktb_matr.Clear();
            tb_nombre.Clear();
            tb_paterno.Clear();
            tb_materno.Clear();
            mtb_tel.Clear();
            tb_correo.Clear();
            tb_proyecto.Clear();
            tb_empresa.Clear();
            cb_carrera.Text = "";

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.ModificarAlumnos(Convert.ToInt32(ktb_matr.Text), tb_nombre.Text, tb_paterno.Text, tb_materno.Text, cb_carrera.Text, mtb_tel.Text, tb_correo.Text, tb_proyecto.Text, tb_empresa.Text);
            if (f == true)
            {
                MessageBox.Show("Datos agregados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }

            Datos objT = new Datos();
            DataSet ds;
            ds = objT.verAlumno
                ("Select * from Alumnos");

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            ktb_matr.Clear();
            tb_nombre.Clear();
            tb_paterno.Clear();
            tb_materno.Clear();
            mtb_tel.Clear();
            tb_correo.Clear();
            tb_proyecto.Clear();
            tb_empresa.Clear();
            cb_carrera.Text = "";

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ktb_matr.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            tb_nombre.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            tb_paterno.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            tb_materno.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            cb_carrera.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            mtb_tel.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            tb_correo.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            tb_proyecto.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            tb_empresa.Text = dataGridView1[8, e.RowIndex].Value.ToString();

        }
    }
}
