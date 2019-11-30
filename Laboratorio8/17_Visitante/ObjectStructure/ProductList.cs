using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio8Ulloa.Elements;
using Laboratorio8Ulloa.Visitors;

namespace Laboratorio8Ulloa.ObjectStructure
{
    /// <summary>
    /// Object Structure.
    /// </summary>
    public class ProductList
    {
        /// <summary>
        /// Internal list of products.
        /// </summary>
        private List<IProduct> _products = new List<IProduct>();

        /// <summary>
        /// Add new products to de list.
        /// </summary>
        /// <param name="product">Product to add.</param>
        public void Attach(IProduct product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Remove product from list.
        /// </summary>
        /// <param name="product">Product to delete.</param>
        public void Detach(IProduct product)
        {
            _products.Remove(product);
        }

        /// <summary>
        /// Accept a visitor for each product in the list.
        /// </summary>
        /// <param name="visitor">Visitor to accept.</param>
        public void Accept(IVisitor visitor)
        {
            foreach (IProduct product in _products)
            {
                product.Accept(visitor);
            }
        }

        /// <summary>
        /// Perform an action with the product list using delegate function.
        /// </summary>
        /// <param name="callback">Function to perform.</param>
        public void Excecute(Action<List<IProduct>> callback)
        {
            callback(_products);
        }
    }
}
