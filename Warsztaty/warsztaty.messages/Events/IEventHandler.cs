using System.Threading.Tasks;

namespace warsztaty.messages.Events
{
    public interface IEventHandler<in T> where T : IEvent
	{
        Task HandleAsync(T @event);
	}
}
