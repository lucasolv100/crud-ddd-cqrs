using Product.Domain.Core.Commands;

namespace Product.Domain.Core.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
         ICommandResult Handle(T commad);
    }
}