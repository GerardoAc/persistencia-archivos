namespace persistenciaArchivos.UNA.Cheques
{
    partial class ControlCheque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmisorTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmisorTxt,
            this.ReceptorTxt,
            this.FechaTxt,
            this.MontoTxt,
            this.DescripcionTxt,
            this.MonedaTxt});
            this.dataGridView1.Location = new System.Drawing.Point(80, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmisorTxt
            // 
            this.EmisorTxt.HeaderText = "Emisor";
            this.EmisorTxt.Name = "EmisorTxt";
            // 
            // ReceptorTxt
            // 
            this.ReceptorTxt.HeaderText = "Receptor";
            this.ReceptorTxt.Name = "ReceptorTxt";
            // 
            // FechaTxt
            // 
            this.FechaTxt.HeaderText = "Fecha";
            this.FechaTxt.Name = "FechaTxt";
            // 
            // MontoTxt
            // 
            this.MontoTxt.HeaderText = "Monto";
            this.MontoTxt.Name = "MontoTxt";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.HeaderText = "Descripcion";
            this.DescripcionTxt.Name = "DescripcionTxt";
            // 
            // MonedaTxt
            // 
            this.MonedaTxt.HeaderText = "Moneda";
            this.MonedaTxt.Name = "MonedaTxt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control  de Cheques";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ControlCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ControlCheque";
            this.Text = "ControlCheque";
            this.Load += new System.EventHandler(this.ControlCheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmisorTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaTxt;
        private System.Windows.Forms.Label label1;
    }
}