using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio8Hernandez
{
    public class Compuesto
    {
        private string nombre;
        protected int pesoMolecular;

        /// <summary>
        /// constructor que setea nombre del compuesto trabajado
        /// </summary>
        /// <param name="pNombre"></param>
        public Compuesto(string pNombre)
        {
            nombre = pNombre;
        }
        ~Compuesto() {

        }
        public virtual void Dispose()
        {
        }
        /// <summary>
        /// método virtual que muestra nombre de compuesto
        /// </summary>
        public virtual void Mostrar() 
        {
            MessageBox.Show("Nombre: " + nombre);
        }
    }
}
