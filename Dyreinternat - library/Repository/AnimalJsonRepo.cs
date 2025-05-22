using System.Diagnostics;
using System.Text.Json;
using dyreinternat___library.Models;
//using dyreinternat___web.Pages;

namespace dyreinternat___library.Repository
{
    public class AnimalJsonRepo : AnimalCollectionRepo
    {
        public AnimalJsonRepo() 
        {
            LoadFile();
        }

        private void LoadFile()
        {
            string path = "Animal.Json";
            string json = File.ReadAllText(path);
            _animals = JsonSerializer.Deserialize<List<Animal>>(json);
        }

        public override void Add(Animal animal)
        {
            Debug.WriteLine("gemmer fil");
            base.Add(animal);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer fil");
            string path = "Animal.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_animals));
        }

        public override void Delete(int id)
        {
            Animal animalToRemove = _animals.FirstOrDefault(b => b.AnimalID == id);
            if (animalToRemove != null)
            {
                _animals.Remove(animalToRemove);
                SaveFile();
            }
        }

    }
}
