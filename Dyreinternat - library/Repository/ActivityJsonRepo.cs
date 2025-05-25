using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Repository
{
    public class ActivityJsonRepo : ActivityCollectionRepo
    {
        public ActivityJsonRepo()
        {
            LoadFile();
        }

        private void LoadFile()
        {
            string path = "Activity.Json";
            string json = File.ReadAllText(path);
            _activity = JsonSerializer.Deserialize<List<dyreinternat___library.Models.Activity>>(json);
        }

        public override void Add(dyreinternat___library.Models.Activity activity)
        {
            // Find højeste eksisterende ID og læg 1 til
            int nextId = 1;
            if (_activity.Count > 0)
            {
                nextId = _activity.Max(a => a.ID) + 1;
            }

            activity.ID = nextId; // Tildel det nye unikke ID

            base.Add(activity);   // Tilføj til listen
            SaveFile();           // Gem til JSON
        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer fil");
            string path = "Activity.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_activity));
        }

        public override void Delete(int id)
        {
            Models.Activity activityToRemove = _activity.FirstOrDefault(b => b.ID == id);
            if (activityToRemove != null)
            {
                _activity.Remove(activityToRemove);
                SaveFile();
            }
        }
        public override void Update(Models.Activity updatedActivity)
        {
            base.Update(updatedActivity);
            SaveFile();
        }

    }
}
