using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Part_db
{
    class PartContext : DbContext
    {
        public PartContext() : base() { }

        DbSet<Part> Parts { get; set; }
        DbSet<Type> Type { get; set; }

    }
}
