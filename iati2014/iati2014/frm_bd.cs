using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iati2014
{
    public partial class frm_bd : Form
    {
        public frm_bd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase_directorio loquesea = new Clase_directorio();

            DataTable info = new DataTable();

            info = loquesea.MtdConsultarCFDI_Validados();

            dataGridView1.DataSource = info;


        }
    }
}
