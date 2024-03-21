
namespace Parcial_1
{
    partial class Gestion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVista1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.btsEdit,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnVista1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(858, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 24);
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btsEdit
            // 
            this.btsEdit.Image = ((System.Drawing.Image)(resources.GetObject("btsEdit.Image")));
            this.btsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btsEdit.Name = "btsEdit";
            this.btsEdit.Size = new System.Drawing.Size(72, 24);
            this.btsEdit.Text = "Editar";
            this.btsEdit.Click += new System.EventHandler(this.btsEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 24);
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnVista1
            // 
            this.btnVista1.Image = ((System.Drawing.Image)(resources.GetObject("btnVista1.Image")));
            this.btnVista1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVista1.Name = "btnVista1";
            this.btnVista1.Size = new System.Drawing.Size(109, 24);
            this.btnVista1.Text = "Vista Previa";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dtvDatos
            // 
            this.dtvDatos.AllowUserToAddRows = false;
            this.dtvDatos.AllowUserToDeleteRows = false;
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solicitante,
            this.Departamento,
            this.Destinatario,
            this.Equipo,
            this.Detalles,
            this.Fecha,
            this.Fotografia});
            this.dtvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvDatos.Location = new System.Drawing.Point(0, 27);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.ReadOnly = true;
            this.dtvDatos.RowHeadersWidth = 51;
            this.dtvDatos.RowTemplate.Height = 24;
            this.dtvDatos.Size = new System.Drawing.Size(858, 414);
            this.dtvDatos.TabIndex = 3;
            // 
            // Solicitante
            // 
            this.Solicitante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Solicitante.DataPropertyName = "cSolicitante";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.MinimumWidth = 6;
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.DataPropertyName = "cDepartamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Destinatario
            // 
            this.Destinatario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destinatario.DataPropertyName = "cDestinatario";
            this.Destinatario.HeaderText = "Destinatario";
            this.Destinatario.MinimumWidth = 6;
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.ReadOnly = true;
            // 
            // Equipo
            // 
            this.Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Equipo.DataPropertyName = "cEquipo";
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.MinimumWidth = 6;
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalles.DataPropertyName = "cDetalles";
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "cFecha";
            this.Fecha.HeaderText = "Fecha de la Solicitud";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Fotografia
            // 
            this.Fotografia.DataPropertyName = "cFotografia";
            this.Fotografia.HeaderText = "Fotografia";
            this.Fotografia.MinimumWidth = 6;
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.ReadOnly = true;
            this.Fotografia.Width = 125;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 463);
            this.Controls.Add(this.dtvDatos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnVista1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotografia;
    }
}

