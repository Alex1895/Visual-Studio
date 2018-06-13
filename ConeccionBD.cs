/*
 * Creado por SharpDevelop.
 * Usuario: COMPAQ
 * Fecha: 12/02/2015
 * Hora: 11:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema
{
    /// <summary>
    /// Description of coneccion.
    /// </summary>
    public class coneccion
    {
        public static MySqlConnection Obtenerconeccion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database = gestor1; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}
