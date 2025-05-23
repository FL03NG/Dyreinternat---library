﻿using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IActivityRepo
    {
        public List<Activity> GetAll();
        public void Add(Activity events);
        public Activity Get(int id);
        public void Delete(int id);
        void Update(Activity updatedActivity);
    }
}
