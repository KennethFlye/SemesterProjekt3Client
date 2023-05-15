namespace SemesterProjekt3Client.Model
{
    public class Showing
    {

        
        public Showing()
        {

        }
        public Showing(DateTime datetime, bool IsKidFriendly,ShowRoom room,MovieCopy copy ) 
        {
            IsKidFriendly = false;
        }
  
        public int ShowingId { get; set; }
        public DateTime startTime { get; set; }
        public bool IsKidFriendly { get; set; }
        public ShowRoom? ShowRoom { get; set; }
        public MovieCopy MovieCopy { get; set; }


        public string ToString()
        {
            return $"{MovieCopy.MovieType.Title}  {ShowRoom.RoomNumber}. Sal  {startTime}";
        }

    }
}
