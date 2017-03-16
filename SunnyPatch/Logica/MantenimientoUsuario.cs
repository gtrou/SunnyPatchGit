using Contratos;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MantenimientoUsuario : IMantenimientoUsuario
    {
        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            if (nombreUsuario.Length != 0 && contraseña.Length != 0)
            {
                List<Usuario> usuarios = PersistenciaUsuarios.ObtenerUsuarios();
                Usuario usuarioLogin = usuarios.Find(x => x.NombreUsuario.Equals(nombreUsuario) && x.ClaveLogin.Equals(contraseña));
                return usuarioLogin != null;
            }
            return false;
        }




    }
}
