using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;





namespace iati2014
{
    class Clase_directorio
    {
        DataTable dtfacturas = new DataTable();

        public string ruta { get; set; }  //<-- PROPIEDAD "RUTA", DE LA CLASE "CLASE_DIRECTORIO"

       // private string ruta2 = @"C:\directorios\miarchivo.txt";  <-- VARIABLE TEMPORAL


        //RECIBE TRES PARAMETROS PARA GUARDAR
        public bool creadirectorio(string nombre, string materia, string nivel)// <-- METODO DE LA CLASE "CLASE_DIRECTORIO"
        {
            if (!File.Exists(ruta))//EVALUA SI EXISTE LA RUTA SEÑADA O LA CREA NUEVA
            {
                StreamWriter instancia = File.CreateText(ruta);
                instancia.Close();
            }

            string documento = "NOMBRE: " + nombre+" - MATERIA: "+ materia + " - NIVEL: "+nivel;

            StreamWriter guardar = new StreamWriter(ruta, true);

            guardar.Write(documento);

            guardar.Close();

            return true;
           }


        public bool guarda_factura(string _nombre, string _domicilio, string _rfcemisor, string _rfcreceptor, string _monto, string _uuid, string _estado)
        {
            if (!File.Exists(ruta))
            {
                StreamWriter archivo = File.CreateText(ruta);
                archivo.Close();
            }


            string registros = "NOMBRE: " + _nombre + "DOMICILIO: " + _domicilio + "PROVEEDOR: " + _rfcemisor + "CLIENTE: " + _rfcreceptor + "MONTO: " + _monto + "UUID: " + _uuid+ "ESTADO: "+_estado;
            StreamWriter guarda_factura = new StreamWriter(ruta,true);
            guarda_factura.Write(registros);
            guarda_factura.Close();

            return true;
        }


        public DataTable MtdConsultarCFDI_Validados()
        {
            try
            {

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = Properties.Settings.Default.conexion;
                conn.Open();
                MySqlCommand comand = conn.CreateCommand();

                string createTable = "SELECT  id,rfcproveedor as PROVEEDOR,frccliente AS CLIENTE ,montofactura AS MONTO ,uuid AS UUDI,codigoestadofactura 'CODIGO FACTURA',estadofactura AS 'ESTADO FACTURA',fechacreacion AS FECHA  FROM gob_sis_cfdi.facturas order by id desc limit 0,50 ;";
                comand = new MySqlCommand(createTable, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                sda.SelectCommand = comand;
                sda.Fill(dt);
                dtfacturas = dt;
                conn.Close();
            }
            catch (MySqlException err)
            {
                string error = err.Message;


            }

            return dtfacturas;
        }

    }
}
