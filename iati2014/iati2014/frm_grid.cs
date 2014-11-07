using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace iati2014
{
    public partial class frm_grid : Form
    {
        public frm_grid()
        {
            InitializeComponent();
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            ArrayList inche = new ArrayList();
            string[] datos = new string[3];

            datos[0] = txtnombre.Text;
            datos[1] = txtmateria.Text;
            datos[2] = txtnivel.Text;

            inche.Add(datos);

            foreach (string[] item in inche)
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
