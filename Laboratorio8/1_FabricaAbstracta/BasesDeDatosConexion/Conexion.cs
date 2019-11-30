using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.BasesDeDatosConexion
{
   public abstract class Conexion
    {
        public Conexion() {
        }

        public virtual String descripcion() {
            return "Conexión genérica.";
        }
    }
}
