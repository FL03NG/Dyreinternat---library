using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    internal class DocJournalService
    {
        private IDocJournal _docJournalRepo;

        public DocJournalService(IDocJournal docJournalRepo)
        {
            _docJournalRepo = docJournalRepo; 
        }
        public void Add(DocJournal docJournal)
        {
            _docJournalRepo.Add(docJournal);
        }
        public List<DocJournal> GetAll()
        {
            return _docJournalRepo.GetAll();
        }


    }
}
