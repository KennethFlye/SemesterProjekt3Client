﻿using SemesterProjekt3Client.Controllers;

namespace SemesterProjekt3Client.Model
{
    public class Booking
    {

        public int BookingId { get; set; }
        public DateTime TimeOfPurchase { get; set; }
        public double Total { get; set; }
        public string? CustomerPhone { get; set; }
        public List<Seat> BookedSeats { get; set; }
        public Showing Showing { get; set; }

    }
}
