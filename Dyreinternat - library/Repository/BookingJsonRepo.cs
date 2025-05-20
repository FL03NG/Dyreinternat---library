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
    public class BookingJsonRepo : BookingCollectionRepo
    {
        public BookingJsonRepo()
        {
            LoadFile();
        }
        private void LoadFile()
        {
            string path = "Booking.Json";
            string json = File.ReadAllText(path);
            _bookings = JsonSerializer.Deserialize<List<Booking>>(json);
        }

        public override void Add(Booking booking)
        {
            Debug.WriteLine("gemmer booking fil");
            base.Add(booking);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer booking fil");
            string path = "Booking.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_bookings));
        }
    }
}
