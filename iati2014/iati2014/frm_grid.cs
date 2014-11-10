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

        private void cmd_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirarchivo = new OpenFileDialog();
            abrirarchivo.ShowDialog();

            

            StreamReader expediente = new StreamReader(abrirarchivo.FileName);
            string linea = "";
                

            ArrayList listado = new ArrayList();

            while (linea != null)
            {
                linea = expediente.ReadLine();
                if (linea != null)
                {
                    
                    listado.Add(linea);
                }
            }
            expediente.Close();


            ArrayList nuevo_registro = new ArrayList();
            foreach (string alumno in listado)
            {
                string[] separadores = { "NOMBRE:", "- MATERIA:", "- NIVEL:" };
                string[] resultado = alumno.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

                //A TRAVES DE MISMO ARRAY.

            //    dataGridView1.Rows.Add(resultado);

                // A TRAVES DE UN ARRAY LIST

             
                nuevo_registro.Add(resultado);
                
            }

            foreach (string[] item in nuevo_registro)
            {
                dataGridView1.Rows.Add(item);
            }

        }
    }
}
