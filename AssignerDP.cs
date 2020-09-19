/* * * * * * * * * * * * * * * * * * * * * * * *
* Autor: Víctor Silverio                       *
* Contacto: vsilverio262@puce.edu.ec           *
* Creado: 22/abr/2020                          *
* Última Modificación: 16/sep/2020             *
* Licencia: GNU GPLv3                          *
* Descripción: Clase de dominio del problema   *
 * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TestAssigner
{
    class AssignerDP
    {
        public string PathCarpeta { get; set; }
        public OpenFileDialog CSV { get; set; }
        public OpenFileDialog Excel { get; set; }
        public string NombreExamen { get; set; }
        public string[] Extensiones { get; set; }

        private bool TieneTitulo = false;
        private string[] Examenes = null;
        private string[,] XLSX = null;

        public AssignerDP() { }

        // --- SECCIÓN CSV --- //
        public string ComprobarCSV()
        {
            string respuesta = "Compruebe que el archivo CSV:\n\n- Esté cerrado.";
            TieneTitulo = false;
            try
            {
                var path = CSV.FileName;
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    bool condicionColumnas = ContarColumnas(csvParser) >= 2;
                    bool condicionFilas = ContarFilas(csvParser) > 0;
                    if (condicionColumnas && condicionFilas && TieneTitulo)
                        respuesta = "";
                    else
                    {
                        if (!condicionColumnas)
                        {
                            respuesta += "\n- Contenga al menos dos columnas.";
                        }
                        if (!condicionFilas)
                        {
                            respuesta += "\n- No esté vacío (Contenga información de al menos un estudiante).";
                        }
                        if (!TieneTitulo)
                        {
                            respuesta += "\n- Las columnas tengan título, que esté correctamente escrito y asignado a los datos.";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
            return respuesta;
        }

        private IEnumerable<string[]> LeerCSV()
        {
            IEnumerable<string[]> Respuesta = null;
            try
            {
                var path = CSV.FileName;
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    List<string[]> lista = new List<string[]>();

                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    if (TieneTitulo)
                        csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        string[] fila = new string[2];
                        string[] fields = csvParser.ReadFields();
                        fila[0] = fields[1];
                        fila[1] = fields[0].Substring(12, fields[0].Length - 12);
                        lista.Add(fila);
                    }
                    Respuesta = lista.OrderBy(dato => dato[0]);
                }
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
            return Respuesta;
        }

        private int ContarColumnas(TextFieldParser csvParser)
        {
            string[] respuesta = csvParser.ReadFields();
            if (respuesta[0].Equals("Identificador"))
                TieneTitulo = true;
            return respuesta.Length;
        }

        private int ContarFilas(TextFieldParser csvParser)
        {
            int respuesta = 0;
            while (!csvParser.EndOfData)
            {
                csvParser.ReadLine();
                respuesta++;
            }
            return respuesta;
        }

        private string[] GenerarNombres()
        {
            IEnumerable<string[]> CSV = LeerCSV();
            string[] respuesta = new string[CSV.Count()];
            for (int i = 0; i < respuesta.Length; i++)
            {
                respuesta[i] = string.Concat(CSV.ElementAt(i)[0], "_", CSV.ElementAt(i)[1], "_assignsubmission_file_", NombreExamen, Extensiones[0]);
            }
            return respuesta;
        }

        // --- SECCIÓN DE EXCEL --- //
        public string ComprobarExcel()
        {
            string respuesta = "Compruebe que el archivo Excel:\n\n- Esté cerrado.";
            try
            {
                using (ExcelPackage xlPackage = new ExcelPackage(this.Excel.OpenFile()))
                {
                    var myWorksheet = xlPackage.Workbook.Worksheets.First();
                    int totalRows;
                    int totalColumns;
                    bool condicionFilas;
                    bool condicionColumnas;
                    bool condicionCoherenciaExamenes;
                    bool condicionCoherenciaCSV;
                    bool condicionCoherenciaDatos;
                    if (myWorksheet.Dimension == null)
                    {
                        totalRows = 0;
                        totalColumns = 0;
                    }
                    else
                    {
                        totalRows = myWorksheet.Dimension.End.Row;
                        totalColumns = myWorksheet.Dimension.End.Column;
                    }
                    condicionFilas = totalRows > 1;
                    condicionColumnas = totalColumns >= 2;
                    if (condicionFilas && condicionColumnas)
                    {
                        LeerXLSX();
                        condicionCoherenciaDatos = SoloDigitos();
                        if (!condicionCoherenciaDatos)
                        {
                            respuesta += "\n- Que en la columna de exámenes existan únicamente números.";
                        }
                        if (CSV != null)
                        {
                            condicionCoherenciaCSV = CoherenciaExcelCSV();
                            if (!condicionCoherenciaCSV)
                            {
                                respuesta += "\n- Existan igual número de estudiantes en el archivo CSV y en el Excel.";
                            }
                        }
                        else
                            condicionCoherenciaCSV = true;
                        if (Examenes != null)
                        {
                            condicionCoherenciaExamenes = CoherenciaExcelExamen();
                            if (!condicionCoherenciaExamenes)
                            {
                                respuesta += "\n- La numeración de los exámenes en Excel empiece en 1.";
                                respuesta += "\n- El número de exámenes especificados concuerden con el número de archivos " + Extensiones[0] + " en la carpeta de exámenes.";
                            }
                        }
                        else
                            condicionCoherenciaExamenes = true;
                        if (condicionCoherenciaCSV && condicionCoherenciaExamenes && condicionCoherenciaDatos)
                            respuesta = "";
                    }
                    else
                    {
                        if (!condicionColumnas)
                        {
                            respuesta += "\n- Contenga al menos dos columnas.";
                        }
                        if (!condicionFilas)
                        {
                            respuesta += "\n- No esté vacío (Contenga información de al menos un estudiante).";
                        }
                    }
                    xlPackage.Dispose();
                }
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
            return respuesta;
        }
        public void LeerXLSX()
        {
            using (ExcelPackage xlPackage = new ExcelPackage(this.Excel.OpenFile()))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First();
                var totalRows = myWorksheet.Dimension.End.Row;
                XLSX = new string[totalRows - 1, 2];
                for (int Column = 1; Column <= 2; Column++)
                    for (int Row = 2; Row <= totalRows; Row++)
                        XLSX[Row - 2, Column - 1] = myWorksheet.Cells[Row, Column].GetValue<string>();
                xlPackage.Dispose();
            }
        }

        private bool SoloDigitos()
        {
            for (int i = 0; i < XLSX.GetLength(0); i++)
            {
                if (!SoloDigito(XLSX[i, 1]))
                    return false;
            }
            return true;
        }

        private bool SoloDigito(string cad)
        {
            foreach (char c in cad)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private bool CoherenciaExcelExamen()
        {
            bool respuesta = false;
            bool condicion1;
            bool condicion2;
            bool condicion3;
            int minimo = Convert.ToInt32(XLSX[0, 1]);
            int maximo = Convert.ToInt32(XLSX[0, 1]);
            // Obtener el mínimo y maximo
            for (int i = 1; i < XLSX.GetLength(0); i++)
            {
                if (SoloDigito(XLSX[i, 1]))
                {
                    if (Convert.ToInt32(XLSX[i, 1]) < minimo)
                        minimo = Convert.ToInt32(XLSX[i, 1]);
                    else if (Convert.ToInt32(XLSX[i, 1]) > maximo)
                        maximo = Convert.ToInt32(XLSX[i, 1]);
                }
            }
            condicion1 = maximo <= Examenes.Length;
            condicion2 = minimo >= 1;
            condicion3 = (maximo - minimo + 1) <= Examenes.Length;
            if (condicion1 && condicion2 && condicion3)
                respuesta = true;
            return respuesta;
        }

        private bool CoherenciaExcelCSV()
        {
            bool respuesta = false;
            var path = CSV.FileName;
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                int contador = ContarFilas(csvParser);
                if (contador == XLSX.GetLength(0) + 1)
                    respuesta = true;
            }
            return respuesta;
        }

        // --- SECCIÓN DE EXAMENES --- //
        public bool ComprobarExamenes()
        {
            bool respuesta = false;
            TraerExamenes();
            if (Examenes.Length > 1)
                respuesta = true;
            return respuesta;
        }

        private void TraerExamenes()
        {
            try
            {
                Examenes = Directory.EnumerateFiles(PathCarpeta).Where(file => Extensiones.Contains(Path.GetExtension(file).ToLower())).ToArray();
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
        }

        public int GetCantidad()
        {
            return Examenes.Length;
        }

        // --- ASIGNADORES ---//
        private void Asignar(string tipo, string[,] Mapa)
        {
            try
            {
                // Asignar
                string NombreArchivo = string.Concat(NombreExamen, "_As", tipo, "_", DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"));
                string PathSub = Path.Combine(PathCarpeta, NombreArchivo);
                Directory.CreateDirectory(PathSub);
                for (int i = 0; i < Mapa.GetLength(0); i++)
                {
                    File.Copy(Examenes[Convert.ToInt32(Mapa[i, 1])], Path.Combine(PathSub, Mapa[i, 0]));
                }
                // Zip
                Zippear(PathSub, NombreArchivo);
                // Excel
                ExportarExcel(PathCarpeta, Mapa, NombreArchivo);
                // Borrar Carpeta
                Borrar(PathSub);
                // Notificar
                MensajeExito(PathCarpeta);
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
        }

        private void Borrar(string PathSub)
        {
            System.Threading.Thread.Sleep(500);
            ClearAttributes(PathSub);
            Directory.Delete(PathSub, true);
        }

        private void ClearAttributes(string currentDir)
        {
            if (Directory.Exists(currentDir))
            {
                File.SetAttributes(currentDir, FileAttributes.Normal);

                string[] files = Directory.GetFiles(currentDir);
                foreach (string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                }
            }
        }

        private void Zippear(string PathSub, string NombreArchivo)
        {
            string ZipName = string.Concat(NombreArchivo, ".zip");
            string ZipLocation = Path.Combine(PathCarpeta, ZipName);
            ZipFile.CreateFromDirectory(PathSub, ZipLocation);
        }

        private void ExportarExcel(string path, string[,] Mapa, string NombreArchivo)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Resultados");
                // Titulos
                worksheet.Cells["A1"].Value = "Nombre del Archivo";
                worksheet.Cells["B1"].Value = "Número de Examen";
                // Datos
                worksheet.Cells["A2"].LoadFromCollection(EnlistarNombres(Mapa));
                worksheet.Cells["B2"].LoadFromCollection(EnlistarExamenes(Mapa));
                FileInfo fi = new FileInfo(Path.Combine(path, string.Concat(NombreArchivo, ".xlsx")));
                excelPackage.SaveAs(fi);
            }
        }

        private List<string> EnlistarNombres(string[,] Mapa)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                lista.Add(Mapa[i, 0]);
            }
            return lista;
        }

        private List<string> EnlistarExamenes(string[,] Mapa)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                lista.Add(Convert.ToString(Convert.ToInt32(Mapa[i, 1]) + 1));
            }
            return lista;
        }

        // --- SECCIÓN ALEATORIO --- //
        public void Aleatorio()
        {
            Random rnd = new Random();
            string[] Nombres = GenerarNombres();
            string[] Aleatorio = Nombres.OrderBy(x => rnd.Next()).ToArray();
            string[,] Mapa = Alternar(Aleatorio);
            Mapa = Mapa.OrderBy(x => x[0]);
            Asignar("Aleatoria", Mapa);
        }

        // --- SECCIÓN ALTERNADO --- //
        public void Alternado()
        {
            string[] Nombres = GenerarNombres();
            string[,] Mapa = Alternar(Nombres);
            Asignar("Alternada", Mapa);
        }

        private string[,] Alternar(string[] NombresArchivos)
        {
            string[,] respuesta = new string[NombresArchivos.Length, 2];
            for (int i = 0; i < NombresArchivos.Length;)
            {
                for (int j = 0; j < Examenes.Length && i < NombresArchivos.Length; i++, j++)
                {
                    respuesta[i, 0] = NombresArchivos[i];
                    respuesta[i, 1] = Convert.ToString(j);
                }
            }
            return respuesta;
        }

        // --- SECCIÓN GRUPOS --- //
        public void Grupos()
        {
            string[] Nombres = GenerarNombres();
            string[,] Mapa = AlternarGrupos(Nombres);
            Asignar("PorGrupos", Mapa);
        }
        private string[,] AlternarGrupos(string[] NombresArchivos)
        {
            string[,] respuesta = new string[NombresArchivos.Length, 2];
            int intervalo = Convert.ToInt32(Math.Floor(Convert.ToDouble(NombresArchivos.Length / Examenes.Length)));
            int sobrante = NombresArchivos.Length % Examenes.Length;
            for (int i = 0, j = 0; i < NombresArchivos.Length; j++)
            {
                int intervalo_aux = intervalo;
                if (sobrante > 0)
                {
                    intervalo_aux++;
                    sobrante--;
                }
                for (int k = 0; k < intervalo_aux && i < NombresArchivos.Length; i++, k++)
                {
                    respuesta[i, 0] = NombresArchivos[i];
                    respuesta[i, 1] = Convert.ToString(j);
                }
            }
            return respuesta;
        }

        // --- SECCIÓN PERSONALIZADO --- //
        public void Personalizado()
        {
            string[] Nombres = GenerarNombres();
            string[,] Mapa = MapearPersonalizado(Nombres);
            Asignar("Personalizado", Mapa);
        }

        private string[,] MapearPersonalizado(string[] NombresArchivos)
        {
            string[,] respuesta = new string[NombresArchivos.Length, 2];
            for (int i = 0; i < NombresArchivos.Length; i++)
            {
                respuesta[i, 0] = NombresArchivos[i];
                respuesta[i, 1] = Convert.ToString(Convert.ToInt32(XLSX[i, 1]) - 1);
            }
            return respuesta;
        }

        // --- MENSAJES --- //
        public void MensajeError(string Mensaje = "Ha ocurrido un error. Comprueba que todos los campos estén llenos.")
        {
            MessageBox.Show(Mensaje, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeExito(string Path)
        {
            DialogResult dialogResult = MessageBox.Show("Se ha generado la asignación con éxito. El resultado se encuentra en:\n\n" + Path + "\n\n¿Desea abrir la ubicación?", "¡Éxito!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(Path);
            }
        }

        public void MensajeAdvertencia(string Mensaje = "Algo ha salido mal.")
        {
            MessageBox.Show(Mensaje, "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
