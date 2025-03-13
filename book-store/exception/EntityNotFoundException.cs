using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.exception
{
    internal class EntityNotFoundException: Exception
    {
        public EntityNotFoundException(string message): base(message) { }
    }
}
