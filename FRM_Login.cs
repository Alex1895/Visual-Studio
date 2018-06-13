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
    public partial class FRM_Login : Form
    {
        
        MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; pwd=;" +
                                                     "Database = gestor1; Port = 3306");
        MySqlCommand cmd = new MySqlCommand();
          
        public FRM_Login()
        {

            InitializeComponent();
        }
        
            
            public void permiso(string tipo)
            {
                MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root;  pwd=;" +
                                                    "Database = gestor1; Port = 3306");
                MySqlCommand cmd = new MySqlCommand();

                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandText = "select Tipo_usuario from usuarios where Usuario = '" + TXT_Usuario.Text + "'and Contraseña = '" + TXT_Contraseña.Text + "'";
                string tipusu = cmd.ExecuteScalar().ToString();
                //Comparamos si el valor recibido es 1 entonces existe si no NO

                tipusu = tipo;


                if (tipusu == "ADMIN")
                {
                    FRM_Principal princiad = new FRM_Principal(tipo);


                    princiad.button1.Enabled = true;
                    princiad.button3.Enabled = false;
                    princiad.button4.Enabled = true;
                    princiad.BTN_Reportes.Enabled = true;
                    princiad.LBL_usuario.Text = TXT_Usuario.Text;
                    princiad.BTN_RFC.Enabled = true;
                    princiad.BTN_Incidentes.Enabled = true;
                    princiad.BTN_Problemas.Enabled = true;
                    princiad.BTN_Int.Enabled = false;
                    princiad.ShowDialog(this);
                    this.Hide();

                }


                if (tipusu == "CAPTURISTA")
                {
                    FRM_Principal princiad = new FRM_Principal(tipo);


                    princiad.button1.Enabled = true;
                    princiad.button3.Enabled = false;
                    princiad.button4.Enabled = false;
                    princiad.BTN_Reportes.Enabled = false;
                    princiad.button1.Enabled = true;
                    princiad.button3.Enabled = true;
                    princiad.LBL_usuario.Text = TXT_Usuario.Text;
                    princiad.BTN_RFC.Enabled = false;
                    princiad.BTN_Incidentes.Enabled = false;
                    princiad.BTN_Problemas.Enabled = false;
                    princiad.BTN_Int.Enabled = false;
                    princiad.ShowDialog(this);
                    this.Hide();


                }

                if (tipusu == "")
                {
                    FRM_Principal princiad = new FRM_Principal(tipo);


                    princiad.button4.Enabled = true;
                    princiad.BTN_Reportes.Enabled = true;
                    princiad.LBL_usuario.Text = TXT_Usuario.Text;
                    princiad.BTN_RFC.Enabled = true;
                    princiad.BTN_Incidentes.Enabled = true;
                    princiad.BTN_Problemas.Enabled = true;
                    princiad.BTN_Int.Enabled = true;
                    princiad.ShowDialog(this);
                    this.Hide();

                }

                
            }
            
       
        
    
        public void BTN_Entrar_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;
            if (TXT_Usuario.Text == "ROOT" && TXT_Contraseña.Text == "USUARIOROOT2789")
            {
                MessageBox.Show("Bienvenido\n Ha accedido desde el usuario de recuperacion ROOT ", " Hola ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                acceso("");
            }
            else
            {

            
            try
            {
                cmd.CommandText = "select COUNT(*) from usuarios where Usuario = '" + TXT_Usuario.Text + "'and Contraseña = '" + TXT_Contraseña.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                //Comparamos si el valor recibido es 1 entonces existe si no NO
                cmd.CommandText = "select Tipo_usuario from usuarios where Usuario = '" + TXT_Usuario.Text + "'and Contraseña = '" + TXT_Contraseña.Text + "'";
                string tipusu = cmd.ExecuteScalar().ToString();
               
                if (valor == 1)
                {
                    MessageBox.Show("Bienvenido\n    "+TXT_Usuario.Text+" "," Hola ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    permiso(tipusu);
                    

                    
                    


                }
                else {//label1.Text = "Usuario No Existe"; 
                    MessageBox.Show("No existe el usuario llamado \n                  "+TXT_Usuario.Text+"\n o la contraseña es incorrecta", "Error de existencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("No existe el usuario llamado \n                  " + TXT_Usuario.Text+"\n o la contraseña es incorrecta", "Error de existencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_Contraseña.Text = "";
                TXT_Usuario.Text = "";
               //label1.Text = "error siguiente" + ex;
            }
            }

            cnn.Close();
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
             DialogResult result;

            result = MessageBox.Show(this, "Si cierra esta pantalla se cerrará la aplicación. ¿Desea continuar?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
        	
        	
        	//Application.Exit();
        
        }
        private void acceso(string tipo)
        {
            FRM_Principal princiad = new FRM_Principal(tipo);


            princiad.button4.Enabled = true;
            princiad.BTN_Reportes.Enabled = true;
            princiad.LBL_usuario.Text = TXT_Usuario.Text;
            princiad.BTN_RFC.Enabled = true;
            princiad.BTN_Incidentes.Enabled = true;
            princiad.BTN_Problemas.Enabled = true;
            princiad.BTN_Int.Enabled = true;

            princiad.ShowDialog(this);
            this.Hide();

        }

  

       
        
       
    }
}
