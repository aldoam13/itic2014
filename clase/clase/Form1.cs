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

namespace clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();


            StreamReader objReader = new StreamReader(openFileDialog1.FileName);
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (string sOutput in arrText)
            {

                string[] separadores={"NOMBRE:","MATERIA:","NIVEL:"};
                string[] var = sOutput.Split(separadores,StringSplitOptions.RemoveEmptyEntries);
              //  textBox1.AppendText(sOutput);
            }
       
        }
    }
}
