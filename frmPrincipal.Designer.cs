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
            this.cboRubros = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRubros = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblArticulosListados = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMuestraArticulos = new System.Windows.Forms.Label();
            this.lblMuestraTotal = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRubros
            // 
            this.cboRubros.FormattingEnabled = true;
            this.cboRubros.Location = new System.Drawing.Point(62, 264);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.Size = new System.Drawing.Size(147, 21);
            this.cboRubros.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cboRubros);
            this.panel1.Controls.Add(this.lblRubros);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 299);
            this.panel1.TabIndex = 1;
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(9, 267);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(47, 15);
            this.lblRubros.TabIndex = 1;
            this.lblRubros.Text = "Rubros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCosto,
            this.colStock,
            this.colValorStock});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 239);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblArticulosListados
            // 
            this.lblArticulosListados.AutoSize = true;
            this.lblArticulosListados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosListados.Location = new System.Drawing.Point(134, 322);
            this.lblArticulosListados.Name = "lblArticulosListados";
            this.lblArticulosListados.Size = new System.Drawing.Size(102, 15);
            this.lblArticulosListados.TabIndex = 3;
            this.lblArticulosListados.Text = "Artículos Listados";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(307, 322);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total del Valor";
            // 
            // lblMuestraArticulos
            // 
            this.lblMuestraArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraArticulos.Location = new System.Drawing.Point(242, 322);
            this.lblMuestraArticulos.Name = "lblMuestraArticulos";
            this.lblMuestraArticulos.Size = new System.Drawing.Size(46, 18);
            this.lblMuestraArticulos.TabIndex = 5;
            // 
            // lblMuestraTotal
            // 
            this.lblMuestraTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraTotal.Location = new System.Drawing.Point(401, 321);
            this.lblMuestraTotal.Name = "lblMuestraTotal";
            this.lblMuestraTotal.Size = new System.Drawing.Size(46, 18);
            this.lblMuestraTotal.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(257, 264);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 22);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Rubro";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(417, 264);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(123, 22);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar Rubro";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 200;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.Width = 70;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Width = 70;
            // 
            // colValorStock
            // 
            this.colValorStock.HeaderText = "Valor en Stock";
            this.colValorStock.Name = "colValorStock";
            this.colValorStock.Width = 70;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 350);
            this.Controls.Add(this.lblMuestraTotal);
            this.Controls.Add(this.lblMuestraArticulos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblArticulosListados);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Consultar Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRubros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

