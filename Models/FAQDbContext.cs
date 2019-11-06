using Microsoft.EntityFrameworkCore;
using QandA_Vyapp.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QandA_Vyapp.Db.DTO;

namespace QandA_Vyapp.Db
{
    public class FAQDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        public FAQDbContext(DbContextOptions<FAQDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    QuestionText = "Question",
                    AnswerText = "Answer"
                }
            );
        }
    }
}
