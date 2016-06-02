using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\Raul\Desktop\ING SW\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Roberto Torres");

            // Abrimos el archivo
            doc.Open();

            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Mi primer documento PDF"));
            doc.Add(Chunk.NEWLINE);

            Chunk chunk = new Chunk("Texto subrayado",

             FontFactory.GetFont("ARIAL",

                         12,

                     iTextSharp.text.Font.BOLD));



            doc.Add(new Paragraph(chunk)); 


            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Raul", _standardFont));
            clNombre.BorderWidth = 0;

            clApellido = new PdfPCell(new Phrase("Aguirre", _standardFont));
            clApellido.BorderWidth = 0;

            clPais = new PdfPCell(new Phrase("San Pedro", _standardFont));
            clPais.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();
            

        }


    }
}
