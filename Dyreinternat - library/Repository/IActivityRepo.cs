using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IActivityRepo
    {
        public List<Activity> GetAll();
        public void Add(Activity events);
    }
}
