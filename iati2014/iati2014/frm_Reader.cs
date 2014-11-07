using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace iati2014
{
    public partial class frm_Reader : Form
    {
        public frm_Reader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirarchivo = new OpenFileDialog();
            abrirarchivo.ShowDialog();

            txt_ruta.Text = abrirarchivo.FileName;

            StreamReader expediente = new StreamReader(abrirarchivo.FileName);
            string linea = "";
            ArrayList listado = new ArrayList();

            while (linea != null)
            {
                linea = expediente.ReadLine();
                if (linea !=null)
                {
                    listado.Add(linea);
                }
            }
            expediente.Close();

            foreach(string alumno in listado)
            {
                txt_listado.AppendText(alumno);
            }

        }
    }
}
