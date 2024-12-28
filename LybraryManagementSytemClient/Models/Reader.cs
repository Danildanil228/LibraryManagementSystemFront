using System.Collections.Generic;
namespace LybraryManagementSytemClient.Models
{
    

    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public ICollection<Book> BorrowedBooks { get; set; }
    }
}
