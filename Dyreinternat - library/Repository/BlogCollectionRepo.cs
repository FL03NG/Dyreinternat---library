using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class BlogCollectionRepo : IBlogRepo
    {
        public List<Blog> _blog;

        public BlogCollectionRepo()
        {
            _blog = new List<Blog>();

        }

        public virtual void Add(Blog blog)
        {
            Debug.WriteLine("add blog");
            _blog.Add(blog);
        }

        public List<Blog> GetAll()
        {
            return _blog;
        }
        public void Delete(int id)
        {
            Blog blogToRemove = _blog.FirstOrDefault((Blog b) => b.BlogID == id);
            if (blogToRemove != null)
            {
                _blog.Remove(blogToRemove);
            }
        }
    }
}
