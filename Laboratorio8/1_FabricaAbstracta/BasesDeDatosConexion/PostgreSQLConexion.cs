using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.BasesDeDatosConexion
{
    class PostgreSQLConexion:Conexion
    {
        public PostgreSQLConexion (){

        }

        public override String descripcion()
        {
            return "Conectado a la Base de Datos PostgreSQL.";
        }
    }
}
