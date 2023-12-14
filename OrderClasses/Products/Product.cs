using System;

namespace ClassesDesign.OrderClasses.Products
{
    public abstract class Product
    {
        #region Properties
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public Int32 Amount { get; set; }
        #endregion Properties

        #region Constructors
        public Product(
            Int32 id, String name,
            String description, Double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
        #endregion Constructors

        #region Methods
        public abstract String GetProductDetails();

        public static Double operator +(Product a, Product b)
        {
            return a.Price + b.Price;
        }
        #endregion Methods
    }
}
