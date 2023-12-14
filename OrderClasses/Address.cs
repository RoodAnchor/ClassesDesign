using System;

namespace ClassesDesign.OrderClasses
{
    public class Address
    {
        #region Properties
        public String Country { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public Int32 ZipCode { get; set; }
        public Int32 Building { get; set; }
        public Int32 PremiseNumber { get; set; }
        #endregion Properties

        #region Constructors
        public Address(
            String country, String city, String street,
            Int32 zipCode, Int32 building, Int32 premiseNumber )
        {
            Country = country;
            City = city;
            Street = street;
            ZipCode = zipCode;
            Building = building;
            PremiseNumber = premiseNumber;
        }
        #endregion Constructors

        #region Methods
        public override string ToString()
        {
            return $"{ZipCode}, {Country}, {City}, {Street}, {Building}, {PremiseNumber}";
        }
        #endregion Methods
    }
}
