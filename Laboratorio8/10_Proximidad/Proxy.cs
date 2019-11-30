using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._10_Proximidad
{
    public class ProxyImage : Image
    {
        private RealImage realImage;
        private String fileName;
        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new
                RealImage(fileName);
            }
            realImage.Display();
        }
    }
}