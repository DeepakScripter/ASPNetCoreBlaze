using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    // Entity class representing a publisher
    public class Publisher
    {
        // Unique identifier for the publisher
        public int Id { get; set; }

        // Name of the publisher
        [Required(ErrorMessage = "Publisher name is required.")]
        public string PublisherName { get; set; }
    }
}
