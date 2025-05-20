using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class BookingCollectionRepo : IBookingRepo
    {
        public List<Booking> _bookings;

        public BookingCollectionRepo()
        {
            _bookings = new List<Booking>();

        }

        public virtual void Add(Booking booking)
        {
            _bookings.Add(booking);
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }
        public void Delete(int animalID)
        {
            Booking bookingToRemove = _bookings.FirstOrDefault((Booking b) => b.AnimalID == animalID);
            if (bookingToRemove != null)
            {
                _bookings.Remove(bookingToRemove);
            }
        }
    }
}
