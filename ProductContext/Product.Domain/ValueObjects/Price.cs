using Product.Domain.Core.ValueObjects;
using Product.Domain.Enums;

namespace Product.Domain.ValueObjects
{
    public class  Price : ValueObject
    {
        public Price(decimal value, EPriceType type)
        {
            Value = value;
            Type = type;
        }

        public decimal Value { get; private set; }
        public EPriceType Type { get; private set; }
    }
}