using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    [Serializable]
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string ClaveLogin { get; set; }

        public Usuario()
        {
        }

        public override string ToString()
        {
            return this.NombreUsuario;
        }

        
    }
}
