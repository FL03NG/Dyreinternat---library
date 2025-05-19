using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class ActivityCollectionRepo : IActivityRepo
    {
        public List<Models.Activity> _activity;

        public ActivityCollectionRepo()
        {
            _activity = new List<Models.Activity>();

        }

        public virtual void Add(Models.Activity activity)
        {
            Debug.WriteLine("add2");
            _activity.Add(activity);
        }

        public List<Models.Activity> GetAll()
        {
            return _activity;
        }
    }
}
