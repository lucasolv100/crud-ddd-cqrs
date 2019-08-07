using Flunt.Notifications;
using Product.Domain.Commands;
using Product.Domain.Core.Commands;
using Product.Domain.Core.Handlers;
using Product.Domain.Enums;
using Product.Domain.ValueObjects;

namespace Product.Domain.Handlers
{
    public class ProductCommandHandler : Notifiable, IHandler<InsertProductCommand>,
    IHandler<UpdateProductCommand>,
    IHandler<DeleteProductCommand>
    {
        public ICommandResult Handle(InsertProductCommand commad)
        {
            //Gerar os VOs
            var originalPrice = new Price(
                commad.FactoryPrice,
                EPriceType.FactoryPrice
            );
            var finalPrice = new Price(
                commad.OriginalPrice,
                EPriceType.FactoryPrice
            );
            var discountPrice = new Price(
                commad.DiscountPrice,
                EPriceType.FactoryPrice
            );

            //Gerar as entidades

            var product = new Domain.Entites.Product(
                commad.Description,
                commad.Name,
                finalPrice,
                discountPrice,
                originalPrice
            );

            //Aplicar as validações
            AddNotifications(product);

            //verificar as validações
            if(Invalid){
                return new CommandResult(false, "Não foi possivel cadastrar o produto!");
            }

            //Salvar

            //Devolver o retorno
            return new CommandResult(true, "Produto cadastrado com sucesso!");
        }

        public ICommandResult Handle(UpdateProductCommand commad)
        {
            throw new System.NotImplementedException();
        }

        public ICommandResult Handle(DeleteProductCommand commad)
        {
            throw new System.NotImplementedException();
        }
    }
}