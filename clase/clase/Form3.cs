using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clase.ServiceReference1;

namespace clase
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ConsultaCFDIServiceClient abc = new ServiceReference1.ConsultaCFDIServiceClient();
            ServiceReference1.Acuse _acuse = new Acuse();

            _acuse = abc.Consulta(textBox1.Text);


            MessageBox.Show("Estatus " + _acuse.CodigoEstatus + " Estado: " + _acuse.Estado);
        }
    }
}
