using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    // Author entity class
    public class Author
    {
        public int Id { get; set; } // Unique identifier for the author

        [Required] // Specifies that AuthorName is required
        public string AuthorName { get; set; } // Name of the author
    }
}
