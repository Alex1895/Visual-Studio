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

namespace Sistema
{
    public partial class FRM_Edicion : Form
    {
        MySqlConnection Conexion_BD = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");

        //private SqlConnection Conexion_BD = new SqlConnection(Properties.Settings.Default.ConBDatos);
        private MySqlCommand CMD;
        private MySqlDataReader RDR;
        public FRM_Edicion()
        {

            

            InitializeComponent();
            carga();



        }

        private void carga()
        {

            string Consulta_BD = "SELECT * FROM zonas";
            MySqlCommand Access = new MySqlCommand(Consulta_BD, Conexion_BD);
            string zona;
            Conexion_BD.Open();
            Access.CommandType = CommandType.Text;
            Access.Parameters.Add(new MySqlParameter());
            MySqlDataReader reader = Access.ExecuteReader();
            while (reader.Read())
            {
                zona = reader["Zona"] as string;
                CMB_Zona.Items.Add(zona);

            }

            Conexion_BD.Close();


        }


        public CapturaRES clienteActual { get; set; }

         void BTN_Agregar_Click(object sender, EventArgs e)
        {
            CapturaRES pCaptura = new CapturaRES();

            pCaptura.Ape_mat = TXT_Ap_Mat.Text.ToUpper();
            pCaptura.Ape_pat = TXT_Ap_Pat.Text.ToUpper();
            pCaptura.Nombres = TXT_Nombres.Text.ToUpper();
            pCaptura.Edad = (DateTime.Today.AddTicks(-DTI_FecNac.Value.Ticks).Year);

            pCaptura.Fecha_naci = DTI_FecNac.Text;

            if(RBT_F.Checked){
            pCaptura.Sexo = RBT_F.Text.ToUpper();
            }
            
            else if(RBT_M.Checked){
            pCaptura.Sexo = RBT_M.Text.ToUpper();
            }

            pCaptura.Edo_civil = CMB_EdoCiv.Text.ToUpper();
            pCaptura.Telefono   = TXT_TelCas.Text.ToUpper();
           
            pCaptura.Colonia    = TXT_Col.Text.ToUpper();
            pCaptura.calle      =  TXT_Calle.Text.ToUpper();
            pCaptura.CP         =   TXT_CP.Text.ToUpper();
            pCaptura.Entre_que_calles =TXT_Entre.Text.ToUpper();
           
            pCaptura.Seccion_electoral = TXT_SecElect.Text.ToUpper();
            pCaptura.Direccion_Ife = TXT_IFE.Text.Trim();
            pCaptura.Curpri = TXT_Curppri.Text.ToUpper();
            pCaptura.Curp = TXT_Curp.Text.ToUpper();

             Limpiar();

            int resultado = CapturaDAL.Agregar(pCaptura);
            if (resultado > 0)
            {
                MessageBox.Show("Guardado", "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se Guardo","Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        
        }

        

         void BTM_Regresar_Click(object sender, EventArgs e)
        {

          
            //FRM_Login LOG = new FRM_Login();
            //LOG.Show();
            this.Hide();
           
          
            
        }

         void TXT_Buscar_Click(object sender, EventArgs e)
        {
           BUSCACAPTURA busca = new BUSCACAPTURA();
            busca.ShowDialog();

            if (busca.ClienteSelecionad != null)
            {
                clienteActual = busca.ClienteSelecionad;
               
                TXT_Ap_Mat.Text = busca.ClienteSelecionad.Ape_mat;
                TXT_Ap_Pat.Text = busca.ClienteSelecionad.Ape_pat;
                TXT_Nombres.Text = busca.ClienteSelecionad.Nombres;
                TXT_Curp.Text = busca.ClienteSelecionad.Curp;
                TXT_Calle.Text = busca.ClienteSelecionad.calle;
                TXT_CP.Text = busca.ClienteSelecionad.CP;
                TXT_Col.Text = busca.ClienteSelecionad.Colonia;
                TXT_TelCas.Text = busca.ClienteSelecionad.Telefono;
                TXT_Entre.Text = busca.ClienteSelecionad.Entre_que_calles;
                TXT_IFE.Text = busca.ClienteSelecionad.Direccion_Ife;
                TXT_Curppri.Text = busca.ClienteSelecionad.Curpri;
               
            }

           
             
           

        }

         void TXT_editar_Click(object sender, EventArgs e)
        {
            
           {
            if (string.IsNullOrWhiteSpace(TXT_Ap_Mat.Text) || string.IsNullOrWhiteSpace(TXT_Ap_Pat.Text) ||
        	    string.IsNullOrWhiteSpace(TXT_Nombres.Text) || string.IsNullOrWhiteSpace(TXT_Calle.Text) || 
        	    string.IsNullOrWhiteSpace(TXT_Col.Text))

        		
        	
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	
        	
                
            else

          {

            CapturaRES pCaptura1 = new CapturaRES();
            pCaptura1.Ape_mat = TXT_Ap_Mat.Text.ToUpper();
            pCaptura1.Ape_pat = TXT_Ap_Pat.Text.ToUpper();
            pCaptura1.Nombres = TXT_Nombres.Text.ToUpper();
           // pCaptura1.Edad = (DateTime.Today.AddTicks(-DTI_FecNac.Value.Ticks).Year);

            pCaptura1.Fecha_naci = DTI_FecNac.Text.ToUpper();

            if(RBT_F.Checked){
            pCaptura1.Sexo = RBT_F.Text.ToUpper();
            }
            
            else if(RBT_M.Checked){
            pCaptura1.Sexo = RBT_M.Text.ToUpper();
            }

            pCaptura1.Edo_civil = CMB_EdoCiv.Text.ToUpper();
            pCaptura1.Telefono   = TXT_TelCas.Text.ToUpper();
            //pCaptura1.Direccion  =  TXT_Dir.Text.Trim();
            pCaptura1.Colonia    = TXT_Col.Text.ToUpper();
            pCaptura1.calle      =  TXT_Calle.Text.ToUpper();
            pCaptura1.CP         =   TXT_CP.Text.ToUpper();
            pCaptura1.Entre_que_calles =TXT_Entre.Text.ToUpper();
           // pCaptura1.Datos_electorales = TXT_TelCel.Text.ToUpper();
            pCaptura1.Seccion_electoral = TXT_SecElect.Text.ToUpper();
            //pCaptura1.Direccion_Ife = TXT_Dir.Text.Trim();
            pCaptura1.Curpri = TXT_Curppri.Text.ToUpper();
            pCaptura1.Curp = TXT_Curp.Text.ToUpper();

            
           
            pCaptura1.Id = clienteActual.Id;

            if (CapturaDAL.Actualizar(pCaptura1) > 0)
            {
                MessageBox.Show("El Registro se actualizo", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                

            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
          }
        }


        
        
        }
           
        

        

         void BTN_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       void Limpiar()
        {
           TXT_Nombres.Clear();
           TXT_IFE.Clear();
           TXT_Ap_Mat.Clear();
           TXT_Ap_Pat.Clear();
           TXT_Calle.Clear();
           TXT_Col.Clear();
           TXT_CP.Clear();
           TXT_Curppri.Clear();
           TXT_Curp.Clear();
           TXT_CveElector.Clear();
           
           
            
        }

       
        
       
    
       
    
    
    
        
        
        
       
        
        
        
        void BTN_CancelarClick(object sender, EventArgs e)
        {
        	 Application.Exit();
        }
        
        
        
       
}
}
