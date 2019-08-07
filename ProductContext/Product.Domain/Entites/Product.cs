using System;
using Flunt.Validations;
using Product.Domain.Core.Entities;
using Product.Domain.ValueObjects;

namespace Product.Domain.Entites
{
    public class Product : Entity
    {
        public Product(string description, string name, Price originalPrice, Price discountPrice, Price factoryPrice)
        {
            Id = 0;
            Description = description;
            Name = name;
            OriginalPrice = originalPrice;
            DiscountPrice = discountPrice;
            FactoryPrice = factoryPrice;
            CreateDate = DateTime.Now;

            Validations();
            
        }

        public string Description { get; private set; }
        public string Name { get; private set; }
        public Price OriginalPrice { get; private set; }
        public Price DiscountPrice { get; private set; }
        public Price FactoryPrice { get; private set; }

        public void Validations(){
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNullOrEmpty(Name, "Product.Name", "O nome não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Description, "Product.Description", "A descrição não pode ser nulo ou vazio")
            );
        }

        public void UpdateProduct(
            int id, string description, string name, Price originalPrice, Price discountPrice, Price factoryPrice
        )
        {
            Id = id;
            Description = description;
            Name = name;
            OriginalPrice = originalPrice;
            DiscountPrice = discountPrice;
            FactoryPrice = factoryPrice;
            EditDate = DateTime.Now;

            Validations();
        }
        public void DeleteProduct(
            int id, string description, string name, Price originalPrice, Price discountPrice, Price factoryPrice
        )
        {
            Id = id;
            Description = description;
            Name = name;
            OriginalPrice = originalPrice;
            DiscountPrice = discountPrice;
            FactoryPrice = factoryPrice;
            EditDate = DateTime.Now;
            DeleteDate = DateTime.Now;

            Validations();
        }
    }
}