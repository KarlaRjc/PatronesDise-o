using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio8Hernandez
{
    public class CompuestoCompleto : Compuesto
    {
        /// <summary>
        /// asociación dirigida
        /// </summary>
        public Quimico m_Quimico;

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="pNombre"></param>
        public CompuestoCompleto(string pNombre) : base(pNombre)
        {
        }

        ~CompuestoCompleto()
        {

        }
        public override void Dispose()
        {

        }
        /// <summary>
        /// se hace el new de quimico y peso molecular se obtiene de objeto quimico y método
        /// </summary>
        public override void Mostrar()
        {
            //Adapta
            m_Quimico = new Quimico();
            pesoMolecular = m_Quimico.GetPesoMolecular("Agua");

            base.Mostrar();
            MessageBox.Show("Peso Molecular: " + pesoMolecular);

        }
    }
}
