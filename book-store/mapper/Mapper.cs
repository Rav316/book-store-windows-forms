﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper
{
    public abstract class Mapper<E, D>
    {
        public abstract D ToDto(E entity);
    }
}
