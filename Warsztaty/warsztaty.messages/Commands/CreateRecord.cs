using System;
namespace warsztaty.messages.Commands
{
    public class CreateRecord : ICommand
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }
}
