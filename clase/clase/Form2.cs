using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace clase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            ArrayList fuente = new ArrayList();
            string[] campos = new string[4];

            campos[0] = txtnombre.Text;
            campos[1] = txtmateria.Text;
            campos[2] = txtnivel.Text;
            campos[3] = txtcolumna.Text;
            fuente.Add(campos);

            foreach (string[] item in fuente)
            {
                dataGridView1.Rows.Add(item);
            }
            //dataGridView1.DataSource = fuente;


        }

        private void button1_Click(object sender, EventArgs e)
        {


            dataGridView1.Columns.Add(txtcolumna.Text, txtcolumna.Text);
        }
    }
}
