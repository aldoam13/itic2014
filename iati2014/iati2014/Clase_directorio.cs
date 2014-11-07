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

    }
}
