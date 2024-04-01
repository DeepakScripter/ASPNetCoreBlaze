using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    // Entity class representing a genre
    public class Genre
    {
        // Unique identifier for the genre
        public int Id { get; set; }

        // Name of the genre
        [Required(ErrorMessage = "Genre name is required.")]
        public string Name { get; set; }
    }
}
