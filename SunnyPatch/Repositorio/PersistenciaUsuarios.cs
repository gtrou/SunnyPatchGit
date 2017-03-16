using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;

namespace Repositorio
{
    public class PersistenciaUsuarios
    {
        public static List<Usuario> ObtenerUsuarios()
        {
            string archivoUsuarios = File.ReadAllText(ConfigurationSettings.AppSettings["archivoUsuarios"]);
            return JsonConvert.DeserializeObject<List<Usuario>>(archivoUsuarios);
        }

        public static void GuardarUsuarios(List<Usuario> usuarios)
        {
            string jsonUsuarios = JsonConvert.SerializeObject(usuarios);
            File.WriteAllText(ConfigurationSettings.AppSettings["archivoUsuarios"], jsonUsuarios);
        }
    }
}
