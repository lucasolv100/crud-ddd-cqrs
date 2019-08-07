using Product.Domain.Core.Commands;

namespace Product.Domain.Commands
{
    public class UpdateProductCommand : ICommand
    {
        public UpdateProductCommand(int id, string description, string name, decimal originalPrice, decimal discountPrice, decimal factoryPrice)
        {
            Id = id;
            Description = description;
            Name = name;
            OriginalPrice = originalPrice;
            DiscountPrice = discountPrice;
            FactoryPrice = factoryPrice;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal FactoryPrice { get; set; }
    }
}