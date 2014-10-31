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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_creadirectorio_Click(object sender, EventArgs e)
        {
          
            saveFileDialog1.ShowDialog();

            string ruta2 = saveFileDialog1.FileName;

            Clase_directorio crear = new Clase_directorio();

            crear.ruta = ruta2;

            crear.creadirectorio(txt_nombre.Text, txt_materia.Text, txt_nivel.Text);
        }
    }
}
