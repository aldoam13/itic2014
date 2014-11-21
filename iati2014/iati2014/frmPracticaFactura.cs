using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iati2014.ServiceReference1;

namespace iati2014
{
    public partial class frmPracticaFactura : Form
    {
        public frmPracticaFactura()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog cargar_imagen = new OpenFileDialog();
            try
            {
                cargar_imagen.ShowDialog();

                pictureBox1.Image = Image.FromFile(cargar_imagen.FileName);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdValida_Click(object sender, EventArgs e)
        {
            try
            {
             ServiceReference1.ConsultaCFDIServiceClient abc = new ServiceReference1.ConsultaCFDIServiceClient();

             ServiceReference1.Acuse _acuse = new Acuse();

              _acuse = abc.Consulta(txtFactura.Text);


              string factura = txtFactura.Text;
             
                //?re=RDI841003QJ4&rr=AAMA830827MS4&tt=0000000507.920000&id=58817943-53B6-4653-A688-4E695BA74424

              string[] separadores = { "?re=", "&rr=", "&tt=","&id=" };
              string[] resultado = factura.Split(separadores, StringSplitOptions.RemoveEmptyEntries);


              Clase_directorio nueva_factura = new Clase_directorio();

              SaveFileDialog abre_ruta = new SaveFileDialog();
              abre_ruta.ShowDialog();

              nueva_factura.ruta = abre_ruta.FileName;
              nueva_factura.guarda_factura(txtNombre.Text, txtDomicilio.Text, resultado[0], resultado[1], resultado[2], resultado[3], _acuse.Estado);



            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                
                throw;
            }


           

        }
    }
}
