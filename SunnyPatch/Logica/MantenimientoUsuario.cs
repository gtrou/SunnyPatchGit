using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MantenimientoUsuario
    {
        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            if (nombreUsuario.Length != 0 && contraseña.Length != 0)
            {
                try
                {
                   /* var user = (from u in contexto.Usuarios
                                where u.NombreUsuario.Equals(nombreUsuario) && u.Contraseña.Equals(contraseña)
                                select u).FirstOrDefault();
                    return user != null;*/
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al conectar con la Base de Datos", ex);
                }

            }
            return false;
        }




    }
}
