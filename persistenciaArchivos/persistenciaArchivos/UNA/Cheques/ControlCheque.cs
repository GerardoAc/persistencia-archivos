using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persistenciaArchivos.UNA.Cheques
{
    public partial class ControlCheque : Form
    {
        public ControlCheque()
        {
            InitializeComponent();

         
        }

        private void ControlCheque_Load(object sender, EventArgs e)
        {
        
        string[] direcionArchivo =  Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.csv");

            foreach (string archivo in direcionArchivo) {
               
                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] dat = null;
                foreach (string tex in texto) {
                   dat= tex.Split(',');
                    dataGridView1.Rows.Add(dat);
                }
              
             
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
