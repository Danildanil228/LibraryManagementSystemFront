using System;
namespace LybraryManagementSytemClient.Models
{


    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ReaderId { get; set; }
        public Reader Reader { get; set; }
    }
}
