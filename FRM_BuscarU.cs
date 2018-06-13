/*
 * Creado por SharpDevelop.
 * Usuario: COMPAQ
 * Fecha: 17/02/2015
 * Hora: 10:58 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
//using System;
//using System.Drawing;
//using System.Windows.Forms;
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
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class BUSCAR_USARIO : Form
	{
		public BUSCAR_USARIO()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		 public Cliente ClienteSelecionado { get; set; }
		void Form1Load(object sender, EventArgs e)
		{
			
		}
		
		void Btn_BuscarClick(object sender, EventArgs e)
		{
			 dataGridView1.DataSource = ClietesDAL.Buscar(TXT_Nombre.Text, TXT_Ape.Text);
		
		
		
		
		}
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSelecionado = ClietesDAL.ObtenerCliente(Id);

                this.Hide();
            }
            else
                MessageBox.Show(" Seleccione un Registro");
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
	}
}
