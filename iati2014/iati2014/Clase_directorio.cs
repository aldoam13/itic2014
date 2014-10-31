using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace iati2014
{
    class Clase_directorio
    {
        public string ruta { get; set; }

       // private string ruta2 = @"C:\directorios\miarchivo.txt";


        //RECIBE TRES PARAMETROS PARA GUARDAR
        public bool creadirectorio(string nombre, string materia, string nivel)
        {
            if (!File.Exists(ruta))
            {
                StreamWriter instancia = File.CreateText(ruta);

                instancia.Close();
            }

            string documento = "NOMBRE: " + nombre+" - MATERIA: "+ materia + " - NIVEL: "+nivel;

            StreamWriter guardar = new StreamWriter(ruta, true);

            guardar.Write(documento);

            guardar.Close();

            //MessageBox.Show(documento);
            return true;
           }

    }
}
