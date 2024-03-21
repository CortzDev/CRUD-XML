using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Gestion : Form
    {
        DataTable _Datos = new DataTable();
        string rutaArchivoXML = "datos.xml";
        public Gestion()
        {
            InitializeComponent();
            ConfigurarTabla();
            CargarDatosDesdeXML();
        }

        private void ConfigurarTabla()
        {
            _Datos.TableName = "Informacion";
            _Datos.Columns.Add("cSolicitante", typeof(string));
            _Datos.Columns.Add("cDepartamento", typeof(string));
            _Datos.Columns.Add("cDestinatario", typeof(string));
            _Datos.Columns.Add("cEquipo", typeof(string));
            _Datos.Columns.Add("cDetalles", typeof(string));
            _Datos.Columns.Add("cFecha", typeof(DateTime));
            _Datos.Columns.Add("cFotografia", typeof(string));

            dtvDatos.AutoGenerateColumns = false;
            dtvDatos.DataSource = _Datos;
        }

        private void CargarDatosDesdeXML()
        {
            if (File.Exists(rutaArchivoXML))
            {
                _Datos.Clear();
                _Datos.ReadXml(rutaArchivoXML);
            }
        }

        private void GuardarDatosEnXML()
        {
            _Datos.WriteXml(rutaArchivoXML);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agregar f = new Agregar();
            f.ShowDialog();

            if (f.Procesar)
            {
                try
                {
                    DataRow nuevaFila = _Datos.NewRow();

                    nuevaFila["cSolicitante"] = f.txtSolicitante.Text;
                    nuevaFila["cDepartamento"] = f.txtDepartamento.Text;
                    nuevaFila["cDestinatario"] = f.txtDestinatario.Text;
                    nuevaFila["cEquipo"] = f.txtEquipo.Text;
                    nuevaFila["cDetalles"] = f.txtDetalles.Text;
                    nuevaFila["cFecha"] = f.dtpFecha.Value;

                    nuevaFila["cFotografia"] = f.rutaFotoSeleccionada;

                    _Datos.Rows.Add(nuevaFila);

                    MessageBox.Show("Registro agregado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GuardarDatosEnXML(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar ingresar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_Datos.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para editar. Por favor, agregue usuarios antes de intentar editar.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Quiere eliminar el registro?", "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int rowIndex = dtvDatos.CurrentRow.Index;
                    _Datos.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Registro eliminado", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GuardarDatosEnXML(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btsEdit_Click(object sender, EventArgs e)
        {
            if (_Datos.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para editar. Por favor, agregue usuarios antes de intentar editar.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            if (MessageBox.Show("¿Quiere editar el registro?", "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Agregar f = new Agregar();

                DataGridViewRow selectedRow = dtvDatos.CurrentRow;

                f.txtSolicitante.Text = selectedRow.Cells["Solicitante"].Value.ToString();
                f.txtDepartamento.Text = selectedRow.Cells["Departamento"].Value.ToString();
                f.txtDestinatario.Text = selectedRow.Cells["Destinatario"].Value.ToString();
                f.txtEquipo.Text = selectedRow.Cells["Equipo"].Value.ToString();
                f.txtDetalles.Text = selectedRow.Cells["Detalles"].Value.ToString();
                f.dtpFecha.Value = (DateTime)selectedRow.Cells["Fecha"].Value;


                string rutaFoto = selectedRow.Cells["Fotografia"].Value.ToString();
                if (File.Exists(rutaFoto))
                {
                    f.lbDisponible.Text = "";
                    f.rutaFotoSeleccionada = rutaFoto;
                    f.pbPre.Image = Image.FromFile(rutaFoto);
                    f.pbPre.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                f.ShowDialog();

                if (f.Procesar)
                {
                    try
                    {
                        selectedRow.Cells["Solicitante"].Value = f.txtSolicitante.Text;
                        selectedRow.Cells["Departamento"].Value = f.txtDepartamento.Text;
                        selectedRow.Cells["Destinatario"].Value = f.txtDestinatario.Text;
                        selectedRow.Cells["Equipo"].Value = f.txtEquipo.Text;
                        selectedRow.Cells["Detalles"].Value = f.txtDetalles.Text;
                        selectedRow.Cells["Fecha"].Value = f.dtpFecha.Value;

                        selectedRow.Cells["Fotografia"].Value = f.rutaFotoSeleccionada;

                        MessageBox.Show("Registro editado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GuardarDatosEnXML();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al intentar editar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
    }
}
