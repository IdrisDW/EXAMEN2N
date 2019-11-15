using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace v2ExamenAFactory
{
    public class Conexion
    {
        public static string StringConexion()
        {

            return "Server=tcp:servidorpatronesoct.database.windows.net,1433;Initial Catalog=examenfabricapa;Persist Security Info=False;User ID=patrones;Password=CabraEspacial1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            
        }
    }
}
