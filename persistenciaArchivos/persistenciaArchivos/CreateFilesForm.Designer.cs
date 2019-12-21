namespace persistenciaArchivos
{
    partial class CreateFilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.EmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstitucionFinancieraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.MonedaTxt = new System.Windows.Forms.TextBox();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.institucionFincieraLabel = new System.Windows.Forms.Label();
            this.InstitucionFinancieraTxt = new System.Windows.Forms.TextBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDataPicker = new System.Windows.Forms.DateTimePicker();
            this.ReceptorLabel = new System.Windows.Forms.Label();
            this.ReceptorTxt = new System.Windows.Forms.TextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.EmisorLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTextBox = new System.Windows.Forms.TextBox();
            this.EmisorTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SigBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmisorColumn,
            this.ReceptorColumn,
            this.FechaColumn,
            this.NumeroChequeColumn,
            this.MontoColumn,
            this.InstitucionFinancieraColumn,
            this.DescripcionColumn,
            this.MonedaColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(267, 81);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(651, 171);
            this.ChequesDataGridView.TabIndex = 2;
            this.ChequesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChequesDataGridView_CellContentClick);
            // 
            // EmisorColumn
            // 
            this.EmisorColumn.HeaderText = "Emisor";
            this.EmisorColumn.Name = "EmisorColumn";
            this.EmisorColumn.ReadOnly = true;
            // 
            // ReceptorColumn
            // 
            this.ReceptorColumn.HeaderText = "Receptor";
            this.ReceptorColumn.Name = "ReceptorColumn";
            this.ReceptorColumn.ReadOnly = true;
            // 
            // FechaColumn
            // 
            this.FechaColumn.HeaderText = "Fecha";
            this.FechaColumn.Name = "FechaColumn";
            this.FechaColumn.ReadOnly = true;
            // 
            // NumeroChequeColumn
            // 
            this.NumeroChequeColumn.HeaderText = "Número Cheque";
            this.NumeroChequeColumn.Name = "NumeroChequeColumn";
            this.NumeroChequeColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto en Colones";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // InstitucionFinancieraColumn
            // 
            this.InstitucionFinancieraColumn.HeaderText = "Institucion Financiera";
            this.InstitucionFinancieraColumn.Name = "InstitucionFinancieraColumn";
            this.InstitucionFinancieraColumn.ReadOnly = true;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            // 
            // MonedaColumn
            // 
            this.MonedaColumn.HeaderText = "Moneda";
            this.MonedaColumn.Name = "MonedaColumn";
            this.MonedaColumn.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(267, 258);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(657, 258);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.MonedaTxt);
            this.UpsertPanel.Controls.Add(this.MonedaLabel);
            this.UpsertPanel.Controls.Add(this.institucionFincieraLabel);
            this.UpsertPanel.Controls.Add(this.InstitucionFinancieraTxt);
            this.UpsertPanel.Controls.Add(this.FechaLabel);
            this.UpsertPanel.Controls.Add(this.FechaDataPicker);
            this.UpsertPanel.Controls.Add(this.ReceptorLabel);
            this.UpsertPanel.Controls.Add(this.ReceptorTxt);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTextBox);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.EmisorLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTextBox);
            this.UpsertPanel.Controls.Add(this.EmisorTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(251, 428);
            this.UpsertPanel.TabIndex = 12;
            // 
            // MonedaTxt
            // 
            this.MonedaTxt.Location = new System.Drawing.Point(21, 275);
            this.MonedaTxt.Name = "MonedaTxt";
            this.MonedaTxt.Size = new System.Drawing.Size(207, 20);
            this.MonedaTxt.TabIndex = 28;
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonedaLabel.Location = new System.Drawing.Point(24, 259);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(46, 13);
            this.MonedaLabel.TabIndex = 27;
            this.MonedaLabel.Text = "Modena";
            // 
            // institucionFincieraLabel
            // 
            this.institucionFincieraLabel.AutoSize = true;
            this.institucionFincieraLabel.ForeColor = System.Drawing.Color.White;
            this.institucionFincieraLabel.Location = new System.Drawing.Point(18, 216);
            this.institucionFincieraLabel.Name = "institucionFincieraLabel";
            this.institucionFincieraLabel.Size = new System.Drawing.Size(92, 13);
            this.institucionFincieraLabel.TabIndex = 26;
            this.institucionFincieraLabel.Text = "InstitucionFinciera";
            // 
            // InstitucionFinancieraTxt
            // 
            this.InstitucionFinancieraTxt.Location = new System.Drawing.Point(21, 232);
            this.InstitucionFinancieraTxt.Name = "InstitucionFinancieraTxt";
            this.InstitucionFinancieraTxt.Size = new System.Drawing.Size(205, 20);
            this.InstitucionFinancieraTxt.TabIndex = 25;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FechaLabel.Location = new System.Drawing.Point(21, 93);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 24;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechaDataPicker
            // 
            this.FechaDataPicker.Location = new System.Drawing.Point(21, 112);
            this.FechaDataPicker.Name = "FechaDataPicker";
            this.FechaDataPicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDataPicker.TabIndex = 23;
            // 
            // ReceptorLabel
            // 
            this.ReceptorLabel.AutoSize = true;
            this.ReceptorLabel.ForeColor = System.Drawing.Color.White;
            this.ReceptorLabel.Location = new System.Drawing.Point(18, 51);
            this.ReceptorLabel.Name = "ReceptorLabel";
            this.ReceptorLabel.Size = new System.Drawing.Size(135, 13);
            this.ReceptorLabel.TabIndex = 22;
            this.ReceptorLabel.Text = "Receptor(min 3 caractéres)";
            // 
            // ReceptorTxt
            // 
            this.ReceptorTxt.Location = new System.Drawing.Point(21, 67);
            this.ReceptorTxt.Name = "ReceptorTxt";
            this.ReceptorTxt.Size = new System.Drawing.Size(205, 20);
            this.ReceptorTxt.TabIndex = 21;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 175);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            this.MontoLabel.Click += new System.EventHandler(this.MontoLabel_Click);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(21, 191);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(205, 20);
            this.MontoTextBox.TabIndex = 15;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(18, 315);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(212, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(21, 331);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 51);
            this.DescripcionTextBox.TabIndex = 16;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 136);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(185, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque (min 5 caractéres)";
            this.NumeroChequeLabel.Click += new System.EventHandler(this.NumeroChequeLabel_Click);
            // 
            // EmisorLabel
            // 
            this.EmisorLabel.AutoSize = true;
            this.EmisorLabel.ForeColor = System.Drawing.Color.White;
            this.EmisorLabel.Location = new System.Drawing.Point(18, 12);
            this.EmisorLabel.Name = "EmisorLabel";
            this.EmisorLabel.Size = new System.Drawing.Size(125, 13);
            this.EmisorLabel.TabIndex = 15;
            this.EmisorLabel.Text = "Emisor (min 3 caractéres)";
            // 
            // NumeroChequeTextBox
            // 
            this.NumeroChequeTextBox.Location = new System.Drawing.Point(21, 152);
            this.NumeroChequeTextBox.Name = "NumeroChequeTextBox";
            this.NumeroChequeTextBox.Size = new System.Drawing.Size(205, 20);
            this.NumeroChequeTextBox.TabIndex = 14;
            // 
            // EmisorTextBox
            // 
            this.EmisorTextBox.Location = new System.Drawing.Point(21, 28);
            this.EmisorTextBox.Name = "EmisorTextBox";
            this.EmisorTextBox.Size = new System.Drawing.Size(205, 20);
            this.EmisorTextBox.TabIndex = 13;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(138, 388);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(21, 388);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(448, 12);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(279, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(471, 41);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(367, 258);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(95, 23);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // SigBtn
            // 
            this.SigBtn.Location = new System.Drawing.Point(416, 331);
            this.SigBtn.Name = "SigBtn";
            this.SigBtn.Size = new System.Drawing.Size(75, 23);
            this.SigBtn.TabIndex = 17;
            this.SigBtn.Text = "Siguiente";
            this.SigBtn.UseVisualStyleBackColor = true;
            this.SigBtn.Click += new System.EventHandler(this.SigBtn_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 440);
            this.Controls.Add(this.SigBtn);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label EmisorLabel;
        private System.Windows.Forms.TextBox NumeroChequeTextBox;
        private System.Windows.Forms.TextBox EmisorTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstitucionFinancieraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaColumn;
        private System.Windows.Forms.TextBox MonedaTxt;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.Label institucionFincieraLabel;
        private System.Windows.Forms.TextBox InstitucionFinancieraTxt;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaDataPicker;
        private System.Windows.Forms.Label ReceptorLabel;
        private System.Windows.Forms.TextBox ReceptorTxt;
        private System.Windows.Forms.Button SigBtn;
    }
}

