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
    public class BlogJsonRepo : BlogCollectionRepo
    {
        public BlogJsonRepo()
        {
            LoadFile();
        }
        private void LoadFile()
        {
            string path = "Blog.Json";
            string json = File.ReadAllText(path);
            _blog = JsonSerializer.Deserialize<List<Blog>>(json);
        }

        public override void Add(Blog blog)
        {
            Debug.WriteLine("gemmer blog fil");
            base.Add(blog);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer blog fil");
            string path = "Blog.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_blog));
        }
        public override void Delete(int id)
        {
            base.Delete(id);
        }
    }
}
