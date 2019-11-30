using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8Ulloa.Visitors;

namespace Laboratorio8Ulloa.Elements
{
    public class Milk : IProduct
    {
        /// <summary>
        /// Implements price.
        /// </summary>
        public double Price { get; set; } = 800;

        /// <summary>
        /// Perform visitor action.
        /// </summary>
        /// <param name="visitor">Visitor.</param>
        public void Accept(IVisitor visitor)
        {
            visitor.VisitProduct(this);
        }
    }
}
