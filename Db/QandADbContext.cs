using Microsoft.EntityFrameworkCore;
using QandA_Vyapp.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA_Vyapp.Db
{
    public class QandADbContext : DbContext
    {
        public QandADbContext(DbContextOptions<QandADbContext> options)
        : base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

    }
}
