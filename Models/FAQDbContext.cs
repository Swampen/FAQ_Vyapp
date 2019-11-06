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
        public DbSet<Answer> Answers { get; set; }

        public FAQDbContext(DbContextOptions<FAQDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Text = "Question",
                    Answer = new Answer
                    {
                        Id = 1,
                        Text = "Answer"
                    }
                }
            );
        }

        public IEnumerable<QuestionDTO> GetQuestions()
        {
            List<QuestionDTO> questionDTOs = new List<QuestionDTO>();
            try
            {
                List<Question> questions = Questions.ToList();
                foreach (var q in questions)
                {
                    questionDTOs.Add(MapQuestion(q));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                questionDTOs = null;
            }
            return questionDTOs;
        }

        public QuestionDTO MapQuestion(Question entity)
        {
            return new QuestionDTO
            {
                Id = entity.Id,
                Text = entity.Text,
                Answer = MapAnswer(entity.Answer)
            };
        }

        private AnswerDTO MapAnswer(Answer entity)
        {
            return new AnswerDTO
            {
                Id = entity.Id,
                Text = entity.Text
            };
        }
    }
}
