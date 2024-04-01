using YtBookStore.Models.Domain;

namespace YtBookStore.Repositories.Abstract
{
    // Interface for Genre service
    public interface IGenreService
    {
        bool Add(Genre model); // Method to add a genre
        bool Update(Genre model); // Method to update a genre
        bool Delete(int id); // Method to delete a genre by ID
        Genre FindById(int id); // Method to find a genre by ID
        IEnumerable<Genre> GetAll(); // Method to get all genres
    }
}
