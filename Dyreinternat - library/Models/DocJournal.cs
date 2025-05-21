using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyreinternat___library.Models
{
    internal class DocJournal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Treatment { get; set; }

        public DocJournal (int id, string name, string species, string treatment)
        {
            Id = id;
            Name = name;
            Species = species;
            Treatment = treatment;
        }

        public DocJournal()
        {

        }

    }
}
