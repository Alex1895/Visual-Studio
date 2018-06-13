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
	public partial class FRM_Usuarioos : Form
	{
		public FRM_Usuarioos()
		{
			InitializeComponent();
            quita();
		}
        private void quita()
        {
            MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");

        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
         MySqlCommand CMD;
         MySqlDataReader RDR;
         MySqlCommand consulta = new MySqlCommand("select Tipo_usuario from usuarios where Tipo_usuario = 'ADMIN'");

            consulta.Connection = Conexion_BD;
            Conexion_BD.Open();
            consulta.ExecuteNonQuery();
            consulta.CommandType = CommandType.Text;
            consulta.Parameters.Add(new MySqlParameter());
            RDR = consulta.ExecuteReader();
            if (RDR.Read())
            {
                CMB_TipUsu.Items.Remove("ADMIN");
            }
            Conexion_BD.Close();
            
            //"select * from usuarios where Tipo_usuario = 'ADMIN'";
            
        }
        
         public Cliente clienteActual { get; set; }
        void BTN_GuardarClick(object sender, EventArgs e)
        {
        	
        	
        	
        	   if (string.IsNullOrWhiteSpace(TXT_Usuario.Text) ||string.IsNullOrWhiteSpace( TXT_Contra.Text) ||
        	    string.IsNullOrWhiteSpace(TXT_Nombre.Text) || string.IsNullOrWhiteSpace(TXT_Ape.Text) || 
        	    string.IsNullOrWhiteSpace(TXT_Ape2.Text)|| string.IsNullOrWhiteSpace(CMB_TipUsu.SelectedItem.ToString())|| TXT_Contra.Text != textBox1.Text)
        		 
        		if (TXT_Contra.Text != textBox1.Text){
        	MessageBox.Show("CONTRASEÑA NO COINCIDE", "VERIFICALA!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        		
        	}else {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	
        	}
        	   
        	   
        	   
        	 
        	else{
          
                Cliente pCliente = new Cliente();
                 
                pCliente.Usuario = TXT_Usuario.Text.ToUpper();
                pCliente.Contraseña = TXT_Contra.Text.ToUpper();
                pCliente.Nombre = TXT_Nombre.Text.ToUpper();
                pCliente.Apellido = TXT_Ape.Text.ToUpper();
                 pCliente.Apellido2 = TXT_Ape2.Text.ToUpper();
                 pCliente.Tipo_Usuario = CMB_TipUsu.SelectedItem.ToString();
                 if (pCliente.Tipo_Usuario != "ADMIN" || pCliente.Tipo_Usuario != "CAPTURISTA")
                 {
                     pCliente.Tipo_Usuario = "CAPTURISTA";
                 }
                 

               

                 int resultado = ClietesDAL.Agregar(pCliente);
                if (resultado  > 0)
                {
                    MessageBox.Show("Registro Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Registro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        	}
        	}
        
        void BTN_EditarClick(object sender, EventArgs e)
        {
        	{
            if (string.IsNullOrWhiteSpace(TXT_Usuario.Text) || string.IsNullOrWhiteSpace( TXT_Contra.Text) ||
        	    string.IsNullOrWhiteSpace(TXT_Nombre.Text) || string.IsNullOrWhiteSpace(TXT_Ape.Text) || 
        	    string.IsNullOrWhiteSpace(TXT_Ape2.Text)|| TXT_Contra.Text != textBox1.Text)
                   if (TXT_Contra.Text != textBox1.Text){
        	MessageBox.Show("CONTRASEÑA NO COINCIDE", "VERIFICALA!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        		
        	}else {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	
        	}
                
            else

          {

            Cliente pCliente = new Cliente();
            pCliente.Usuario = TXT_Usuario.Text.ToUpper();
            pCliente.Contraseña = TXT_Contra.Text.ToUpper();
            pCliente.Nombre = TXT_Nombre.Text.ToUpper();
            pCliente.Apellido = TXT_Ape.Text.ToUpper();
            pCliente.Apellido2 = TXT_Ape2.Text.ToUpper();
            
           
            pCliente.Id = clienteActual.Id;

            if (ClietesDAL.Actualizar(pCliente) > 0)
            {
                MessageBox.Show("El Registro se actualizo", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Deshabilitar();

            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
          }
        }

        }
        
        void BTN_EliminarClick(object sender, EventArgs e)
        {
        	if (MessageBox.Show("Esta Seguro que desea eliminar el Registro Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ClietesDAL.Eliminar(clienteActual.Id) > 0)
                {
                    MessageBox.Show("Registro Eliminado Correctamente!", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                  
                    Deshabilitar();
                }
                else

                {
                    MessageBox.Show("No se pudo eliminar el Registtro", "Registro No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
        }
        
        void BTN_NuevoClick(object sender, EventArgs e)
        {
        	
        	Limpiar();
        	
            Habilitar();
        	
        }
        
        void BTN_BuscarClick(object sender, EventArgs e)
        {
        	
        }
        
        void LBL_BuscarporClick(object sender, EventArgs e)
        {
        	
        }
        
        void BTM_RegresarClick(object sender, EventArgs e)
        {

            //FRM_Login LOG = new FRM_Login();
            //LOG.Show();
            this.Hide();
              
        }
        
        void BTN_SalirClick(object sender, EventArgs e)
        {
        	Limpiar();
             DialogResult result;

            result = MessageBox.Show(this, "Si cierra esta pantalla se cerrará la aplicación. ¿Desea continuar?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }

        	
        	
        	
        }
        
        void CMB_BusquedaClick(object sender, EventArgs e)
        {
        	
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       
        
       

        void CMB_TipUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
        	 if (CMB_TipUsu.Text!="ADMIN"|| CMB_TipUsu.Text != "CAPTURISTA"){
                 CMB_TipUsu.Text = "CAPTURISTA";
             }
        }
        
        void Label1Click(object sender, EventArgs e)
        {
        	
        }
        
        void TextBox1TextChanged(object sender, EventArgs e)
        {
        	
        }
        
	void Limpiar()
        {
           TXT_Nombre.Clear();
            TXT_Usuario.Clear();
            TXT_Contra.Clear();
            TXT_Ape.Clear();
            TXT_Ape2.Clear();
            textBox1.Clear();
        }
	
	 void Habilitar()
        {
           TXT_Usuario.Enabled = true;
            TXT_Contra.Enabled = true;
            TXT_Nombre.Enabled = true;
            TXT_Ape.Enabled = true;
             TXT_Ape2.Enabled =true;  
             textBox1.Enabled = true;
             BTN_Guardar.Enabled = true;
	 }


        void Deshabilitar()
        {
            TXT_Usuario.Enabled = false;
            TXT_Contra.Enabled = false;
            textBox1.Enabled = false;
            TXT_Nombre.Enabled = false;
            TXT_Ape.Enabled = false;
             TXT_Ape2.Enabled = false;
             BTN_Guardar.Enabled = false;
             BTN_Eliminar.Enabled = false;
             BTN_Editar.Enabled = false;
             
            
        }
	
        void FRM_UsuariosLoad(object sender, EventArgs e)
        {
        	Deshabilitar();
        }
        
        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
        	
        }
        
        void TXT_ContraTextChanged(object sender, EventArgs e)
        {
        	
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	BUSCAR_USARIO buscar = new BUSCAR_USARIO();
            buscar.ShowDialog();

            if (buscar.ClienteSelecionado != null)
            {
                clienteActual = buscar.ClienteSelecionado;
                TXT_Nombre.Text = buscar.ClienteSelecionado.Nombre;
                TXT_Ape.Text = buscar.ClienteSelecionado.Apellido;
                TXT_Usuario.Text = buscar.ClienteSelecionado.Usuario;
                TXT_Ape2.Text = buscar.ClienteSelecionado.Apellido2;
                TXT_Contra.Text = buscar.ClienteSelecionado.Contraseña;
               
            }
        }
        
        void Label2Click(object sender, EventArgs e)
        {
        	
        }
        
        void LBL_ContraClick(object sender, EventArgs e)
        {
        	
        }
	
	
	
	
	}
	
	

}
	


