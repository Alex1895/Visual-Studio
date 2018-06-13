using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using System.Data.SqlClient;
using MySql.Data;



namespace Sistema
{
    public partial class FRM_Reportes : Form
    {
        public FRM_Reportes()
        {
            InitializeComponent();
        }

        private void BTM_Regresar_Click(object sender, EventArgs e)
        {
             //FRM_Login Login = new FRM_Login();
        	
             //Login.ShowDialog();
            this.Hide();

        }

        private void CHB_ApePaterno_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Grid1.Width, this.Grid1.Height);
            Grid1.DrawToBitmap(bm, new Rectangle(0, 0, this.Grid1.Width, this.Grid1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {   

        string Id;
       string Ape_Mat;
       string Ape_Pat;
      string  Nombre;
      string  Edad;
      string  Fecha_Naci;
      string  Sexo;
      string  Edo_Civil;
      string  Telefono;
      string  Direccion;
      string  Colonia;
      string  Calle;
      string  CP;
      string  Entre_que_calles;
      string  Seccion_Elect;
      string  Direccion_IFE;
      string  Curpri;
      string  Curp;


      if (CHB_ApePaterno.Checked == true)
      {
          Ape_Pat = "Ape_Pat, ";
      }
      else
      {
          Ape_Pat = "";
      }
//-----------------------------------------------------------------
      if (CHB_ApeMaterno.Checked == true)
      {
          Ape_Mat = "Ape_Mat, ";
      }
      else
      {
          Ape_Mat = "";
      }
      //-----------------------------------------------------------------
      if (CHB_Nombres.Checked == true)
      {
          Nombre = "Nombre";
      }
      else
      {
          Nombre = "";
      }
      //-----------------------------------------------------------------
      if (CHB_FechaNac.Checked == true)
      {
          Fecha_Naci = "Fecha_Naci";
      }
      else
      {
          Fecha_Naci = "";
      }
      //-----------------------------------------------------------------
      if (CHB_Sexo.Checked == true)
      {
          Sexo = "Sexo";
      }
      else
      {
          Sexo = "";
      }
      //-----------------------------------------------------------------
      if (CHB_EstadoCivil.Checked == true)
      {
          Edo_Civil = "Edo_Civil";
      }
      else
      {
          Edo_Civil = "";
      }

      //-----------------------------------------------------------------
      if (CHB_TelefonoCasa.Checked == true)
      {
          Telefono = "Telefono";
      }
      else
      {
          Telefono = "";
      }
      //-----------------------------------------------------------------
      if (CHB_Dir.Checked == true)
      {
          Direccion = "Direccion";
      }
      else
      {
          Direccion = "";
      }

      //-----------------------------------------------------------------
      if (CHB_Colonia.Checked == true)
      {
          Colonia = "Colonia";
      }
      else
      {
          Colonia = "";
      }
      //-----------------------------------------------------------------
      if (CHB_Call.Checked == true)
      {
          Calle = "Calle";
      }
      else
      {
          Calle = "";
      }

      //-----------------------------------------------------------------
      if (CHB_CodPostal.Checked == true)
      {
          CP = "CP";
      }
      else
      {
          CP = "";
      }

      //-----------------------------------------------------------------
      if (CHB_EntreCalles.Checked == true)
      {
          Entre_que_calles = "Entre_que_calles";
      }
      else
      {
          Entre_que_calles = "";
      }

      //-----------------------------------------------------------------
      if (CHB_SeccionElect.Checked == true)
      {
          Seccion_Elect = "Seccion_Elect";
      }
      else
      {
          Seccion_Elect = "";
      }

      //-----------------------------------------------------------------
      if (CHB_DireccionIfe.Checked == true)
      {
          Direccion_IFE = "Direccion_IFE";
      }
      else
      {
          Direccion_IFE = "";
      }

      //-----------------------------------------------------------------
      if (CHB_CurpDelPri.Checked == true)
      {
          Curpri = "Curpri";
      }
      else
      {
          Curpri = "";
      }
      /*/-----------------------------------------------------------------
      if (CHB_CurpDelPri.Checked == true)
      {
          Curp = "Curp,";
      }
      else
      {
          Curp = "";
      }


/*///---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
             MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                              "Database = gestor1; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
 DataTable dtDatos = new DataTable();
 
 // Se crea un MySqlAdapter para obtener los datos de la base
 MySqlDataAdapter mdaDatos = new MySqlDataAdapter(string.Format("select Nombre," + Ape_Mat + Ape_Pat + Fecha_Naci + Sexo + Edo_Civil + Telefono + Direccion + Colonia + Calle + CP + Entre_que_calles + Seccion_Elect + Direccion_IFE + Curpri + "'{0}' FROM `datos personales`;",
    Curpri),cnn);
 
 // Con la información del adaptador se rellena el DataTable
 mdaDatos.Fill(dtDatos);
 
 // Se asigna el DataTable como origen de datos del DataGridView
       Grid1.DataSource = dtDatos;
 
 // Se cierra la conexión a la base de datos
 cnn.Close();

            Excel.Application xlApp ;
            Excel.Workbook xlWorkBook ;
            Excel.Worksheet xlWorkSheet ;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0; 

            for (i = 0; i <= Grid1.RowCount  - 1; i++)
            {
                for (j = 0; j <= Grid1.ColumnCount  - 1; j++)
                {
                    DataGridViewCell cell = Grid1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            i = 0;
            int horastr = i++; xlWorkBook.SaveAs("reporte simplee xD6" + horastr + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created");
        
        

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHB_ApePaterno.Checked = true;
            CHB_ApeMaterno.Checked = true;
            CHB_Nombres.Checked = true;
            CHB_FechaNac.Checked = true;
            CHB_Sexo.Checked = true;
            CHB_EstadoCivil.Checked = true;
            CHB_Cur.Checked = true;
            CHB_Zon.Checked=true;
            CHB_Dir.Checked = true;
            CHB_Call.Checked = true;
            CHB_Colonia.Checked = true;
            CHB_CodPostal.Checked = true;
            CHB_EntreCalles.Checked = true;
            CHB_TelefonoCasa.Checked = true;
            CHB_TelefonoCel.Checked = true;
            CHB_DireccionIfe.Checked = true;
            CHB_DireccionIfe.Checked = true;
            CHB_ClaveElect.Checked = true;
            CHB_SeccionElect.Checked = true;
            CHB_CurpDelPri.Checked = true;

            MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                            "Database = gestor1; Port = 3306; Allow Zero Datetime=True");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
           
            DataTable dtDatos1 = new DataTable();
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos1 = new MySqlDataAdapter("DESCRIBE `datos personales`;", cnn);
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT * FROM `datos personales`;", cnn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos1.Fill(dtDatos1);
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            Grid1.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            cnn.Close();


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= Grid1.RowCount - 1; i++)
            {
                for (j = 0; j <= Grid1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = Grid1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            i = 0;
            int horastr = i++;
           // xlWorkBook.SaveAs(CHB_Nombres,CHB_ApeMaterno);
            xlWorkBook.SaveAs("reporte Sitema_ gestor" + horastr + "xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created");
        
        



            
            
        }

        private void CHB_Sexo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CHB_Colonia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CHB_EntreCalles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
