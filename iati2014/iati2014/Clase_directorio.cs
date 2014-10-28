using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace iati2014
{
    class Clase_directorio
    {
        public string ruta { get; set; }

        private string ruta2 = @"C:\directorios\miarchivo.txt";

        public bool creadirectorio(string texto)
        {
            if (!File.Exists(ruta2))
            {
                StreamWriter instancia = File.CreateText(ruta2);
            }


            return true;
           }

    }
}
