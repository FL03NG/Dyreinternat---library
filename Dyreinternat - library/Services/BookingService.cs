using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class BookingService


    {
        private IBookingRepo _bookingrepo;

        public BookingService(IBookingRepo bookingrepoRepo)
        {
            _bookingrepo = bookingrepoRepo;
        }

        public void Add(Booking booking)
        {
            _bookingrepo.Add(booking);
        }

        public List<Booking> GetAll()
        {
            return _bookingrepo.GetAll();
        }

        public void Delete(int id)
        {
            _bookingrepo.Delete(id);
        }
    }
}

