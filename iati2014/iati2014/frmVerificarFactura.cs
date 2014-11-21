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
    public partial class frmVerificarFactura : Form
    {
        public frmVerificarFactura()
        {
            InitializeComponent();
        }

        private void cmd_revisa_factura_Click(object sender, EventArgs e)
        {
            ServiceReference1.ConsultaCFDIServiceClient abc = new ServiceReference1.ConsultaCFDIServiceClient();

            ServiceReference1.Acuse _acuse = new Acuse();


            _acuse = abc.Consulta(txtcadena.Text);

            lbl_notificacion.Text = _acuse.CodigoEstatus + "-" + _acuse.Estado;
        }
    }
}
