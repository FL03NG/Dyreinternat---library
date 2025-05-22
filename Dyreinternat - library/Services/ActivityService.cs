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
        public Activity Get(int id)
        {
            return _activityrepo.Get(id);
        }
        public void Update(Activity activity)
        {
            _activityrepo.Update(activity);
        }
        public void Delete(int id)
        {
            _activityrepo.Delete(id);
        }
    }
}
