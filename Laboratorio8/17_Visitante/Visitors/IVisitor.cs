using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8Ulloa.Elements;

namespace Laboratorio8Ulloa.Visitors
{
    /// <summary>
    /// Visitor interface where action methods are defined.
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Perform action over a product.
        /// </summary>
        /// <param name="product">Product to alter.</param>
        void VisitProduct(IProduct product);
    }
}
