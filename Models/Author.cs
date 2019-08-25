using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public string PenName { get; set; }

        public string PreferredGenre { get; set; }

        public List<Book> Books   { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
