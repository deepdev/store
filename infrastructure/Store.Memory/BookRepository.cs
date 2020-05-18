using System;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Первая книга"),
            new Book(2, "Вторая книга"),
            new Book(3, "Третья книга")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            throw new NotImplementedException();
        }
    }
}
