namespace TestAssigner
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.másNformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lbPath1 = new System.Windows.Forms.Label();
            this.btnCSV = new System.Windows.Forms.Button();
            this.FDCSV = new System.Windows.Forms.OpenFileDialog();
            this.CBOpciones = new System.Windows.Forms.ComboBox();
            this.GBCSV = new System.Windows.Forms.GroupBox();
            this.GBPDF = new System.Windows.Forms.GroupBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTipoArchivo = new System.Windows.Forms.ComboBox();
            this.lbError = new System.Windows.Forms.Label();
            this.lbPath2 = new System.Windows.Forms.Label();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.GBNombre = new System.Windows.Forms.GroupBox();
            this.GBExcel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPath3 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.FDExcel = new System.Windows.Forms.OpenFileDialog();
            this.CBTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TBExamen = new TestAssigner.PlaceHolderTextBox();
            this.menuStrip1.SuspendLayout();
            this.GBCSV.SuspendLayout();
            this.GBPDF.SuspendLayout();
            this.GBNombre.SuspendLayout();
            this.GBExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAyuda,
            this.másNformaciónToolStripMenuItem,
            this.MenuCreditos});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 26);
            this.toolStripMenuItem1.Text = "Ayuda";
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.Image = ((System.Drawing.Image)(resources.GetObject("MenuAyuda.Image")));
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.ShortcutKeyDisplayString = "Ctrl + F1";
            this.MenuAyuda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.MenuAyuda.Size = new System.Drawing.Size(244, 26);
            this.MenuAyuda.Text = "Ver ayuda";
            this.MenuAyuda.Click += new System.EventHandler(this.MenuAyuda_Click);
            // 
            // másNformaciónToolStripMenuItem
            // 
            this.másNformaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("másNformaciónToolStripMenuItem.Image")));
            this.másNformaciónToolStripMenuItem.Name = "másNformaciónToolStripMenuItem";
            this.másNformaciónToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.másNformaciónToolStripMenuItem.Text = "Más Información";
            this.másNformaciónToolStripMenuItem.Click += new System.EventHandler(this.másNformaciónToolStripMenuItem_Click);
            // 
            // MenuCreditos
            // 
            this.MenuCreditos.Name = "MenuCreditos";
            this.MenuCreditos.Size = new System.Drawing.Size(244, 26);
            this.MenuCreditos.Text = "Acerca de TestAssigner";
            this.MenuCreditos.Click += new System.EventHandler(this.MenuCreditos_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAsignar.Location = new System.Drawing.Point(310, 511);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(175, 50);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar Exámenes";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lbPath1
            // 
            this.lbPath1.AutoEllipsis = true;
            this.lbPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath1.Location = new System.Drawing.Point(205, 57);
            this.lbPath1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPath1.Name = "lbPath1";
            this.lbPath1.Size = new System.Drawing.Size(280, 35);
            this.lbPath1.TabIndex = 8;
            // 
            // btnCSV
            // 
            this.btnCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.Location = new System.Drawing.Point(20, 45);
            this.btnCSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(162, 35);
            this.btnCSV.TabIndex = 2;
            this.btnCSV.Text = "Seleccionar";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // FDCSV
            // 
            this.FDCSV.FileName = "openFileDialog1";
            // 
            // CBOpciones
            // 
            this.CBOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOpciones.FormattingEnabled = true;
            this.CBOpciones.ItemHeight = 18;
            this.CBOpciones.Items.AddRange(new object[] {
            "Aleatorio",
            "Alternado",
            "Grupos",
            "Personalizado"});
            this.CBOpciones.Location = new System.Drawing.Point(60, 531);
            this.CBOpciones.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.CBOpciones.Name = "CBOpciones";
            this.CBOpciones.Size = new System.Drawing.Size(200, 26);
            this.CBOpciones.Sorted = true;
            this.CBOpciones.TabIndex = 12;
            this.CBOpciones.TabStop = false;
            this.CBOpciones.SelectedIndexChanged += new System.EventHandler(this.CBOpciones_SelectedIndexChanged);
            // 
            // GBCSV
            // 
            this.GBCSV.Controls.Add(this.lbPath1);
            this.GBCSV.Controls.Add(this.btnCSV);
            this.GBCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCSV.Location = new System.Drawing.Point(15, 180);
            this.GBCSV.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.GBCSV.Name = "GBCSV";
            this.GBCSV.Size = new System.Drawing.Size(510, 110);
            this.GBCSV.TabIndex = 2;
            this.GBCSV.TabStop = false;
            this.GBCSV.Text = "Archivo de códigos de alumnos (CSV)";
            // 
            // GBPDF
            // 
            this.GBPDF.Controls.Add(this.lbNumero);
            this.GBPDF.Controls.Add(this.label2);
            this.GBPDF.Controls.Add(this.CBTipoArchivo);
            this.GBPDF.Controls.Add(this.lbError);
            this.GBPDF.Controls.Add(this.lbPath2);
            this.GBPDF.Controls.Add(this.btnArchivo);
            this.GBPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPDF.Location = new System.Drawing.Point(15, 315);
            this.GBPDF.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.GBPDF.Name = "GBPDF";
            this.GBPDF.Size = new System.Drawing.Size(510, 168);
            this.GBPDF.TabIndex = 3;
            this.GBPDF.TabStop = false;
            this.GBPDF.Text = "Carpeta de los exámenes";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.Transparent;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(234, 147);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(211, 17);
            this.lbNumero.TabIndex = 10;
            this.lbNumero.Text = "* Se han encontrado n archivos.";
            this.lbNumero.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo de archivo del examen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBTipoArchivo
            // 
            this.CBTipoArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoArchivo.DropDownWidth = 200;
            this.CBTipoArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipoArchivo.FormattingEnabled = true;
            this.CBTipoArchivo.IntegralHeight = false;
            this.CBTipoArchivo.ItemHeight = 18;
            this.CBTipoArchivo.Items.AddRange(new object[] {
            "PDF",
            "Microsoft Word (.docx)",
            "Microsoft Excel (.xlsx)",
            "Microsoft PowerPoint (.pptx)",
            "Imagen (.jpeg)",
            "Imagen (.png)"});
            this.CBTipoArchivo.Location = new System.Drawing.Point(20, 64);
            this.CBTipoArchivo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.CBTipoArchivo.Name = "CBTipoArchivo";
            this.CBTipoArchivo.Size = new System.Drawing.Size(162, 26);
            this.CBTipoArchivo.TabIndex = 17;
            this.CBTipoArchivo.TabStop = false;
            this.CBTipoArchivo.SelectedIndexChanged += new System.EventHandler(this.CBTipoArchivo_SelectedIndexChanged);
            // 
            // lbError
            // 
            this.lbError.AccessibleDescription = "";
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(477, 66);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(25, 38);
            this.lbError.TabIndex = 9;
            this.lbError.Text = "i";
            this.toolTip1.SetToolTip(this.lbError, "Se ha especificado un directorio sin archivos PDF dentro. Por favor, seleccionar " +
        "otra carpeta.");
            this.lbError.Visible = false;
            // 
            // lbPath2
            // 
            this.lbPath2.AutoEllipsis = true;
            this.lbPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath2.Location = new System.Drawing.Point(218, 41);
            this.lbPath2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPath2.Name = "lbPath2";
            this.lbPath2.Size = new System.Drawing.Size(252, 101);
            this.lbPath2.TabIndex = 8;
            this.lbPath2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Enabled = false;
            this.btnArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.Location = new System.Drawing.Point(20, 112);
            this.btnArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(162, 35);
            this.btnArchivo.TabIndex = 3;
            this.btnArchivo.Text = "Seleccionar";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // GBNombre
            // 
            this.GBNombre.Controls.Add(this.TBExamen);
            this.GBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNombre.Location = new System.Drawing.Point(15, 45);
            this.GBNombre.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.GBNombre.Name = "GBNombre";
            this.GBNombre.Size = new System.Drawing.Size(510, 110);
            this.GBNombre.TabIndex = 1;
            this.GBNombre.TabStop = false;
            this.GBNombre.Text = "Nombre del examen";
            // 
            // GBExcel
            // 
            this.GBExcel.Controls.Add(this.label1);
            this.GBExcel.Controls.Add(this.lbPath3);
            this.GBExcel.Controls.Add(this.btnExcel);
            this.GBExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBExcel.Location = new System.Drawing.Point(15, 586);
            this.GBExcel.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.GBExcel.Name = "GBExcel";
            this.GBExcel.Size = new System.Drawing.Size(510, 113);
            this.GBExcel.TabIndex = 15;
            this.GBExcel.TabStop = false;
            this.GBExcel.Text = "Archivo para asignación personalizada (Excel)";
            this.GBExcel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "* El archivo excel debe estar ordenado alfabéticamente por apellido.";
            // 
            // lbPath3
            // 
            this.lbPath3.AutoEllipsis = true;
            this.lbPath3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath3.Location = new System.Drawing.Point(205, 57);
            this.lbPath3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPath3.Name = "lbPath3";
            this.lbPath3.Size = new System.Drawing.Size(280, 35);
            this.lbPath3.TabIndex = 8;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(20, 45);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(162, 35);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Seleccionar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FDExcel
            // 
            this.FDExcel.FileName = "openFileDialog1";
            // 
            // CBTitle
            // 
            this.CBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTitle.Location = new System.Drawing.Point(60, 508);
            this.CBTitle.Name = "CBTitle";
            this.CBTitle.Size = new System.Drawing.Size(200, 20);
            this.CBTitle.TabIndex = 16;
            this.CBTitle.Text = "Tipo de asignación";
            this.CBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBExamen
            // 
            this.TBExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.TBExamen.ForeColor = System.Drawing.Color.Gray;
            this.TBExamen.Location = new System.Drawing.Point(45, 48);
            this.TBExamen.Name = "TBExamen";
            this.TBExamen.PlaceHolderText = "Ingrese el nombre del examen";
            this.TBExamen.Size = new System.Drawing.Size(400, 27);
            this.TBExamen.TabIndex = 1;
            this.TBExamen.TabStop = false;
            this.TBExamen.Text = "Ingrese el nombre del examen";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 717);
            this.Controls.Add(this.CBTitle);
            this.Controls.Add(this.GBExcel);
            this.Controls.Add(this.GBNombre);
            this.Controls.Add(this.GBPDF);
            this.Controls.Add(this.GBCSV);
            this.Controls.Add(this.CBOpciones);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.Text = "TestAssigner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBCSV.ResumeLayout(false);
            this.GBPDF.ResumeLayout(false);
            this.GBPDF.PerformLayout();
            this.GBNombre.ResumeLayout(false);
            this.GBNombre.PerformLayout();
            this.GBExcel.ResumeLayout(false);
            this.GBExcel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuCreditos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lbPath1;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.OpenFileDialog FDCSV;
        private System.Windows.Forms.ToolStripMenuItem MenuAyuda;
        private System.Windows.Forms.ComboBox CBOpciones;
        private System.Windows.Forms.GroupBox GBCSV;
        private System.Windows.Forms.GroupBox GBPDF;
        private System.Windows.Forms.Label lbPath2;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.GroupBox GBNombre;
        private PlaceHolderTextBox TBExamen;
        private System.Windows.Forms.GroupBox GBExcel;
        private System.Windows.Forms.Label lbPath3;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.OpenFileDialog FDExcel;
        private System.Windows.Forms.Label CBTitle;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem másNformaciónToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBTipoArchivo;
        private System.Windows.Forms.Label lbNumero;
    }
}

