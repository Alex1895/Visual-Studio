/*
 * Creado por SharpDevelop.
 * Usuario: COMPAQ
 * Fecha: 05/03/2015
 * Hora: 01:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Sistema
{
	/// <summary>
	/// Description of BUSCACAPTURA.
	/// </summary>
	public partial class BUSCACAPTURA : Form
	{
		public BUSCACAPTURA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		 public CapturaRES ClienteSelecionad { get; set; }
		void BUSCACAPTURALoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			dtg12.DataSource = CapturaDAL.BuscarR(buscar_nombre.Text );
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (dtg12.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt32(dtg12.CurrentRow.Cells[0].Value);
                ClienteSelecionad = CapturaDAL.ObtenerCliente(Id);

                this.Hide();
            }
            else
                MessageBox.Show(" Seleccione un Registro");
		}
		
		void Dtg12CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
