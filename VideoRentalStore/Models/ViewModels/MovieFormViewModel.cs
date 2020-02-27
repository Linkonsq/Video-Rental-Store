using System.Collections.Generic;

namespace VideoRentalStore.Models.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        //Another approach
        //public int? Id { get; set; }

        //[Required]
        //public string Name { get; set; }


        //[Required]
        //[Display(Name = "Genre")]
        //public byte? GenreId { get; set; }

        //[Required]
        //[Display(Name = "Release Date")]
        //public DateTime? ReleaseDate { get; set; }

        //[Required]
        //[Display(Name = "Number in Stock")]
        //[Range(1, 20)]
        //public int? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                {
                    return "Edit Movie";
                }

                return "New Movie";
            }
        }
    }
}