using Planilla.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla
{
    public partial class frmTransaccionesEquivalentes : Form
    {
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

        private bool insertar = true;
        private int id;
        public frmTransaccionesEquivalentes()
        {

            IntPtr hmenu = GetSystemMenu(this.Handle, 0);

            int cnt = GetMenuItemCount(hmenu);

            // remove 'close' action

            RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);

            // remove extra menu line

            RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);
            InitializeComponent();
        }

        private void frmTransaccionesEquivalentes_Load(object sender, EventArgs e)
        {
            MostrarTransacciones();
            txtTransaccion.Focus();
        }

        private void limpiar()
        {
            txtTransaccion.Text = "";
            txtEquivante.Text = "";
            insertar = true;
        }

        private void MostrarTransacciones()
        {
            TransaccionEquivalente objTE = new TransaccionEquivalente();
            dgvTransacciones.DataSource = objTE.ConsultarTransacciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (insertar == true)
            {
                TransaccionEquivalente objTE = new TransaccionEquivalente();
                objTE.InsertarTransacciones(txtTransaccion.Text,txtEquivante.Text);
                limpiar();
                MostrarTransacciones();
            }

            else
            {
                TransaccionEquivalente objTE = new TransaccionEquivalente();
                objTE.EditarTransacciones(id, txtTransaccion.Text, txtEquivante.Text);
                limpiar();
                MostrarTransacciones();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.SelectedRows.Count > 0)
            {
                insertar = false;
                id = int.Parse(dgvTransacciones.CurrentRow.Cells["ID"].Value.ToString());
                txtTransaccion.Text = dgvTransacciones.CurrentRow.Cells["TRANSACCION"].Value.ToString();
                txtEquivante.Text = dgvTransacciones.CurrentRow.Cells["EQUIVALENTE"].Value.ToString();
                

            }
            else
                MessageBox.Show("Debe seleccionar toda una fila");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void btnNuevp_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
