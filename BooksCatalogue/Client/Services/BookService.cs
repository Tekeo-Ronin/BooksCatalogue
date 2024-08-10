using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BooksCatalogue.Shared.Models;

namespace BooksCatalogue.Client.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Book>>("api/books");
        }

        public async Task AddBookAsync(Book book)
        {
            await _httpClient.PostAsJsonAsync("api/books", book);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/books/{id}");
        }
    }
}
