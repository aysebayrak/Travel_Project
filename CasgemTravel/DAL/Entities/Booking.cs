using System;

namespace CasgemTravel.DAL.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Duration { get; set; }
        public string Mail { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
    }
}