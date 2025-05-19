using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class MemberService
    {
        private IMemberRepo _memberrepo;

        public MemberService(IMemberRepo memberrepo)
        {
            _memberrepo = memberrepo;
        }

        public void Add(MemberAccount memberAccount )
        {
            _memberrepo.Add(memberAccount);
        }

        public List<MemberAccount> GetAll()
        {
            return _memberrepo.GetAll();
        }

        public void delete(int id)
        {
            _memberrepo.Delete(id);
        }





    }
}
