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
    public partial class Mostrar_Documentacion : Form
    {
        public Mostrar_Documentacion()
        {
            InitializeComponent();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Documentacion doc = new Documentacion();
            doc.Show();
        }

        private void Mostrar_Documentacion_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds;
            ds = obj.muestra("Select * from Documentacion");
            if (ds != null)
            {

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Mostrar_Documentacion_Activated(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds;
            ds = obj.muestra("Select * from Documentacion");
            if (ds != null)
            {

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Documentacion md = new Modificar_Documentacion(Convert.ToInt32(dataGridView1[0, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[1, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[2, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[3, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[4, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[5, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[6, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[7, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[8, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[9, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[10, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[11, e.RowIndex].Value), Convert.ToBoolean(dataGridView1[12, e.RowIndex].Value));
            md.Show();
        }
    }
}
