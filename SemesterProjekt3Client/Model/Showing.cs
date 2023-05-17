namespace SemesterProjekt3Client.Model
{
    public class Showing
    {

        
        public Showing()
        {
            IsKidFriendly = false;
        }
        public Showing(int id, DateTime datetime, bool IsKidFriendly,ShowRoom room,MovieCopy copy )
        { 
        }

  
        public int ShowingId { get; set; }
        public DateTime startTime { get; set; }
        public bool IsKidFriendly { get; set; }
        public ShowRoom? ShowRoom { get; set; }
        public MovieCopy MovieCopy { get; set; }


        public override string ToString()
        {
            return $"{MovieCopy.MovieType.Title};  Sal {ShowRoom.RoomNumber};   {startTime}";
        }

    }
}
