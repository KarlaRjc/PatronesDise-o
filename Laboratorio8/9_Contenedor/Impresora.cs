using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._9_Contenedor
{
    class Impresora
    {
        private string tipoDocumento;
        private string hoja;
        private bool color;
        private string texto;

        public void SetTipoDocumento(string tipoDocumento)
        {

            this.tipoDocumento = tipoDocumento;

        }

        public void SetHoja(string hoja)
        {
            this.hoja = hoja;
        }

        public string GetHoja()
        {

            return hoja;

        }

        public void SetColor(bool color)
        {
            this.color = color;
        }

        public bool GetColor()
        {

            return color;

        }

        public void SetTexto(string texto)
        {
            this.texto = texto;
        }

        public string GetTexto()
        {

            return texto;

        }

        public string Imprimir()
        {

            return texto;

        }
    }
}
