using FAQ_Vyapp.Db.DTO;
using FAQ_Vyapp.Db.Entity;
using FAQ_Vyapp.Models.DTO;
using FAQ_Vyapp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

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

        internal IEnumerable<NewQuestionDTO> GetNewQuestions()
        {
            List<NewQuestionDTO> newQuestionDTOs = new List<NewQuestionDTO>();
            try
            {
                List<NewQuestion> newQuestions = _context.NewQuestions.ToList();
                foreach (var q in newQuestions)
                {
                    newQuestionDTOs.Add(MapNewQuestion(q));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                newQuestionDTOs = null;
            }
            return newQuestionDTOs;
        }

        internal bool addNewQuestion(NewQuestionDTO dto)
        {
            try{
                NewQuestion q = MapNewQuestionDTO(dto);
                _context.NewQuestions.Add(q);
                _context.SaveChanges();
                return true;
            }catch (Exception e){
                Console.WriteLine(e);
                return false;
            }
        }

        public int ChangeRating(int id, int rating)
        {
            try
            {
                var question = _context.Questions.Find(id);
                question.Rating += rating;
                _context.SaveChanges();
                return rating;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public QuestionDTO MapQuestion(Question entity)
        {
            return new QuestionDTO
            {
                Id = entity.Id,
                QuestionText = entity.QuestionText,
                AnswerText = entity.AnswerText,
                Rating = entity.Rating,
            };
        }

        public NewQuestionDTO MapNewQuestion(NewQuestion entity)
        {
            return new NewQuestionDTO
            {
                Name = entity.Name,
                Email = entity.Email,
                Question = entity.Question,
                Date = entity.Date.ToString("dd/MM/yyyy"),
                Time = entity.Date.ToString("hh:mm"),
            };
        }

        public NewQuestion MapNewQuestionDTO(NewQuestionDTO dto)
        {
            return new NewQuestion
            {
                Name = dto.Name,
                Email = dto.Email,
                Question = dto.Question,
                Date = DateTime.Now
            };
        }
    }
}
