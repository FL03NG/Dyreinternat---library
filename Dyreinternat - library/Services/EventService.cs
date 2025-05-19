using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class EventService
    {
        private IEventRepo _eventrepo;

        public EventService(IEventRepo eventRepo)
        {
            _eventrepo = eventRepo;
        }

        public void Add(Event events)
        {
            _eventrepo.Add(events);
        }

        public List<Event> GetAll()
        {
            return _eventrepo.GetAll();
        }
    }
}
