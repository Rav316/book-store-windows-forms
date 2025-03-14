using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    internal class Language
    {
        public int Id { get; set; }
        public string Name {  get; set; }

        public Language(int id, string name)
        { 
            Id = id;
            Name = name;
        }
    }
}
