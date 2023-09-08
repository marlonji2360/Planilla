namespace Planilla
{
    partial class frmVerDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerDatos));
            this.btnTrxPlanillas = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnCopiarConclusion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrxPlanillas
            // 
            this.btnTrxPlanillas.Location = new System.Drawing.Point(116, 139);
            this.btnTrxPlanillas.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrxPlanillas.Name = "btnTrxPlanillas";
            this.btnTrxPlanillas.Size = new System.Drawing.Size(87, 34);
            this.btnTrxPlanillas.TabIndex = 0;
            this.btnTrxPlanillas.Text = "Trx. Planillas";
            this.btnTrxPlanillas.UseVisualStyleBackColor = true;
            this.btnTrxPlanillas.Click += new System.EventHandler(this.btnTrxPlanillas_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Location = new System.Drawing.Point(25, 139);
            this.btnVerClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(87, 34);
            this.btnVerClientes.TabIndex = 1;
            this.btnVerClientes.Text = "Clientes Activos";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnCopiarConclusion
            // 
            this.btnCopiarConclusion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopiarConclusion.BackgroundImage")));
            this.btnCopiarConclusion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopiarConclusion.Location = new System.Drawing.Point(672, 139);
            this.btnCopiarConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopiarConclusion.Name = "btnCopiarConclusion";
            this.btnCopiarConclusion.Size = new System.Drawing.Size(37, 34);
            this.btnCopiarConclusion.TabIndex = 95;
            this.btnCopiarConclusion.UseVisualStyleBackColor = true;
            this.btnCopiarConclusion.Click += new System.EventHandler(this.btnCopiarConclusion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(239, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 42);
            this.lblTitulo.TabIndex = 128;
            this.lblTitulo.Text = "Visualizar Datos";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(25, 178);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(684, 321);
            this.dgvDatos.TabIndex = 129;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(732, 31);
            this.toolStrip1.TabIndex = 130;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmVerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 511);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCopiarConclusion);
            this.Controls.Add(this.btnVerClientes);
            this.Controls.Add(this.btnTrxPlanillas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVerDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualización De Datos";
            this.Load += new System.EventHandler(this.frmVerDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrxPlanillas;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnCopiarConclusion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}