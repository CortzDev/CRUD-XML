using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Agregar : Form

    {

        public Boolean _Procesar = false;

        public bool Procesar { get => _Procesar; set => _Procesar = value; }

        public TextBox agreagar;

        public string rutaFotoSeleccionada = "";

        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFotoSeleccionada = openFileDialog.FileName;

                if (File.Exists(rutaFotoSeleccionada))
                {
                    lbDisponible.Text = "";
                    pbPre.Image = Image.FromFile(rutaFotoSeleccionada);
                    pbPre.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbPre.Image = null;
                    pbPre.SizeMode = PictureBoxSizeMode.Normal;
                }
            }
            pbPre.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _Procesar = true; 
            this.Close();    
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
