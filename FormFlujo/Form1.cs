using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.IO;

namespace FormFlujo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string NameFichero;
        Persona objPersona = new Persona();


        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog seleccionar = new SaveFileDialog();
            DialogResult result = seleccionar.ShowDialog();
            
            if(result== DialogResult.Cancel)
            {
                return;

            }

            NameFichero = seleccionar.FileName;

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameFichero))
            {
                MessageBox.Show("No se ha guardado ningun fichero");
                return;
            }

            objPersona = new Persona()
            {
                Nombre1 = txtname.Text,
                Apellido1 = txtap.Text,
                Edad1 = Convert.ToInt32(txtage.Text),
                Cedula1 = txtdni.Text

            };

            using (FileStream fs = new FileStream(NameFichero, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(objPersona.Nombre1+ "" +objPersona.Apellido1+ "" +objPersona.Edad1+ "" +objPersona.Cedula1+ "");
                }
            }



        }
    }
}
