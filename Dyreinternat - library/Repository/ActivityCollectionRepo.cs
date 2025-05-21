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
        public Models.Activity Get(int id) //tilmeld
        {
            foreach (Models.Activity activity in _activity)
            {
                if (id == activity.ID)
                {
                    return activity;
                }
            }
            return null;
        }
        public virtual void Update(Models.Activity updatedActivity)
        {
            for (int i = 0; i < _activity.Count; i++)
            {
                if (_activity[i].ID == updatedActivity.ID)
                {
                    _activity[i] = updatedActivity;
                    break;
                }
            }
        }
    }
}
