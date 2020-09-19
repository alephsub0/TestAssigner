/* * * * * * * * * * * * * * * * * * * * * * * *
* Autor: Víctor Silverio                       *
* Contacto: vsilverio262@puce.edu.ec           *
* Creado: 22/abr/2020                          *
* Última Modificación: 16/sep/2020             *
* Licencia: GNU GPLv3                          *
* Descripción: Código detrás de la interfaz    *
 * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TestAssigner
{
    public partial class FormMenuPrincipal : Form
    {
        private const int ancho = 1120;
        private const int largo1 = 1100;
        private const int largo2 = 1360;
        private AssignerDP Asignador = new AssignerDP();
        private CommonOpenFileDialog CarpetaExamen = new CommonOpenFileDialog();
        private string[] Extensiones;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.Size = new Size(ancho, largo1);
            CarpetaExamen.IsFolderPicker = true;
            FDCSV.FileName = "";
            FDExcel.FileName = "";
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            FDCSV.Filter = "Archivos CSV (*.csv) | *.csv";
            if (FDCSV.ShowDialog() == DialogResult.OK)
            {
                string comprobacion;
                Asignador.CSV = FDCSV;
                comprobacion = Asignador.ComprobarCSV();
                if (comprobacion.Equals(""))
                {
                    lbPath1.Text = FDCSV.SafeFileName;
                }
                else
                {
                    FDCSV = new OpenFileDialog();
                    lbPath1.Text = "";
                    Asignador.MensajeError("Por favor, seleccione un archivo con las condiciones correctas para continuar. " + comprobacion);
                }
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if (CarpetaExamen.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Asignador.PathCarpeta = CarpetaExamen.FileName;
                lbPath2.Text = CarpetaExamen.FileName;
                switch (CBTipoArchivo.SelectedIndex)
                {
                    case 0: // PDF
                        Extensiones = new string[] { ".pdf" };
                        break;
                    case 1: // Word
                        Extensiones = new string[] { ".docx", ".doc" };
                        break;
                    case 2: // Excel
                        Extensiones = new string[] { ".xlsx", ".xls" };
                        break;
                    case 3: // PowerPoint
                        Extensiones = new string[] { ".pptx", ".ppt" };
                        break;
                    case 4: // JPEG
                        Extensiones = new string[] { ".jpg", ".jpeg" };
                        break;
                    case 5: // PNG
                        Extensiones = new string[] { ".png" };
                        break;
                    default:
                        Asignador.MensajeError();
                        break;
                }
                ComprobarExamenes();
            }
        }

        private void CBOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBOpciones.SelectedIndex == 3)
            {
                this.Size = new Size(ancho, largo2);
                GBExcel.Visible = true;
            }
            else
            {
                this.Size = new Size(ancho, largo1);
                GBExcel.Visible = false;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FDExcel.Filter = "Archivos Excel (*.xlsx;*.xls) | *.xlsx;*.xls";
            if (FDExcel.ShowDialog() == DialogResult.OK)
            {
                string comprobacion;
                Asignador.Excel = FDExcel;
                comprobacion = Asignador.ComprobarExcel();
                if (comprobacion.Equals(""))
                    lbPath3.Text = FDExcel.SafeFileName;
                else
                {
                    FDExcel.Reset();
                    Asignador.Excel = null;
                    FDExcel = new OpenFileDialog();
                    lbPath3.Text = "";
                    Asignador.MensajeError("Por favor, seleccione un archivo con las condiciones correctas para continuar. " + comprobacion);
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string error = ComprobarTodo();
            if (error.Equals(""))
            {
                Asignador.NombreExamen = TBExamen.Text;
                switch (CBOpciones.SelectedIndex)
                {
                    case 0:
                        Aleatorio();
                        break;
                    case 1:
                        Alternado();
                        break;
                    case 2:
                        Grupos();
                        break;
                    case 3:
                        Personalizado();
                        break;
                    default:
                        Asignador.MensajeError();
                        break;
                }
            }
            else
            {
                Asignador.MensajeError(error);
            }
        }

        private void MenuAyuda_Click(object sender, EventArgs e)
        {
            // Aqui va el video tutorial
            System.Diagnostics.Process.Start("https://youtu.be/hFkWlS0eXYI");
        }

        private void MenuCreditos_Click(object sender, EventArgs e)
        {
            new Creditos().Show();
        }

        private void ComprobarExamenes()
        {
            Asignador.Extensiones = Extensiones;
            if (Asignador.ComprobarExamenes())
            {
                lbError.Visible = false;
                lbNumero.Text = "* Se han encontrado " + Convert.ToString(Asignador.GetCantidad()) + " archivos.";
                lbNumero.Visible = true;
            }
            else
            {
                lbError.Visible = true;
                lbNumero.Visible = false;
                Asignador.MensajeAdvertencia("Se ha especificado un directorio sin, al menos, 2 archivos tipo " + Extensiones[0] + " dentro. Por favor, seleccionar otra carpeta.");
            }
        }

        private void Aleatorio()
        {
            Asignador.Aleatorio();
        }

        private void Alternado()
        {
            Asignador.Alternado();
        }

        private void Grupos()
        {
            Asignador.Grupos();
        }

        private void Personalizado()
        {
            Asignador.Personalizado();
        }

        private string ComprobarCondiciones()
        {
            string respuesta = "Los campos no están llenos:";
            if (TBExamen.Text.Equals(""))
                respuesta += "\n\n- Se debe incluir un nombre de examen.";
            if (FDCSV.FileName.Equals(""))
                respuesta += "\n- Se debe incluir un archivo de códigos de alumnos (CSV).";
            if (lbPath2.Text.Equals(""))
                respuesta += "\n- Se debe seleccionar una carpeta válida de exámenes en el tipo de archivo determinado.";
            if (CBOpciones.SelectedIndex == -1)
                respuesta += "\n- Se debe elegir un tipo de asignación.";
            if (CBOpciones.SelectedIndex == 3 && FDExcel.FileName.Equals(""))
                respuesta += "\n- Se debe incluir un archivo de asignación personalizada (Excel).";
            return respuesta;
        }

        private string ComprobarDeNuevo()
        {
            string respuesta = "Parece que los archivos se han editado durante la ejecución del programa.";
            respuesta += Asignador.ComprobarCSV();
            ComprobarExamenes();
            if (CBOpciones.SelectedIndex == 3)
            {
                string comprobacion = Asignador.ComprobarExcel();
                if (!comprobacion.Equals(""))
                {
                    FDExcel.Reset();
                    Asignador.Excel = null;
                    FDExcel = new OpenFileDialog();
                    lbPath3.Text = "";
                    respuesta += string.Concat("\n", comprobacion);
                }
            }
            return respuesta;
        }

        private string ComprobarTodo()
        {
            string respuesta;
            string Formulario = ComprobarCondiciones();
            if (Formulario.Equals("Los campos no están llenos:"))
            {
                string Nuevo = ComprobarDeNuevo();
                if (Nuevo.Equals("Parece que los archivos se han editado durante la ejecución del programa."))
                {
                    respuesta = "";
                }
                else
                    respuesta = string.Concat("\n", Nuevo);
            }
            else
                respuesta = Formulario;
            return respuesta;
        }

        private void acercaDeAlephsub0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.alephsub0.org/about/");
        }

        private void másNformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.alephsub0.org/divulgacion/asignar-tareas-y-examenes-personalizadas-en-moodle/");
        }

        private void CBTipoArchivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnArchivo.Enabled = true;
            lbNumero.Visible = false;
            lbError.Visible = false;
            lbPath2.Text = "";
        }
    }
}
