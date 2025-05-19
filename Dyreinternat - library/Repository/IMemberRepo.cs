using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IMemberRepo
    {
        public List<MemberAccount> GetAll();

        public void Add(MemberAccount memberAccount);

        public void Delete(int id);
    }
}
