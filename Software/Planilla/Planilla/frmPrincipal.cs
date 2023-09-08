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
    public partial class frmPrincipal : Form
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


        public frmPrincipal()
        {
            InitializeComponent();

            
        }

        private void btnCargarCsv_Click(object sender, EventArgs e)
        {
            frmCargaExcel frmCargaExcel = new frmCargaExcel();
            frmCargaExcel.Show();
            this.Hide();
        }

        private void btnTrxEq_Click(object sender, EventArgs e)
        {
            frmTransaccionesEquivalentes frmTransaccion = new frmTransaccionesEquivalentes(); 
            frmTransaccion.Show();
            this.Hide();
        }

        private void btnTiposPlanilla_Click(object sender, EventArgs e)
        {
            frmPlanilla frmPlanilla = new frmPlanilla();
            frmPlanilla.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hmenu = GetSystemMenu(this.Handle, 0);

            int cnt = GetMenuItemCount(hmenu);

            // remove 'Hide' action

            RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);

            // remove extra menu line

            RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);

            DrawMenuBar(this.Handle);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            frmVerDatos frmVerDatos = new frmVerDatos();
            frmVerDatos.Show();
            this.Hide();
        }
    }
}
