using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Knowledge.Models;

    public class KnowledgeSharingContext : DbContext
    {
        public KnowledgeSharingContext (DbContextOptions<KnowledgeSharingContext> options)
            : base(options)
        {
        }

        public DbSet<Knowledge.Models.Sharing> Sharing { get; set; }
    }
