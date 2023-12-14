using ClassesDesign.OrderClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDesign.OrderClasses.Products
{
    public sealed class Drums : Product
    {
        #region Properties
        public Byte KickDrumCount { get; set; }
        public SnareDrumsEnum SnareDrumType { get; set; }
        //Other drums props...
        #endregion Properties

        #region Constructors
        public Drums(
            Int32 id, String name,
            String description, Double price,
            Byte kickDrumCount, 
            SnareDrumsEnum snareDrumType) :
            base(id, name, description, price)
        {
            KickDrumCount = kickDrumCount;
            SnareDrumType = snareDrumType;
        }
        #endregion Constructors

        #region Methods
        public override String GetProductDetails()
        {
            return String.Format($"Kick drum count: {KickDrumCount}, Snare drum type: {SnareDrumType}");
        }
        #endregion Methods
    }
}
