using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8Ulloa.Elements;

namespace Laboratorio8Ulloa.Visitors
{
    public class Discount : IVisitor
    {
        /// <summary>
        /// Value of the discount.
        /// </summary>
        private double _value = 0.1;

        /// <summary>
        /// Apply a discount over a product.
        /// </summary>
        /// <param name="product">Product to apply discount.</param>
        public void VisitProduct(IProduct product)
        {
            product.Price -= product.Price * _value;
        }
    }
}
