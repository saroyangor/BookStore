using BookStore.Core.Abstractions;
using BookStore.Core.Models;

namespace BookStore.Application.Services;

public class BooksService(IBooksRepository booksRepository) : IBooksService
{
    public async Task<List<Book>> GetAllBooks()
    {
        return await booksRepository.Get();
    }

    public async Task<Guid> CreateBook(Book book)
    {
        return await booksRepository.Create(book);
    }

    public async Task<Guid> UpdateBook(Guid id, string title, string description, decimal price)
    {
        return await booksRepository.Update(id, title, description, price);
    }

    public async Task<Guid> DeleteBook(Guid id)
    {
        return await booksRepository.Delete(id);
    }
}
