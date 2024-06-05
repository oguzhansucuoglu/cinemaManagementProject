using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CinemaModel
    {
        public int Id { get; set; }
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
                new CinemaModel { Id = 0, movieGenre = "Horror", mName = "Exorcist", hall = "Cevahir Mall", language = "Turkish dub", duration = 95, dName = "William Friedkin", features ="3D" },
                new CinemaModel { Id = 1, movieGenre = "Biography", mName = "Oppenheimer", hall = "Akasya Mall", language = "English with Turkish Sub", duration = 125, dName = "Christopher Nolan", features = "2D IMAX" },
                new CinemaModel { Id = 2, movieGenre = "Action", mName = "Shin Godzilla", hall = "İstinye Mall", language = "Japanese with Turkish Sub", duration = 90, dName = "Hideaki Anno", features = "2D" }
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
    }
}
