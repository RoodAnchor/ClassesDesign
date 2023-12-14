using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClassesDesign.OrderClasses.Products
{
    public class ProductCollection<TProduct> : IEnumerable<TProduct> where TProduct : Product
    {
        #region Fields
        private List<TProduct> _products;
        #endregion Fields

        #region Constructors
        public ProductCollection()
        {
            _products = new List<TProduct>();
        }
        #endregion Constructors

        #region Indexers
        public TProduct this[Int32 index] 
        {
            get 
            { 
                if (index >= 0 && index < _products.Count)
                {
                    return _products[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < _products.Count)
                {
                    _products[index] = value;
                }

                return;
            }
        }

        public TProduct this[String name]
        {
            get
            {
                foreach(TProduct product in _products)
                {
                    if (product.Name == name) return product;
                }

                return null;
            }
        }
        #endregion Indexers

        #region Methods
        public void Add(TProduct product)
        {
            _products.Add(product);
        }

        public IEnumerator<TProduct> GetEnumerator()
        {
            return ((IEnumerable<TProduct>)_products).GetEnumerator();
        }

        public Double GetTotalPrice()
        {
            return _products.Select(product => product.Price).Sum();
        }

        public void Remove(TProduct product)
        {
            _products.Remove(product);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_products).GetEnumerator();
        }
        #endregion Methods
    }
}
