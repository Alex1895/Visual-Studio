using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Apellido2 { get; set; }
        public string Tipo_Usuario { get; set; }




        public Cliente() { }

        public Cliente(int pId, string pNombre, string pApellido, string pApellido2, string pUsuario, string pContraseña, string pTipo_Usuario)
        {
            this.Id = pId;
            this.Usuario = pUsuario;
            this.Contraseña = pContraseña;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Apellido2 = pApellido2;
            this.Tipo_Usuario = pTipo_Usuario;


        }

    }
}
