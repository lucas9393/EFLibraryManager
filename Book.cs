using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFLibraryManager
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

}