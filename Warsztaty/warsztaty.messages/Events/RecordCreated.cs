using System;
namespace warsztaty.messages.Events
{
    public class RecordCreated : IEvent
    {
        public string Key { get; }

        protected RecordCreated()
        {
        }

        public RecordCreated(string key)
        {
            Key = key;
        }
    }
}
