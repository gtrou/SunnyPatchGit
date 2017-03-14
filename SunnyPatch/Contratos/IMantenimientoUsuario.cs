using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Contratos
{
    public interface IMantenimientoUsuario
    {
        bool AutenticarUsuario(string nombre, string contraseña);
        Usuario ObtenerUsuario(string nombreUser);
    }
}
