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
            Debug.WriteLine("gemmer fil");
            base.Add(activity);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer fil");
            string path = "Activity.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_activity));
        }
    }
}
