using System;

namespace ClassesDesign.OrderClasses.Products
{
    public sealed class Strings : Product
    {
        #region Properties
        public Byte GaugeMinSize { get; set; }
        public Byte GaugeMaxSize { get; set; }
        public Byte StringsCount { get; set; }
        //Other strings props...
        #endregion Properties

        #region Constructors
        public Strings(
            Int32 id, String name,
            String description, Double price,
            Byte gaugeMinSize, Byte gaugeMaxSize, 
            Byte stringsCount) :
            base(id, name, description, price)
        {
            GaugeMinSize = gaugeMinSize;
            GaugeMaxSize = gaugeMaxSize;
            StringsCount = stringsCount;
        }
        #endregion Constructors

        #region Methods
        public override String GetProductDetails()
        {
            return String.Format($"Size: {GaugeMinSize} - {GaugeMaxSize}, Strings in pack: {StringsCount}");
        }
        #endregion Methods
    }
}
