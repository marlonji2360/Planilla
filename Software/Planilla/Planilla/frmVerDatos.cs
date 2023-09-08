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
    public partial class frmVerDatos : Form
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
        public frmVerDatos()
        {
            IntPtr hmenu = GetSystemMenu(this.Handle, 0);

            int cnt = GetMenuItemCount(hmenu);

            // remove 'close' action

            RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);

            // remove extra menu line

            RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);
            InitializeComponent();
        }

        private void MostrarTrxPlanilla()
        {
            Planillas planillas = new Planillas();
            dgvDatos.DataSource = planillas.ConsultarTrxPlanilla();
        }

        private void MostrarClientesActivos()
        {
            Planillas planillas = new Planillas();
            dgvDatos.DataSource = planillas.ConsultarClientesActivos();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            MostrarClientesActivos();

        }

        private void btnTrxPlanillas_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;            
            MostrarTrxPlanilla();
        }

        private void btnCopiarConclusion_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos.", "Información");
                return;
            }

            // Crear una instancia de StringBuilder para almacenar los datos
            StringBuilder sb = new StringBuilder();

            // Recorrer cada fila en el DataGridView
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                // Recorrer cada celda en la fila actual
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Obtener el valor de la celda y agregarlo al StringBuilder
                    sb.Append(cell.Value);
                    sb.Append("\t"); // Separador de tabulación
                }

                sb.Append(Environment.NewLine); // Nueva línea después de cada fila
            }

            // Copiar los datos al portapapeles
            Clipboard.SetText(sb.ToString());

            MessageBox.Show("El contenido se ha copiado al portapapeles.", "Información");
        }

        private void frmVerDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
            
        }
    }
}
