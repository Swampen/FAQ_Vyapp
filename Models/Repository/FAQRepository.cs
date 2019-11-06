using QandA_Vyapp.Db;
using QandA_Vyapp.Db.DTO;
using QandA_Vyapp.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Vyapp.Db.Repository
{
    public class FAQRepository
    {
        private readonly FAQDbContext _context;

        public FAQRepository(FAQDbContext context)
        {
            _context = context;
        }

        public IEnumerable<QuestionDTO> GetQuestions()
        {
            List<QuestionDTO> questionDTOs = new List<QuestionDTO>();
            try
            {
                List<Question> questions = _context.Questions.ToList();
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
                QuestionText = entity.QuestionText,
                AnswerText = entity.AnswerText,
            };
        }
    }
}
