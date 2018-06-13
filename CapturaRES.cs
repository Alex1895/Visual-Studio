/*
 * Creado por SharpDevelop.
 * Usuario: COMPAQ
 * Fecha: 04/03/2015
 * Hora: 08:40 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sistema
{
	/// <summary>
	/// Description of CapturaDAL.
	/// </summary>
	 public class CapturaRES
	{
		
		 public int Id { get; set; }
    	public string Ape_mat { get; set; }
        public string Ape_pat { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public string Fecha_naci { get; set; }
        public string Sexo { get; set; }
        public string Edo_civil { get; set; }
        public string Telefono { get; set; }
        //public string Direccion { get; set; }
        public string Colonia { get; set; }
      
        public string calle { get; set; }
        public string CP { get; set; }
        public string Entre_que_calles { get; set; }
       // public string Datos_electorales { get; set; }
        public string Seccion_electoral { get; set; }
        public string Direccion_Ife { get; set; }
        public string Curpri { get; set; }

        public string Curp { get; set; }
		
		
		public CapturaRES(){}
	
	  public CapturaRES(int pId,string pApe_mat, string pApe_pat, string pNombres, int pEdad, string pFecha_naci, string pSexo,
            string pEdo_civil, string pTelefono, /*string pDireccion,*/ string pColonia, string pcalle, string pCP
            , string pEntre_que_calles, string pSeccion_electoral, string pDireccion_Ife, string pCurpri, string pCurp)
        {
            this.Id = pId;
        	this.Ape_mat = pApe_mat;
            this.Ape_pat = pApe_pat;
            this.Nombres = pNombres;
            this.Edad = pEdad;
            this.Fecha_naci = pFecha_naci;
            this.Sexo = pSexo;
            this.Edo_civil = pEdo_civil;
            this.Telefono = pTelefono;
            //this.Direccion = pDireccion;
            this.Colonia = pColonia;
          
            this.calle = pcalle;
            this.CP = pCP;
            this.Entre_que_calles = pEntre_que_calles;
            
            this.Seccion_electoral = pSeccion_electoral;
            this.Direccion_Ife = pDireccion_Ife;
            this.Curpri = pCurpri;
            this.Curp = pCurp;
          

        }
	 
	 
	 
	 }
}
