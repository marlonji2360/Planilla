using Planilla.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla
{
    public partial class frmPlanilla : Form
    {
        private bool insertar = true;
        private int id;


        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]

        private static extern IntPtr GetSystemMenu(IntPtr hwnd, int revert);

        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]

        private static extern int GetMenuItemCount(IntPtr hmenu);

        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]

        private static extern int RemoveMenu(IntPtr hmenu, int npos, int wflags);

        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]

        private static extern int DrawMenuBar(IntPtr hwnd);

        private const int MF_BYPOSITION = 0x0400;

        private const int MF_DISABLED = 0x0002;
        public frmPlanilla()
        {
            IntPtr hmenu = GetSystemMenu(this.Handle, 0);

            int cnt = GetMenuItemCount(hmenu);

            // remove 'close' action

            RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);

            // remove extra menu line

            RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);
            InitializeComponent();
        }

        private void limpiar()
        {
            txtNombrePlanilla.Text = "";
            txtNoPlanilla.Text = "";
            insertar = true;
        }

        private void MostraPlanilla()
        {
            Planillas planillas = new Planillas();
            dgvPlanillas.DataSource = planillas.ConsultarPlanilla();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            MostraPlanilla();
            txtNoPlanilla.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (insertar == true)
            {
                Planillas obj = new Planillas();
                obj.IngresarPlanilla(int.Parse(txtNoPlanilla.Text), txtNombrePlanilla.Text);
                limpiar();
                MostraPlanilla();
            }

            else
            {
                Planillas obj = new Planillas();
                obj.EditarPlanilla(id,int.Parse(txtNoPlanilla.Text), txtNombrePlanilla.Text);
                limpiar();
                MostraPlanilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlanillas.SelectedRows.Count > 0)
            {
                insertar = false;
                id = int.Parse(dgvPlanillas.CurrentRow.Cells["ID"].Value.ToString());
                txtNoPlanilla.Text = dgvPlanillas.CurrentRow.Cells["NO_PLANILLA"].Value.ToString();
                txtNombrePlanilla.Text = dgvPlanillas.CurrentRow.Cells["NOMBRE_PLANILLA"].Value.ToString();


            }
            else
                MessageBox.Show("Debe seleccionar toda una fila");
        }

        private void btnNuevp_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
