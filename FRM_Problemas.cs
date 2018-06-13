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
    public partial class FRM_Problemas : Form
    {
        MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");
        MySqlConnection Conecta = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");

        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        private MySqlCommand CMD;
        private MySqlDataReader RDR;
        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        private MySqlCommand Comand;
        string c0, c1, c2, c3, c4;
        public FRM_Problemas()
        {
            InitializeComponent();
            consultar();
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
            string consultar_todo = "SELECT * FROM errores";
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
        private void consultar()
        {
            try
            {
                string Consulta1 = "TRUNCATE TABLE errores";
                MySqlCommand Access1 = new MySqlCommand(Consulta1, Conexion_BD);
                Conexion_BD.Open();

                if (Access1.ExecuteScalar() == null)
                {
                    string Consulta2 = "SELECT *, count(ID) as USR,count(Incidente) as NBR FROM correo group by ID having USR>1 and NBR>1";
                    MySqlCommand Access2 = new MySqlCommand(Consulta2, Conexion_BD);
                    if (Access2.ExecuteScalar() == null)
                    {
                        MessageBox.Show("No se han encontrado errores");
                        this.Hide();
                    }
                    Access2.CommandType = CommandType.Text;
                    Access2.Parameters.Add(new MySqlParameter());
                    MySqlDataReader reader = Access2.ExecuteReader();
                    while (reader.Read())
                    {
                        c0 = reader["ID"] as string;
                        c1 = reader["Email"] as string;

                        c2 = reader["Incidente"] as string;


                        MySqlCommand Cons = new MySqlCommand("INSERT INTO `gestor1`.`errores` (`Usuario`, `Email`, `Incidente`) VALUES ('" + c0 + "', '" + c1 + "', '" + c2 + "');");
                        Cons.Connection = Conecta;
                        Conecta.Open();
                        Cons.ExecuteNonQuery();
                        Conecta.Close();

                        
                        //"INSERT `Usuario`,`Email`,`Incidente` INTO errores VALUES('" + c0 + "','" + c1 + "','" + c2 + "')"
                    } 
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                Conexion_BD.Close();
            }
            
        }
    }
}
