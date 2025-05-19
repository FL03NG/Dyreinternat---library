using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace Dyreinternat___library.Repository
{
    public class EventJsonRepo : EventCollectionRepo
    {
        public EventJsonRepo()
        {
            LoadFile();
        }

        private void LoadFile()
        {
            string path = "Event.Json";
            string json = File.ReadAllText(path);
            _events = JsonSerializer.Deserialize<List<Event>>(json);
        }

        public override void Add(Event events)
        {
            Debug.WriteLine("gemmer fil");
            base.Add(events);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer fil");
            string path = "Event.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_events));
        }
    }
}
