using Product.Domain.Core.Commands;

namespace Product.Domain.Commands
{
    public class InsertProductCommand : ICommand
    {
        public InsertProductCommand(string description, string name, decimal originalPrice, decimal discountPrice, decimal factoryPrice)
        {
            Description = description;
            Name = name;
            OriginalPrice = originalPrice;
            DiscountPrice = discountPrice;
            FactoryPrice = factoryPrice;
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal FactoryPrice { get; set; }

        
    }
}