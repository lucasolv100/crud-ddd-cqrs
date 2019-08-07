using Product.Domain.Core.Commands;

namespace Product.Domain.Commands
{
    public class DeleteProductCommand : ICommand
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        
    }
}