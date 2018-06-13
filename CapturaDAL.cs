/*
 * Creado por SharpDevelop.
 * Usuario: COMPAQ
 * Fecha: 04/03/2015
 * Hora: 08:49 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
	/// <summary>
	/// Description of CapturaDAL.
	/// </summary>
	 class CapturaDAL
	{
		 public static int Agregar(CapturaRES pCaptura)
        {

            string cnsulta = "Insert into `datos personales` values ('" + pCaptura.Ape_pat + "','" + pCaptura.Ape_mat + "','" + pCaptura.Nombres + "','" + pCaptura.Edad + "','" + pCaptura.Fecha_naci + "','" + pCaptura.Sexo + "','" + pCaptura.Edo_civil + "','" + pCaptura.Telefono + "','" + pCaptura.Colonia + "','" + pCaptura.calle + "','" + pCaptura.CP + "','" + pCaptura.Entre_que_calles + "','" + pCaptura.Seccion_electoral + "','" + pCaptura.Direccion_Ife + "','" + pCaptura.Curpri + "','" + pCaptura.Curp + "')";
            MySqlCommand comando = new MySqlCommand(cnsulta, coneccion.Obtenerconeccion()); 

            int retorno = 0;

        

            
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
	
	 public static List<CapturaRES> BuscarR(string pNombres)
        {
            List<CapturaRES> _lista = new List<CapturaRES>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
         "SELECT * FROM `datos personales`  where Nombre like '%{0}%'" , pNombres), coneccion.Obtenerconeccion());
           
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
              CapturaRES   pCaptura = new CapturaRES();
               
                
               /* pCaptura.Id = _reader.GetInt32(0);
                pCaptura.Ape_mat = _reader.GetString(1);
                pCaptura.Ape_pat = _reader.GetString(2);
                pCaptura.Nombres =_reader.GetString(3);
                 //pCaptura.Edad =_reader.GetInt32(4);
                  //pCaptura.Fecha_naci =_reader.GetString(5);
                   pCaptura.Sexo =_reader.GetString(6);
                   pCaptura.Edo_civil = _reader.GetString(7);
                   pCaptura.Telefono = _reader.GetString(8);
                  
                   pCaptura.Colonia = _reader.GetString(10);
                   pCaptura.calle = _reader.GetString(11);
                   pCaptura.CP =_reader.GetString(12);
                   pCaptura.Entre_que_calles =_reader.GetString(13);
                   pCaptura.Seccion_electoral = _reader.GetString(14);
                   pCaptura.Direccion_Ife = _reader.GetString(15);
                   pCaptura.Curpri = _reader.GetString(16);
                  // pCaptura.Curp = _reader.GetString(17);*/
                    pCaptura.Id = _reader.GetInt32(0);
                pCaptura.Ape_mat = _reader.GetString(1);
                pCaptura.Ape_pat = _reader.GetString(2);
                pCaptura.Nombres =_reader.GetString(3);
                 pCaptura.Sexo =_reader.GetString(6);
                pCaptura.Edo_civil = _reader.GetString(7);
                 pCaptura.Telefono = _reader.GetString(8);
                  pCaptura.Colonia = _reader.GetString(9);
                pCaptura.calle = _reader.GetString(10);
                 pCaptura.CP =_reader.GetString(11);
                   pCaptura.Entre_que_calles =_reader.GetString(12);
               // pCaptura.Direccion_Ife = _reader.GetString(13);
                   pCaptura.Curpri = _reader.GetString(16);
                   pCaptura.Curp = _reader.GetString(15);
                   pCaptura.Seccion_electoral = _reader.GetString(14);
                   
                   
                   
                   
                
                
               
             

                _lista.Add(pCaptura);
            }

            return _lista;
        }
	 
	 
	 public static CapturaRES ObtenerCliente(int pId)
        {
             CapturaRES  pCaptura = new CapturaRES();
            MySqlConnection conexion =  coneccion.Obtenerconeccion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT Id ,`Ape_Mat`,`Ape_Pat`, `Nombre`, `Edad`,`Fecha_Naci`,`Sexo`,`Edo_Civil`,`Telefono`,`Colonia`,`Calle`,`CP`,`Entre_que_calles`,`Direccion _IFE`,`Curpri`,`Curp` FROM `datos personales` where Id={0}", pId), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            while (_reader.Read())
            {
               
                 pCaptura.Id = _reader.GetInt32(0);
                pCaptura.Ape_mat = _reader.GetString(1);
                pCaptura.Ape_pat = _reader.GetString(2);
                pCaptura.Nombres =_reader.GetString(3);
                pCaptura.Sexo =_reader.GetString(6);
                pCaptura.Edo_civil = _reader.GetString(7);
                 pCaptura.Telefono = _reader.GetString(8);
                  pCaptura.Colonia = _reader.GetString(9);
                pCaptura.calle = _reader.GetString(10);
                 pCaptura.CP =_reader.GetString(11);
                   pCaptura.Entre_que_calles =_reader.GetString(12);
               // pCaptura.Direccion_Ife = _reader.GetString(13);
                   pCaptura.Curpri = _reader.GetString(14);
                   pCaptura.Curp = _reader.GetString(15);
                   pCaptura.Seccion_electoral = _reader.GetString(13);
                   
                  
                   
                   
            
            }

            conexion.Close();
            return pCaptura;

        }
	 
	 
	  public static int Actualizar(CapturaRES pCaptura)
        {
            int retorno = 0;
            MySqlConnection conexion =  coneccion.Obtenerconeccion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update `datos personales` set Ape_Mat ='{1}', Ape_Pat='{2}', Nombre='{3}', Edad='{4}',Fecha_Naci='{5}', Sexo='{6}' where Id={0}",
             pCaptura.Id  ,pCaptura.Ape_mat, pCaptura.Ape_pat,pCaptura.Nombres, pCaptura.Edad,pCaptura.Fecha_naci,pCaptura.Sexo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

	 
	 

	 
	 
	 
	 }
	 
}
