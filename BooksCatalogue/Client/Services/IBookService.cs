using BooksCatalogue.Shared.Models;

namespace BooksCatalogue.Client.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
        Task AddBookAsync(Book book);
        Task DeleteBookAsync(int id);
    }
}
