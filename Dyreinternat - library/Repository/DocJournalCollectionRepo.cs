using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class DocJournalCollectionRepo : IDocJournalRepo
    {
        public List<DocJournal> _docJournal;

        public DocJournalCollectionRepo()
        {
            _docJournal = new List<DocJournal>();

        }

        public virtual void Add(DocJournal docJournal)
        {
            Debug.WriteLine("add docJournal");
            _docJournal.Add(docJournal);
        }

        public List<DocJournal> GetAll()
        {
            return _docJournal;
        }
        public void Delete(int id)
        {
            DocJournal DocLogToRemove = null;

            foreach (DocJournal d in _docJournal)
            {
                if (d.DocJournalID == id)
                {
                    DocLogToRemove = d;
                    break;
                }
            }

            if (DocLogToRemove != null)
            {
                _docJournal.Remove(DocLogToRemove);
            }
        }


    }
}
