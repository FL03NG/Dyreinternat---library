
using System.Diagnostics;
using System.Reflection.Metadata;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class AnimalCollectionRepo : IAnimalRepo
    {
        public List<Animal> _animals;

        public AnimalCollectionRepo()
        {
            _animals = new List<Animal>();
            
        }

        public virtual void Add(Animal animal)
        {
            Debug.WriteLine("add2");
            _animals.Add(animal);
        }

        public virtual void Delete(int id)
        {
            Animal animalToRemove = _animals.FirstOrDefault((Animal b) => b.AnimalID == id);
            if (animalToRemove != null)
            {
                _animals.Remove(animalToRemove);
            }
        }

        public List<Animal> GetAll()
        {
            return _animals;
        }

        

    }
}
