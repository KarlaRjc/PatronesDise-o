using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BasesDeDatosConexion;
namespace AbstractFactory.Fabrica
{
    public class ConexionFabrica : FabricaAbstracta
    {

        public override Conexion creaConexion(String tipo) {
            tipo = tipo.ToLower();
            //Console.WriteLine("El tipo es "+tipo.ToLower() );
            if (tipo.Equals("oracle")) {
                return new OracleConexion();
            }
            else if (tipo.Equals("sqlserver"))
            {
                return new SQLServerConexion();
            }
            else if (tipo.Equals("postgresql"))
            {
                return new PostgreSQLConexion();
            }
            else
                return new MySQLConexion();
            }
          
        }
    }

