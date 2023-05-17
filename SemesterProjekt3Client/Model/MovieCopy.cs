namespace SemesterProjekt3Client.Model
{
    public class MovieCopy
    {

        public int CopyId { get; set; }
        public string Language { get; set; }
        public bool Is3D { get; set; }
        public double Price { get; set; }
        public MovieInfo MovieType { get; set; }

        
       
        public MovieCopy() { }

        public MovieCopy(int copyId, string language, bool is3D, double price, MovieInfo movieType)
        {
            CopyId = copyId;
            Language = language;
            Is3D = is3D;
            Price = price;
            MovieType = movieType;
        }

        

        public override string ToString()
        {
            return $"{CopyId}: {MovieType.Title} ({Language}, {Is3DToString()}, {Price} Kr.)";
        }

        public string Is3DToString()
        {
            if (Is3D)
            {
                return "3D";
            }
            else
            {
                return "2D";
            }
        }
    }
}
