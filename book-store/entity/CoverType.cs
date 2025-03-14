using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    public class CoverType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CoverType(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
