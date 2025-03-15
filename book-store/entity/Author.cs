using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthYear { get; set; }
        public DateOnly DeathYear { get; set; }
        public string Naitonality { get; set; }

        public Author(int id, string firstName, string middleName, string lastName, DateOnly birthYear, DateOnly deathYear, string nationality)
        {
            Id = id; ;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthYear = birthYear;
            DeathYear = deathYear;
            Naitonality = nationality;
        }
    }
}
