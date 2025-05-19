using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IEventRepo
    {
        public List<Event> GetAll();
        public void Add(Event events);
    }
}
