using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb; //trabajar con excell

using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace PrestacionServicios
{
    public partial class Form1 : Form
    {

        public string directorio1;
        public PdfWriter writer;
        public iTextSharp.text.Font _standardFont;
        public Paragraph parrafo;
        public Document doc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo 
            // de filtro en este caso que busque
            //solo los archivos excel
            openFileDialog1.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblNombreArchivo.Text = openFileDialog1.FileName;
                string hoja = txtNombreHoja.Text;
                LLenarGrid(lblNombreArchivo.Text, hoja); //se manda a llamar al metodo

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
                //se ajustan las
                //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }
        }
        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridView1.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Creamos la tabla
            PdfPTable pdfTabla = new PdfPTable(dataGridView1.ColumnCount);
            pdfTabla.NormalizeHeadersFooters();
            //pdfTabla.DefaultCell.Padding = 1;
            pdfTabla.WidthPercentage = 100;
            pdfTabla.HorizontalAlignment = Element.ALIGN_LEFT;
            //pdfTabla.DefaultCell.BorderWidth = 1;

            // Añadimos los encabezados
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                var font1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8f, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font1));
                cell.BackgroundColor = BaseColor.BLACK;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTabla.AddCell(cell);
            }
            // Añadimos los datos de la tabla
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var font2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8f);
                    PdfPCell cel = new PdfPCell(new Phrase(cell.Value.ToString() , font2));
                    if (cell.RowIndex % 2 == 0)
                    {
                        cel.BackgroundColor = BaseColor.LIGHT_GRAY;
                    }
                    else
                    {
                        cel.BackgroundColor = BaseColor.WHITE;
                    }
                    cel.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    pdfTabla.AddCell(cel);
                }
            }
            // aqui guardar la tabla
            saveFileDialog1.Title = "Guardar Archivo PDF";
            saveFileDialog1.Filter = "Archivo de pdf (.pdf) |*.pdf";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directorio1 = saveFileDialog1.FileName;
                doc = new iTextSharp.text.Document(PageSize.LETTER, 20, 20, 20, 20);
                
                // Indicamos donde vamos a guardar el documento
                writer = PdfWriter.GetInstance(doc,
                    new FileStream(directorio1,
                        FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
                // Le colocamos el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle("PLANILLA DE PAGOS CONTRATISTA: CONTRATO DE PRESTACION DE SERVICIOS");
                doc.AddCreator("ARCHIVISTICOS GESTION DOCUMENTAL S.A.S.");
                doc.Open(); // Abrimos el archivo

                AgregarSaltoLinea();
                AgregarSaltoLinea();

                DefinirTamanoFuenteDocumento(18);
                AgregarTextoCentrado("ARCHIVÍSTICOS GESTIÓN DOCUMENTAL S.A.S.");
                DefinirTamanoFuenteDocumento(10);
                AgregarTextoCentrado("NIT. 900.400.125-3");
                AgregarTextoCentrado("Bucaramanga - Santander");
                AgregarSaltoLinea();
                AgregarSaltoLinea();
                DefinirTamanoFuenteDocumento(13);
                AgregarTextoCentrado("Alcaldía de Molagavita - Santander");
                DefinirTamanoFuenteDocumento(11);
                AgregarTextoCentrado("PLANILLA DE PAGOS CONTRATISTA: CONTRATO DE PRESTACIÓN DE SERVICIOS");
                AgregarTextoCentrado("CORTE DE: " + dtFechaInicial.Value + " A: " + dtFechaFinal.Value + ".");
                AgregarSaltoLinea();
                AgregarSaltoLinea();
                AgregarSaltoLinea();

                doc.Add(pdfTabla); //Añadimos la tabla

                AgregarSaltoLinea();
                AgregarSaltoLinea();
                AgregarSaltoLinea();

                AgregarTextoJustificado("_________________________                                   _________________________");
                AgregarTextoJustificado("" + txtRepresentanteLegal.Text + "                                        " + txtSupervisor.Text + "");
                AgregarTextoJustificado("Representante legal                                                     Supervisor");
                // Rosmira Ramona Montiel Paternina

                doc.Close(); // y cerramos el documento
                writer.Close();

                MessageBox.Show("Exportación exitosa","",MessageBoxButtons.OK);
            }
        }

        //
        public void DefinirTamanoFuenteDocumento(int tamañoLetra)
        {
            _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,
                                                     (int)tamañoLetra,
                                                    iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        }
        public void AgregarTextoJustificado(string texto)
        {
            // Forma 1 de agregar texto:
            parrafo = new Paragraph(); //creamos un elemento parrafo
            parrafo.Alignment = Element.ALIGN_JUSTIFIED; // lo justificamos
            parrafo.Font = _standardFont; // definimos la font del parrafo
            parrafo.Add(texto); //agreagmos el texto
            doc.Add(parrafo); // añadimos el elemento tipo parrafo al documento
            //AgregarSaltoLinea();
        }
        public void AgregarTextoCentrado(string texto)
        {
            // Forma 1 de agregar texto:
            parrafo = new Paragraph(); //creamos un elemento parrafo
            parrafo.Alignment = Element.ALIGN_CENTER; // lo justificamos
            parrafo.Font = _standardFont; // definimos la font del parrafo
            parrafo.Add(texto); //agreagmos el texto
            doc.Add(parrafo); // añadimos el elemento tipo parrafo al documento
            //AgregarSaltoLinea();
        }
        public void AgregarSaltoLinea()
        {
            doc.Add(new Paragraph(Environment.NewLine)); // salto de linea
        }
        //
    }
}
