using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema
{
    public partial class FRM_Int : Form
    {
        MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");
        MySqlCommand comando;
                MySqlDataReader reader;
                DataTable datos;
        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        public FRM_Int()
        {
            InitializeComponent();
            cargar();
        }

        private void BTM_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cargar()
        {
            try
            {
                string consultar_todo = "SELECT * FROM Interaccion";
                Conexion_BD.Open();
                MySqlDataAdapter busqueda = new MySqlDataAdapter(consultar_todo, Conexion_BD);
                MySqlCommandBuilder comando = new MySqlCommandBuilder();
                DataTable datos = new DataTable();
                busqueda.Fill(datos);
                BindingSource muestra = new BindingSource();
                muestra.DataSource = datos;
                Visual_Datos.DataSource = muestra;
            }
            catch
            {
                MessageBox.Show("No hay registros");
                Conexion_BD.Close();
            }
            finally
            {
                Conexion_BD.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
