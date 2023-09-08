namespace Planilla
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblCargaCsv = new System.Windows.Forms.Label();
            this.btnCargarCsv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrxEq = new System.Windows.Forms.Button();
            this.lblRti = new System.Windows.Forms.Label();
            this.btnTiposPlanilla = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVerDatos = new System.Windows.Forms.Label();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCargaCsv
            // 
            this.lblCargaCsv.AutoSize = true;
            this.lblCargaCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaCsv.ForeColor = System.Drawing.Color.Black;
            this.lblCargaCsv.Location = new System.Drawing.Point(77, 112);
            this.lblCargaCsv.Name = "lblCargaCsv";
            this.lblCargaCsv.Size = new System.Drawing.Size(85, 13);
            this.lblCargaCsv.TabIndex = 93;
            this.lblCargaCsv.Text = "Cargar Datos ";
            // 
            // btnCargarCsv
            // 
            this.btnCargarCsv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarCsv.BackgroundImage")));
            this.btnCargarCsv.Location = new System.Drawing.Point(77, 128);
            this.btnCargarCsv.Name = "btnCargarCsv";
            this.btnCargarCsv.Size = new System.Drawing.Size(77, 70);
            this.btnCargarCsv.TabIndex = 92;
            this.btnCargarCsv.UseVisualStyleBackColor = true;
            this.btnCargarCsv.Click += new System.EventHandler(this.btnCargarCsv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Trx. Equivalentes";
            // 
            // btnTrxEq
            // 
            this.btnTrxEq.Image = ((System.Drawing.Image)(resources.GetObject("btnTrxEq.Image")));
            this.btnTrxEq.Location = new System.Drawing.Point(80, 257);
            this.btnTrxEq.Name = "btnTrxEq";
            this.btnTrxEq.Size = new System.Drawing.Size(77, 70);
            this.btnTrxEq.TabIndex = 94;
            this.btnTrxEq.UseVisualStyleBackColor = true;
            this.btnTrxEq.Click += new System.EventHandler(this.btnTrxEq_Click);
            // 
            // lblRti
            // 
            this.lblRti.AutoSize = true;
            this.lblRti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRti.ForeColor = System.Drawing.Color.Black;
            this.lblRti.Location = new System.Drawing.Point(257, 241);
            this.lblRti.Name = "lblRti";
            this.lblRti.Size = new System.Drawing.Size(83, 13);
            this.lblRti.TabIndex = 101;
            this.lblRti.Text = "Tipos Planilla";
            // 
            // btnTiposPlanilla
            // 
            this.btnTiposPlanilla.Image = ((System.Drawing.Image)(resources.GetObject("btnTiposPlanilla.Image")));
            this.btnTiposPlanilla.Location = new System.Drawing.Point(260, 257);
            this.btnTiposPlanilla.Name = "btnTiposPlanilla";
            this.btnTiposPlanilla.Size = new System.Drawing.Size(77, 70);
            this.btnTiposPlanilla.TabIndex = 100;
            this.btnTiposPlanilla.UseVisualStyleBackColor = true;
            this.btnTiposPlanilla.Click += new System.EventHandler(this.btnTiposPlanilla_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(404, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(30, 356);
            this.toolStrip1.TabIndex = 102;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(57, 31);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 37);
            this.lblTitulo.TabIndex = 103;
            this.lblTitulo.Text = "MENÚ PRINCIPAL";
            // 
            // lblVerDatos
            // 
            this.lblVerDatos.AutoSize = true;
            this.lblVerDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerDatos.ForeColor = System.Drawing.Color.Black;
            this.lblVerDatos.Location = new System.Drawing.Point(250, 112);
            this.lblVerDatos.Name = "lblVerDatos";
            this.lblVerDatos.Size = new System.Drawing.Size(98, 13);
            this.lblVerDatos.TabIndex = 105;
            this.lblVerDatos.Text = "Visualizar Datos";
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerDatos.Image")));
            this.btnVerDatos.Location = new System.Drawing.Point(260, 128);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(77, 70);
            this.btnVerDatos.TabIndex = 104;
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 356);
            this.Controls.Add(this.lblVerDatos);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblRti);
            this.Controls.Add(this.btnTiposPlanilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrxEq);
            this.Controls.Add(this.lblCargaCsv);
            this.Controls.Add(this.btnCargarCsv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargaCsv;
        private System.Windows.Forms.Button btnCargarCsv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrxEq;
        private System.Windows.Forms.Label lblRti;
        private System.Windows.Forms.Button btnTiposPlanilla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVerDatos;
        private System.Windows.Forms.Button btnVerDatos;
    }
}