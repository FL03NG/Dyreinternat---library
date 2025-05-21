using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    internal class DocJournalJasonRepo : DocJournalCollectionRepo
    {
        public DocJournalJasonRepo()
        {
            LoadFile();
        }
        private void LoadFile()
        {
            string path = "docJournal.Json";
            string json = File.ReadAllText(path);
            _docJournal = JsonSerializer.Deserialize<List<DocJournal>>(json);
        }

        public override void Add(dyreinternat___library.Models.DocJournal docJournal)
        {
            Debug.WriteLine("gemmer blog fil");
            base.Add(docJournal);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer docJournal fil");
            string path = "DocJournal.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_docJournal));
        }



    }
}
