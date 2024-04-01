using YtBookStore.Models.Domain;

namespace YtBookStore.Repositories.Abstract
{
    // Interface for Author service
    public interface IAuthorService
    {
        bool Add(Author model); // Method to add an author
        bool Update(Author model); // Method to update an author
        bool Delete(int id); // Method to delete an author by ID
        Author FindById(int id); // Method to find an author by ID
        IEnumerable<Author> GetAll(); // Method to get all authors
    }
}
