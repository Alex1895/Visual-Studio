using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema
{
    class ClietesDAL
    {
    	public static int Agregar(Cliente pCliente )
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios ( Usuario,Contraseña,Nombre,Ape_Pat, Ape_Mat,Tipo_usuario) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
      pCliente.Usuario, pCliente.Contraseña, pCliente.Nombre, pCliente.Apellido, pCliente.Apellido2, pCliente.Tipo_Usuario), coneccion.Obtenerconeccion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id ,Usuario,Contraseña,Nombre, Ape_Mat,Ape_Pat,Tipo_Usuario FROM usuarios  where Nombre ='{0}' or Ape_Pat='{1}' ", pNombre, pApellido), coneccion.Obtenerconeccion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
               
                
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Usuario = _reader.GetString(1);
                pCliente.Contraseña = _reader.GetString(2);
                pCliente.Nombre = _reader.GetString(3);
                pCliente.Apellido = _reader.GetString(4);
                 pCliente.Apellido2 = _reader.GetString(5);
                  pCliente.Tipo_Usuario = _reader.GetString(6);


                _lista.Add(pCliente);
            }

            return _lista;
        }



        public static Cliente ObtenerCliente(int pId)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion =  coneccion.Obtenerconeccion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id,Usuario, Contraseña, Nombre, Ape_Pat,	Ape_Mat,Tipo_Usuario FROM usuarios where Id={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
               
                 pCliente.Id = _reader.GetInt32(0);
                pCliente.Usuario = _reader.GetString(1);
                pCliente.Contraseña = _reader.GetString(2);
                pCliente.Nombre = _reader.GetString(3);
                pCliente.Apellido = _reader.GetString(4);
                 pCliente.Apellido2 = _reader.GetString(5);
                  pCliente.Tipo_Usuario = _reader.GetString(6);


            }

            conexion.Close();
            return pCliente;

        }



        public static int Actualizar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion =  coneccion.Obtenerconeccion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update usuarios set Usuario='{0}', Contraseña='{1}', Nombre='{2}', Ape_Pat='{4}',Ape_Mat='{5}' where Id={3}",
               pCliente.Usuario, pCliente.Contraseña,pCliente.Nombre, pCliente.Id,pCliente.Apellido,pCliente.Apellido2), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion =  coneccion. Obtenerconeccion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From usuarios where Id={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


    }
}
