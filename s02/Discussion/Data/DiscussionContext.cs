using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Discussion.Models;

namespace Discussion.Data
{
    public class DiscussionContext : DbContext
    {
        public DiscussionContext (DbContextOptions<DiscussionContext> options)
            : base(options)
        {
        }

        public DbSet<Discussion.Models.Course> Course { get; set; } = default!;
    }
}
