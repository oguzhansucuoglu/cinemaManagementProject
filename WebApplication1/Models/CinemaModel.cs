using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CinemaModel
    {
        public Int32 Id { get; set; }
        [Required]
        public string? movieGenre { get; set; }
        [Required]
        public string? mName { get; set; }
        public string? dName { get; set; }
        public string? language { get; set; }
        public string? hall { get; set; }
        [Range(70, 240)]
        [Required]
        public int duration { get; set; }
        public string? features { get; set; }
        public string? topic { get; set; }

        public static List<CinemaModel> GetList()
        {
            List<CinemaModel> movies = new List<CinemaModel>
            {
            };
            return movies;
        }

        public static CinemaModel Get(int Id1)
        {
            List<CinemaModel> movies = GetList();

            foreach(CinemaModel movie in movies)
            {
                if(movie.Id == Id1)
                {
                    return movie;
                }
            }
            return null;
        }

        public CinemaModel() { }
        public CinemaModel(Int32 Id, string movieGenre, string mName, string dName, string language, string hall, int duration, string features, string topic)
        {
            this.movieGenre = movieGenre;
            this.mName = mName;
            this.dName = dName;
            this.features = features;
            this.topic = topic;
            this.duration = duration;
            this.language = language;
            this.hall = hall;
            this.Id = Id;
        }
    }
}
