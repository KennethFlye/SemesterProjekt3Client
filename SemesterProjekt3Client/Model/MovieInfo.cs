namespace SemesterProjekt3Client.Model
{
    public class MovieInfo
    {
        public int InfoId { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public string PgRating { get; set; }
        public DateTime PremiereDate { get; set; }
        public bool CurrentlyShowing { get; set; }
        public string MovieUrl { get; set; }
        MovieInfo() { }

        public MovieInfo(int id, string title, int length, string genre, string pgRating, DateTime premiereDate, bool currentlyShowing, string movieUrl)
        {
            InfoId = id;
            Title = title;
            Length = length;
            Genre = genre;
            PgRating = pgRating;
            PremiereDate = premiereDate;
            CurrentlyShowing = currentlyShowing;
            MovieUrl = movieUrl;
        }

        public override string ToString()
        {
            return Title;
        }

    }
}
