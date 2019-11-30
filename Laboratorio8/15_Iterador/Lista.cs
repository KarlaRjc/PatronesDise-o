using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._15_Iterador
{
    public class Lista
    {
        public IEnumerable<string> GetList()
        {
            // Lista de Elementos  
            List<string> list = new List<string>();
            list.Add("Marcos"); // Añadimos elementos  
            list.Add("Juan");
            list.Add("Luis");
            list.Add("Mario");

            // Se itera 
            foreach (var element in list)
            {
                yield return element;
            }
        }
    }
}
