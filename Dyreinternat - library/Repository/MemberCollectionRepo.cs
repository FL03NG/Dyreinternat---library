using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class MemberCollectionRepo : IMemberRepo
    {
        public List<Account> _account;

        public MemberCollectionRepo()
        {
            _account = new List<Account>();

        }

        public virtual void Add(Account account)
        {
            Debug.WriteLine("add account");
            _account.Add(account);
        }

        public List<Account> GetAll()
        {
            return _account;
        }

        public void Delete(int id)
        {
            Account accountToRemove = null;

            foreach (Account d in _account)
            {
                if (d.AccountID == id)
                {
                    accountToRemove = d;
                    break;
                }
            }

            if (accountToRemove != null)
            {
                _account.Remove(accountToRemove);
            }
        }
    }
}
