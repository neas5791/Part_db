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

        public DbSet<Part> Parts { get; set; }
        public DbSet<Type> Type { get; set; }

    }
}
