using FAQ_Vyapp.Db.Repository;
using FAQ_Vyapp.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace FAQ_Vyapp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NewQuestionController : ControllerBase
    {
        private readonly FAQRepository _repository;

        public NewQuestionController(FAQRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<NewQuestionDTO> Get() =>
            _repository.GetNewQuestions();

        [HttpPost]
        public bool Post(NewQuestionDTO newQuestion) =>
            _repository.addNewQuestion(newQuestion);

        [HttpPut("{id}")]
        public bool Put(int id, string answer) =>
            _repository.AnswerQuestion(id, answer);
    }
}
