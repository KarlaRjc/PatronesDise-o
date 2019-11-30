using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8Ulloa.Elements;

namespace Laboratorio8Ulloa.Visitors
{
    public class IVA : IVisitor
    {
        /// <summary>
        /// Value of the tax.
        /// </summary>
        private double _value = 0.13;

        /// <summary>
        /// Add the tax value to the product.
        /// </summary>
        /// <param name="product">Product to apply tax.</param>
        public void VisitProduct(IProduct product)
        {
            product.Price += product.Price * _value;
        }
    
    }
}
