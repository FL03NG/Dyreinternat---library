using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class EventCollectionRepo
    {
        public List<Event> _events;

        public EventCollectionRepo()
        {
            _events = new List<Event>();

        }

        public virtual void Add(Event events)
        {
            Debug.WriteLine("add2");
            _events.Add(events);
        }

        public List<Event> GetAll()
        {
            return _events;
        }
    }
}
