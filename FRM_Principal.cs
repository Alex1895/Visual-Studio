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
    public partial class FRM_Principal : Form
    {
        MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");
        string TXTB;
        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        private MySqlCommand CMD;
        private MySqlDataReader RDR;
        public FRM_Principal(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo; 
        }

        public FRM_Principal()
        {
            // TODO: Complete member initialization
        }
        string tipo;
        
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRM_Edicion abrir1 = new FRM_Edicion();
            TXTB = label3.Text;
            tiempo(TXTB);
            abrir1.Show();
            //this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Usuarioos abrir = new FRM_Usuarioos();
            TXTB = label1.Text;
            tiempo(TXTB);
            abrir.Show();
            //this.Hide();

        }

        private void BTN_Reportes_Click(object sender, EventArgs e)
        {
            FRM_Reportes abrir = new FRM_Reportes();
            TXTB = Reportes.Text;
            tiempo(TXTB);
            abrir.Show();
            //this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Interacciones abrir = new FRM_Interacciones();
            TXTB = label2.Text;
            tiempo(TXTB);
            abrir.Show();
            //this.Hide();

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show(this, "Si cierra esta pantalla se cerrará la aplicación. ¿Desea continuar?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }

        }

        private void BTN_Cerrar_Sesion_Click(object sender, EventArgs e)
        {

            DialogResult result;

            result = MessageBox.Show(this, "Si cierra esta pantalla se cerrará la aplicación. ¿Desea continuar?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                FRM_Login abrir = new FRM_Login();
                abrir.Show();
                this.Hide();



            }
        }

        private void BTN_Incidentes_Click(object sender, EventArgs e)
        {
            FRM_Incidentes abrir = new FRM_Incidentes();
            TXTB = label4.Text;
            tiempo(TXTB);
            abrir.Show();
            //this.Hide();
        }

        private void BTN_RFC_Click(object sender, EventArgs e)
        {
            FRM_RFC abrir = new FRM_RFC();
            TXTB = label6.Text;
            tiempo(TXTB);
            abrir.Show();
        }

        private void BTN_Problemas_Click(object sender, EventArgs e)
        {
            FRM_Problemas abrir = new FRM_Problemas();
            TXTB = label5.Text;
            tiempo(TXTB);
            abrir.Show();
        }
       
        private void tiempo(string boton)
        {
            string Tiempos;
            DateTime date1 = new DateTime();
            DateTime dateOnly = date1.Date;
            // Display date using short date string.
            //Console.WriteLine(dateOnly.ToString("d"));
            // Display date using 24-hour clock.
            //Console.WriteLine(dateOnly.ToString("g"));
            //Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
            //Tiempos = dateOnly.ToString("MM-dd-yyyy HH:mm");
            Tiempos = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            try
            {

            
            MySqlCommand consulta = new MySqlCommand("INSERT INTO interaccion VALUES('" + LBL_usuario.Text + "','"+ Tiempos +"','"+boton+"')");
            consulta.Connection = Conexion_BD;
            Conexion_BD.Open();
            consulta.ExecuteNonQuery();
            Conexion_BD.Close();
            
            }
            catch
            {
                MessageBox.Show("Error");
                Conexion_BD.Close();
            }
            finally
            {
                Conexion_BD.Close();
            }
        }

        private void BTN_Int_Click(object sender, EventArgs e)
        {
            
            TXTB = label7.Text;
            tiempo(TXTB);
            FRM_Int inte = new FRM_Int();
            inte.Show();
        }

        private void LBL_usuario_TextChanged(object sender, EventArgs e)
        {
            string inicio = "Ha accedido al sistema";
            tiempo(inicio);
        }







    }
}
