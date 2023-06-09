﻿using SemesterProjekt3Client.Controllers;

namespace SemesterProjekt3Client.Model
{
    public class ShowRoom
    {

        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Seat> Seats { get; set; }

        public int GetAmountOfRows()
        {
            int amountOfRows = 0;
            foreach (Seat seat in Seats)
            {
                if (seat.RowNumber > amountOfRows)
                {
                    amountOfRows = seat.RowNumber;
                }
            }

            return amountOfRows;
        }

        public override string ToString()
        {
            return $"Sal {RoomNumber}";
        }

    }
}
