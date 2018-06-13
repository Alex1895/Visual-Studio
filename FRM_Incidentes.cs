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
    public partial class FRM_Incidentes : Form
    {
        MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");

        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        private MySqlCommand CMD;
        private MySqlDataReader RDR;
        public FRM_Incidentes()
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
            string consultar_todo = "SELECT ID,Email,Telefono,Comentarios,Incidente FROM correo";
            Conexion_BD.Open();
            MySqlDataAdapter busqueda = new MySqlDataAdapter(consultar_todo, Conexion_BD);
            MySqlCommandBuilder comando = new MySqlCommandBuilder();
            DataTable datos = new DataTable();
            busqueda.Fill(datos);
            BindingSource muestra = new BindingSource();
            muestra.DataSource = datos;
            Visual_Datos.DataSource = muestra;
            Conexion_BD.Close();
        }
    }
}
