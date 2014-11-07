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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog abredirectorio = new SaveFileDialog();

            abredirectorio.ShowDialog();


            Clase_directorio nuevo_registro = new Clase_directorio();

            nuevo_registro.ruta = abredirectorio.FileName;

            nuevo_registro.creadirectorio(TXT_NOMBRE.Text, TXT_MATERIA.Text, TXTNIVEL.Text);

        }
    }
}
