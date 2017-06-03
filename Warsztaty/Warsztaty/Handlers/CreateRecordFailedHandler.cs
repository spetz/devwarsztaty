using System;
using System.Threading.Tasks;
using warsztaty.messages.Events;

namespace Warsztaty.API.Handlers
{
	public class CreateRecordFailedHandler : IEventHandler<CreateRecordFailed>
	{
		public async Task HandleAsync(CreateRecordFailed @event)
		{
			Console.WriteLine($"Record: '{@event.Key}' was not created. " + 
                              $"Reason: {@event.Reason}");
			await Task.CompletedTask;
		}
	}
}
