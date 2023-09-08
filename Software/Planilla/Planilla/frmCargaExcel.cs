using ErpLista;
using Microsoft.Win32;
using Planilla.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla
{
    public partial class frmCargaExcel : Form
    {
        Loading loading;

        private void PlayNotificationSound()
        {
            bool found = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AppEvents\Schemes\Apps\.Default\Notification.Default\.Current"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(null); // pass null to get (Default)
                        if (o != null)
                        {
                            SoundPlayer theSound = new SoundPlayer((String)o);
                            theSound.Play();
                            found = true;
                        }
                    }
                }
            }
            catch
            { }
            if (!found)
                SystemSounds.Beep.Play(); // consolation prize
        }
        public frmCargaExcel()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            loading = new Loading();
            loading.Show();
        }

        private void Ocultar()
        {
            if (loading != null)
            {
                loading.Close();
            }
        }

        private void ProcesoIngresoPlanillas()
        {
            btnSelectFile.Enabled = false;
            btnGuardar.Enabled = false;
            DataTable dtItem = (DataTable)(dgItems.DataSource);

            string P_CUENTA = "";
            string P_NOMBRE_CLIENTE = "";
            string P_DPI = "";
            string P_ID = "";
            


            int count = 0;

            CuentasPlantillas objCP = new CuentasPlantillas();
            objCP.LimpiarTabla();

            foreach (DataRow dr in dtItem.Rows)
            {

                P_CUENTA = Convert.ToString(dr["CUENTA"]);
                P_NOMBRE_CLIENTE = Convert.ToString(dr["NOMBRE_CLIENTE"]);
                P_DPI = Convert.ToString(dr["DPI"]);
                P_ID = Convert.ToString(dr["ID"]);
                

                objCP.IngresarDetalleLista(
                                                     P_CUENTA,
                                                     P_NOMBRE_CLIENTE,
                                                     P_DPI,
                                                     P_ID
                                                );
                


                count++;
            }
            objCP.EliminarDuplicados();
            Ocultar();
            PlayNotificationSound();
            MessageBox.Show("Importación PLANILLAS exitosa, Total registros insertados : " + count + "", "Carga Csv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSelectFile.Enabled = true;
            btnGuardar.Enabled = true;

        }

        private void ProcesoIngresoUsuariosActivosApp()
        {
            btnSelectFile.Enabled = false;
            btnGuardar.Enabled = false;
            DataTable dtItem = (DataTable)(dgItems.DataSource);

            string P_DOCUMENTO = "";
            
            int count = 0;

            ClientesActivosApp obj = new ClientesActivosApp();
            obj.LimpiarTabla();

            foreach (DataRow dr in dtItem.Rows)
            {

                P_DOCUMENTO = Convert.ToString(dr["DPI_USUARIOS"]);


                obj.IngresarClientesActivosApp(
                                                     P_DOCUMENTO
                                                );



                count++;
            }            
            Ocultar();
            PlayNotificationSound();
            MessageBox.Show("Importación USUARIOS ACTIVOS APP exitosa, Total registros insertados : " + count + "", "Carga Csv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSelectFile.Enabled = true;
            btnGuardar.Enabled = true;

        }

        private void ProcesoIngresoUsuariosActivosYolo()
        {
            btnSelectFile.Enabled = false;
            btnGuardar.Enabled = false;
            DataTable dtItem = (DataTable)(dgItems.DataSource);

            string P_DOCUMENTO = "";

            int count = 0;

            ClientesActivosYolo obj = new ClientesActivosYolo();
            obj.LimpiarTabla();

            foreach (DataRow dr in dtItem.Rows)
            {

                P_DOCUMENTO = Convert.ToString(dr["DPI_USUARIOS"]);


                obj.IngresarClientesActivosYolo(
                                                     P_DOCUMENTO
                                                );



                count++;
            }
            Ocultar();
            PlayNotificationSound();
            MessageBox.Show("Importación USUARIOS ACTIVOS YOLO exitosa, Total registros insertados : " + count + "", "Carga Csv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSelectFile.Enabled = true;
            btnGuardar.Enabled = true;

        }

        private void ProcesoIngresoUsuariosActivosBl()
        {
            btnSelectFile.Enabled = false;
            btnGuardar.Enabled = false;
            DataTable dtItem = (DataTable)(dgItems.DataSource);

            string P_DOCUMENTO = "";

            int count = 0;

            ClientesActivosBl obj = new ClientesActivosBl();
            obj.LimpiarTabla();

            foreach (DataRow dr in dtItem.Rows)
            {

                P_DOCUMENTO = Convert.ToString(dr["DPI_USUARIOS"]);


                obj.IngresarClientesActivosBl(
                                                     P_DOCUMENTO
                                                );



                count++;
            }
            Ocultar();
            PlayNotificationSound();
            MessageBox.Show("Importación USUARIOS ACTIVOS BL exitosa, Total registros insertados : " + count + "", "Carga Csv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSelectFile.Enabled = true;
            btnGuardar.Enabled = true;

        }

        private void ProcesoIngresoTransacciones()
        {
            btnSelectFile.Enabled = false;
            btnGuardar.Enabled = false;
            DataTable dtItem = (DataTable)(dgItems.DataSource);

            string P_DOCUMENTO_IDENTIFICACION = "";
            string P_MONTO = "";
            string P_DESCRIPCION = "";
            string P_NUM_DOCUMENTO = "";
            



            int count = 0;

            Transacciones objT = new Transacciones();
            objT.LimpiarTabla();

            foreach (DataRow dr in dtItem.Rows)
            {

                P_DOCUMENTO_IDENTIFICACION = Convert.ToString(dr["DOCUMENTO_IDENTIFICACION"]);
                P_NUM_DOCUMENTO = Convert.ToString(dr["NUM_DOCUMENTO"]);
                P_MONTO = Convert.ToString(dr["MONTO"]);
                P_DESCRIPCION = Convert.ToString(dr["DESCRIPCION"]);
                


                objT.InsertarTransacciones(
                                                     P_DOCUMENTO_IDENTIFICACION,
                                                     P_NUM_DOCUMENTO,
                                                     float.Parse(P_MONTO),
                                                     P_DESCRIPCION
                                                     
                                                );



                count++;
            }
            //objT.EliminarVacios();
            Ocultar();
            PlayNotificationSound();
            MessageBox.Show("Importación TRANSACCIONES exitosa, Total registros insertados : " + count + "", "Carga Csv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSelectFile.Enabled = true;
            btnGuardar.Enabled = true;

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(cmbTipoCarga.Text == "PLANILLAS (EXCEL)")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Archivo | * .xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        btnSelectFile.Enabled = false;
                        btnGuardar.Enabled = false;
                        Mostrar();
                        string strPath = ofd.FileName;
                        string nombre;
                        String connStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + strPath + ";Extended Properties = 'Excel 12.0 Xml;HDR = NO;IMEX=1;READONLY=TRUE'";
                        OleDbConnection conn = new OleDbConnection(connStr);
                        conn.Open();

                        // Volver a la arquitectura de Excel, incluido el nombre, el tipo, la creación del tiempo y la hora de modificación de cada tabla de hojas, etc.
                        //DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

                        // Contiene el número de cadenas del nombre de la tabla en Excel


                        OleDbDataAdapter myCommand = null;
                        DataTable dt = new DataTable();
                        DataTable dt2 = new DataTable();
                        dt2 = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                        foreach (DataRow row in dt2.Rows)
                        {
                            nombre = row["TABLE_NAME"].ToString();
                            string strExcel = "select DISTINCT DPI, ID, CUENTA, NOMBRE_CLIENTE " +
                                            "from [" + nombre + "] ";
                            //"from [" + "'MINISTERIO CYD$'" + "] ";

                            myCommand = new OleDbDataAdapter(strExcel, connStr);
                            myCommand.Fill(dt);
                            dgItems.DataSource = dt;
                        }


                        // Datos de consulta del nombre de la tabla especificado, primero puede enumerar todos los nombres de las tablas a la selección de usuarios



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        btnSelectFile.Enabled = true;
                        PlayNotificationSound();
                    }
                    Ocultar();
                    btnSelectFile.Enabled = true;
                    btnGuardar.Enabled = true;
                    PlayNotificationSound();
                }
            }

            if (cmbTipoCarga.Text == "TRANSACCIONES (CSV)")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "CSV | * .csv";
                dialog.ShowDialog();
                btnSelectFile.Enabled = false;
                btnGuardar.Enabled = false;
                Mostrar();
                //string SourceURl = "";
                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable dtNew = new DataTable();
                        dtNew = GetDataTabletFromCSVFile(dialog.FileName);
                        /*if (Convert.ToString(dtNew.Columns[0]).ToLower() != "fecha")
                        {
                            PlayNotificationSound();
                            MessageBox.Show("Formato Csv incorrecto");
                            return;
                        }*/

                        //txtFile.Text = @"c:\temp\interbancaria.csv";
                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {
                            dgItems.DataSource = dtNew;
                        }
                        

                    }
                    
                }                
                Ocultar();
                btnSelectFile.Enabled = true;
                btnGuardar.Enabled = true;
                PlayNotificationSound();

            }

            if (cmbTipoCarga.Text == "CLIENTES ACTIVOS APP (EXCEL)")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Archivo | * .xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        btnSelectFile.Enabled = false;
                        btnGuardar.Enabled = false;
                        Mostrar();
                        string strPath = ofd.FileName;                        
                        String connStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + strPath + ";Extended Properties = 'Excel 12.0 Xml;HDR = NO;IMEX=1;READONLY=TRUE'";
                        OleDbConnection conn = new OleDbConnection(connStr);
                        conn.Open();

                        // Volver a la arquitectura de Excel, incluido el nombre, el tipo, la creación del tiempo y la hora de modificación de cada tabla de hojas, etc.
                        //DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

                        // Contiene el número de cadenas del nombre de la tabla en Excel


                        OleDbDataAdapter myCommand = null;
                        DataTable dt = new DataTable();
                        string strExcel = "select * from [" + "UsuariosActivos$" + "] ";
                        myCommand = new OleDbDataAdapter(strExcel, connStr);
                        myCommand.Fill(dt);
                        dgItems.DataSource = dt;


                        // Datos de consulta del nombre de la tabla especificado, primero puede enumerar todos los nombres de las tablas a la selección de usuarios



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        btnSelectFile.Enabled = true;
                        PlayNotificationSound();
                    }
                    Ocultar();
                    btnSelectFile.Enabled = true;
                    btnGuardar.Enabled = true;
                    PlayNotificationSound();
                }
            }

            if (cmbTipoCarga.Text == "CLIENTES ACTIVOS YOLO (EXCEL)")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Archivo | * .xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        btnSelectFile.Enabled = false;
                        btnGuardar.Enabled = false;
                        Mostrar();
                        string strPath = ofd.FileName;                        
                        String connStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + strPath + ";Extended Properties = 'Excel 12.0 Xml;HDR = NO;IMEX=1;READONLY=TRUE'";
                        OleDbConnection conn = new OleDbConnection(connStr);
                        conn.Open();

                        // Volver a la arquitectura de Excel, incluido el nombre, el tipo, la creación del tiempo y la hora de modificación de cada tabla de hojas, etc.
                        //DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

                        // Contiene el número de cadenas del nombre de la tabla en Excel


                        OleDbDataAdapter myCommand = null;
                        DataTable dt = new DataTable();
                        string strExcel = "select * from [" + "UsuariosActivos$" + "] ";
                        myCommand = new OleDbDataAdapter(strExcel, connStr);
                        myCommand.Fill(dt);
                        dgItems.DataSource = dt;


                        // Datos de consulta del nombre de la tabla especificado, primero puede enumerar todos los nombres de las tablas a la selección de usuarios



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        btnSelectFile.Enabled = true;
                        PlayNotificationSound();
                    }
                    Ocultar();
                    btnSelectFile.Enabled = true;
                    btnGuardar.Enabled = true;
                    PlayNotificationSound();
                }
            }

            if (cmbTipoCarga.Text == "CLIENTES ACTIVOS BL (EXCEL)")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Archivo | * .xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        btnSelectFile.Enabled = false;
                        btnGuardar.Enabled = false;
                        Mostrar();
                        string strPath = ofd.FileName;                        
                        String connStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + strPath + ";Extended Properties = 'Excel 12.0 Xml;HDR = NO;IMEX=1;READONLY=TRUE'";
                        OleDbConnection conn = new OleDbConnection(connStr);
                        conn.Open();

                        // Volver a la arquitectura de Excel, incluido el nombre, el tipo, la creación del tiempo y la hora de modificación de cada tabla de hojas, etc.
                        //DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

                        // Contiene el número de cadenas del nombre de la tabla en Excel


                        OleDbDataAdapter myCommand = null;
                        DataTable dt = new DataTable();
                        string strExcel = "select * from [" + "UsuariosActivos$" + "] ";
                        myCommand = new OleDbDataAdapter(strExcel, connStr);
                        myCommand.Fill(dt);
                        dgItems.DataSource = dt;


                        // Datos de consulta del nombre de la tabla especificado, primero puede enumerar todos los nombres de las tablas a la selección de usuarios



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        btnSelectFile.Enabled = true;
                        PlayNotificationSound();
                    }
                    Ocultar();
                    btnSelectFile.Enabled = true;
                    btnGuardar.Enabled = true;
                    PlayNotificationSound();
                }
            }

        }

        

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cmbTipoCarga.Text=="PLANILLAS (EXCEL)")
            {
                Mostrar();
                CheckForIllegalCrossThreadCalls = false;
                Task oTask = new Task(ProcesoIngresoPlanillas);

                oTask.Start();
                await oTask;
            }

            if(cmbTipoCarga.Text == "TRANSACCIONES (CSV)")
            {

                Mostrar();
                CheckForIllegalCrossThreadCalls = false;
                Task oTask = new Task(ProcesoIngresoTransacciones);

                oTask.Start();
                await oTask;

            }

            if (cmbTipoCarga.Text == "CLIENTES ACTIVOS APP (EXCEL)")
            {

                Mostrar();
                CheckForIllegalCrossThreadCalls = false;
                Task oTask = new Task(ProcesoIngresoUsuariosActivosApp);

                oTask.Start();
                await oTask;

            }

            if (cmbTipoCarga.Text == "CLIENTES ACTIVOS YOLO (EXCEL)")
            {

                Mostrar();
                CheckForIllegalCrossThreadCalls = false;
                Task oTask = new Task(ProcesoIngresoUsuariosActivosYolo);

                oTask.Start();
                await oTask;

            }

            if (cmbTipoCarga.Text == "CLIENTES ACTIVOS BL (EXCEL)")
            {

                Mostrar();
                CheckForIllegalCrossThreadCalls = false;
                Task oTask = new Task(ProcesoIngresoUsuariosActivosBl);

                oTask.Start();
                await oTask;

            }


        }

        public DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            int contador = 0;
            int contadorMalas = 0;
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] {
                    ","
                });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column  
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }

                            }
                            if (colFields.Length == fieldData.Length)
                            {
                                csvData.Rows.Add(fieldData);
                                contador++;
                            }
                            else
                            {
                                contadorMalas++;
                            }

                        }
                        PlayNotificationSound();
                        MessageBox.Show("Registros encontrados " + contador);

                    }
                }
            }
            catch (Exception ex)
            {
                PlayNotificationSound();
                MessageBox.Show("Exception " + contador + ex);
            }
            return csvData;
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

        private void limpiar()
        {
            dgItems = null;
            cmbTipoCarga.Focus();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            frmVerDatos frmVerDatos = new frmVerDatos();
            frmVerDatos.Show();
            this.Close();
        }
    }
}
