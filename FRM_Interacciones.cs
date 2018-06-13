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
    public partial class FRM_Interacciones : Form
    {
        //OleDbConnection Conexion_BD = new OleDbConnection(ConfigurationManager.ConnectionStrings["System.Properties.Settings.ConnectionBD"].ConnectionString);
        string zona1;
        MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");

        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        private MySqlCommand CMD;
        private MySqlDataReader RDR;
        
        public FRM_Interacciones()
        {
            InitializeComponent();
            cargar();
        }

        private void BTM_Regresar_Click(object sender, EventArgs e)
        {
            //FRM_Login abrir = new FRM_Login();
            //abrir.Show();
            this.Hide();

        }
        
        void BTN_SalirClick(object sender, EventArgs e)
        {
        	
        	DialogResult result;

            result = MessageBox.Show(this, "Si cierra esta pantalla se cerrará la aplicación. ¿Desea continuar?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
        	
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Nuevo")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = true;
                button1.Text = "Guardar";
            }
            else
            {
                verificar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
                string zona0;
                string msg0 = String.Format("Row: {0}, Column: {1}", Visual_Datos.CurrentCell.RowIndex, Visual_Datos.CurrentCell.ColumnIndex);
                int a0, b0;
                a0 = Visual_Datos.CurrentCell.RowIndex;
                b0 = Visual_Datos.CurrentCell.ColumnIndex;
                zona0 = Visual_Datos[b0, a0].Value.ToString();
                zona0 = zona0.ToUpper();
                var result = MessageBox.Show("Desea eliminar " + zona0.ToUpper() + " de la lista", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand consulta = new MySqlCommand("DELETE FROM Zonas WHERE (Zona = '" + zona0.ToUpper() + "')");
                    consulta.Connection = Conexion_BD;
                    Conexion_BD.Open();
                    consulta.ExecuteNonQuery();
                    Conexion_BD.Close();
                    cargar();
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado nada o la tabla esta vacia.");
                textBox1.Text = "";
                textBox1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = false;
                cargar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string /*zona1,*/zona0;
            if (button2.Text == "Editar")
            {
                try
                {
                    string msg0 = String.Format("Row: {0}, Column: {1}", Visual_Datos.CurrentCell.RowIndex, Visual_Datos.CurrentCell.ColumnIndex);
                    int a0, b0;
                    a0 = Visual_Datos.CurrentCell.RowIndex;
                    b0 = Visual_Datos.CurrentCell.ColumnIndex;
                    zona0 = Visual_Datos[b0, a0].Value.ToString();
                    textBox1.Text = zona0;
                    zona0 = zona0.ToUpper();
                    zona1 = zona0;
                    textBox1.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button5.Enabled = false;
                    button4.Enabled = true;
                    button2.Text = "Guardar";
                }
                catch
                {
                    MessageBox.Show("No se ha seleccionado nada o la tabla esta vacia.");
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = false;
                    cargar();
                }
            }
            else
            {
                try
                {
                    button2.Text = "Editar";
                    textBox1.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = false;
                    MySqlCommand consulta = new MySqlCommand("UPDATE Zonas SET Zona = '" + textBox1.Text.ToUpper() + "' WHERE (Zona = '" + zona1.ToUpper() + "')");
                    consulta.Connection = Conexion_BD;
                    Conexion_BD.Open();
                    consulta.ExecuteNonQuery();
                    Conexion_BD.Close();
                    textBox1.Text = "";
                    cargar();
                }
                catch
                {
                    MessageBox.Show("Ya existe " + zona1.ToUpper() + ". ");
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = false;
                    cargar();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Conexion_BD.State == ConnectionState.Open)
            {
                Conexion_BD.Close();
            }
            cargar();
            textBox1.Text = "";
            textBox1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button1.Text = "Nuevo";
            button2.Text = "Editar";
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Desea eliminar TODAS las zonas", "Eliminar",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MySqlCommand consulta = new MySqlCommand("DELETE FROM Zonas");
                consulta.Connection = Conexion_BD;
                Conexion_BD.Open();
                consulta.ExecuteNonQuery();
                Conexion_BD.Close();
                cargar();
            }
        }
        private void Guardar()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = false;
                MessageBox.Show("No se encuentra nada en la caja de texto.");
                button1.Text = "Nuevo";
            }
            else
            {
                try
                {
                    MySqlCommand consulta = new MySqlCommand("INSERT INTO Zonas VALUES('" + textBox1.Text.ToUpper() + "')");
                    consulta.Connection = Conexion_BD;
                    Conexion_BD.Open();
                    consulta.ExecuteNonQuery();
                    Conexion_BD.Close();
                    cargar();
                    MessageBox.Show("La Zona " + textBox1.Text.ToUpper() + " Se ha agregado correctamente.");
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = false;
                    button1.Text = "Nuevo";
                    cargar();
                }
                catch
                {
                    Conexion_BD.Close();
                    textBox1.Text = "";
                    MessageBox.Show("El valor ya existe.");
                    button1.Text = "Nuevo";
                    cargar();
                }
            }
        }
        private void verificar()
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text != null)
                {
                    Guardar();
                }
            }
            else
            {
                MessageBox.Show("No se ha llenado el campo de Zona");
            }
        }
        private void cargar()
        {
            string consultar_todo = "SELECT * FROM Zonas";
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
