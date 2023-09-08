namespace Planilla
{
    partial class frmPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanilla));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombrePlanilla = new System.Windows.Forms.TextBox();
            this.lblNombrePlanilla = new System.Windows.Forms.Label();
            this.txtNoPlanilla = new System.Windows.Forms.TextBox();
            this.lblNoPlanilla = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPlanillas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(445, 132);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 128;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombrePlanilla
            // 
            this.txtNombrePlanilla.Location = new System.Drawing.Point(165, 134);
            this.txtNombrePlanilla.Name = "txtNombrePlanilla";
            this.txtNombrePlanilla.Size = new System.Drawing.Size(263, 20);
            this.txtNombrePlanilla.TabIndex = 124;
            // 
            // lblNombrePlanilla
            // 
            this.lblNombrePlanilla.AutoSize = true;
            this.lblNombrePlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlanilla.ForeColor = System.Drawing.Color.Black;
            this.lblNombrePlanilla.Location = new System.Drawing.Point(41, 135);
            this.lblNombrePlanilla.Name = "lblNombrePlanilla";
            this.lblNombrePlanilla.Size = new System.Drawing.Size(118, 16);
            this.lblNombrePlanilla.TabIndex = 127;
            this.lblNombrePlanilla.Text = "Nombre Planilla";
            // 
            // txtNoPlanilla
            // 
            this.txtNoPlanilla.Location = new System.Drawing.Point(165, 108);
            this.txtNoPlanilla.Name = "txtNoPlanilla";
            this.txtNoPlanilla.Size = new System.Drawing.Size(262, 20);
            this.txtNoPlanilla.TabIndex = 123;
            // 
            // lblNoPlanilla
            // 
            this.lblNoPlanilla.AutoSize = true;
            this.lblNoPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPlanilla.ForeColor = System.Drawing.Color.Black;
            this.lblNoPlanilla.Location = new System.Drawing.Point(72, 109);
            this.lblNoPlanilla.Name = "lblNoPlanilla";
            this.lblNoPlanilla.Size = new System.Drawing.Size(87, 16);
            this.lblNoPlanilla.TabIndex = 126;
            this.lblNoPlanilla.Text = "No. Planilla";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(697, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 125;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(363, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 31);
            this.lblTitulo.TabIndex = 122;
            this.lblTitulo.Text = "Planilla";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPlanillas
            // 
            this.dgvPlanillas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillas.Location = new System.Drawing.Point(28, 214);
            this.dgvPlanillas.Name = "dgvPlanillas";
            this.dgvPlanillas.RowHeadersWidth = 62;
            this.dgvPlanillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanillas.Size = new System.Drawing.Size(744, 218);
            this.dgvPlanillas.TabIndex = 121;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevp,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 129;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevp
            // 
            this.btnNuevp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevp.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevp.Image")));
            this.btnNuevp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevp.Name = "btnNuevp";
            this.btnNuevp.Size = new System.Drawing.Size(28, 28);
            this.btnNuevp.Text = "Nuevo";
            this.btnNuevp.Click += new System.EventHandler(this.btnNuevp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombrePlanilla);
            this.Controls.Add(this.lblNombrePlanilla);
            this.Controls.Add(this.txtNoPlanilla);
            this.Controls.Add(this.lblNoPlanilla);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPlanillas);
            this.Name = "frmPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla";
            this.Load += new System.EventHandler(this.frmPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombrePlanilla;
        private System.Windows.Forms.Label lblNombrePlanilla;
        private System.Windows.Forms.TextBox txtNoPlanilla;
        private System.Windows.Forms.Label lblNoPlanilla;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvPlanillas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}