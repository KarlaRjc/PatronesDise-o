using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._9_Contenedor
{
    /// <summary>
    /// Esta clase asignada todas las propiedades de forma encapsulada
    /// </summary>
    class FachadaImpresora
    {
        Impresora impresora;

        public FachadaImpresora(string texto)
        {
            impresora = new Impresora();
            impresora.SetColor(true);
            impresora.SetHoja("A4");
            impresora.SetTipoDocumento("PDF");
            impresora.SetTexto(texto);
        }

        public string Imprimir()
        {
          return impresora.Imprimir();
        }
    }
}
