using System;
using System.Threading.Tasks;

namespace warsztaty.messages.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
