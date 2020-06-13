using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc5.Models
{
    public class MvcBasicContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}