namespace pryCapelloArticulos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cboRubros = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRubros = new System.Windows.Forms.Label();
            this.lblArticulosListados = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMuestraArticulos = new System.Windows.Forms.Label();
            this.lblMuestraTotal = new System.Windows.Forms.Label();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRubros
            // 
            this.cboRubros.FormattingEnabled = true;
            this.cboRubros.Location = new System.Drawing.Point(83, 325);
            this.cboRubros.Margin = new System.Windows.Forms.Padding(4);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.Size = new System.Drawing.Size(195, 24);
            this.cboRubros.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.dgvArticulos);
            this.panel1.Controls.Add(this.cboRubros);
            this.panel1.Controls.Add(this.lblRubros);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 368);
            this.panel1.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(556, 325);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(164, 27);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar Rubro";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(343, 325);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 27);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Rubro";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCosto,
            this.colStock,
            this.colValorStock});
            this.dgvArticulos.Location = new System.Drawing.Point(16, 15);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(704, 294);
            this.dgvArticulos.TabIndex = 2;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigo.Width = 70;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.MinimumWidth = 6;
            this.colCosto.Name = "colCosto";
            this.colCosto.Width = 70;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.Width = 70;
            // 
            // colValorStock
            // 
            this.colValorStock.HeaderText = "Valor en Stock";
            this.colValorStock.MinimumWidth = 6;
            this.colValorStock.Name = "colValorStock";
            this.colValorStock.Width = 70;
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(12, 329);
            this.lblRubros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(57, 18);
            this.lblRubros.TabIndex = 1;
            this.lblRubros.Text = "Rubros";
            // 
            // lblArticulosListados
            // 
            this.lblArticulosListados.AutoSize = true;
            this.lblArticulosListados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosListados.Location = new System.Drawing.Point(179, 396);
            this.lblArticulosListados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulosListados.Name = "lblArticulosListados";
            this.lblArticulosListados.Size = new System.Drawing.Size(125, 18);
            this.lblArticulosListados.TabIndex = 3;
            this.lblArticulosListados.Text = "Artículos Listados";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(409, 396);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total del Valor";
            // 
            // lblMuestraArticulos
            // 
            this.lblMuestraArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraArticulos.Location = new System.Drawing.Point(312, 395);
            this.lblMuestraArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraArticulos.Name = "lblMuestraArticulos";
            this.lblMuestraArticulos.Size = new System.Drawing.Size(75, 22);
            this.lblMuestraArticulos.TabIndex = 5;
            // 
            // lblMuestraTotal
            // 
            this.lblMuestraTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraTotal.Location = new System.Drawing.Point(519, 395);
            this.lblMuestraTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraTotal.Name = "lblMuestraTotal";
            this.lblMuestraTotal.Size = new System.Drawing.Size(75, 22);
            this.lblMuestraTotal.TabIndex = 7;
            // 
            // linkPerfil
            // 
            this.linkPerfil.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.linkPerfil.LinkColor = System.Drawing.Color.Gray;
            this.linkPerfil.Location = new System.Drawing.Point(703, 398);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(37, 16);
            this.linkPerfil.TabIndex = 8;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Perfil";
            this.linkPerfil.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 431);
            this.Controls.Add(this.linkPerfil);
            this.Controls.Add(this.lblMuestraTotal);
            this.Controls.Add(this.lblMuestraArticulos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblArticulosListados);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRubros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblArticulosListados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblMuestraArticulos;
        private System.Windows.Forms.Label lblMuestraTotal;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorStock;
        private System.Windows.Forms.LinkLabel linkPerfil;
    }
}

