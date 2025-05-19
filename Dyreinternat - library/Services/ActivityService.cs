using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class ActivityService
    {
        private IActivityRepo _activityrepo;

        public ActivityService(IActivityRepo activityrepo)
        {
            _activityrepo = activityrepo;
        }

        public void Add(Activity events)
        {
            _activityrepo.Add(events);
        }

        public List<Activity> GetAll()
        {
            return _activityrepo.GetAll();
        }
    }
}
