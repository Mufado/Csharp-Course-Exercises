using System;
using System.Globalization;

namespace First.Exercises.PolimorfismExercise
{
    class UsedProduct : Product
    {
        public DateTime ManufactureData { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureData) : base(name, price)
        {
            ManufactureData = manufactureData;
        }

        public override string priceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureData})";
        }
    }
}
