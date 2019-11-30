using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8Ulloa.Visitors;

namespace Laboratorio8Ulloa.Elements
{ 
    /// <summary>
    /// Element interface that will accept visitors.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Price of the product.
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// Accept visitor action.
        /// </summary>
        /// <param name="visitor">Visitor</param>
        void Accept(IVisitor visitor);
    }
}
