using FAQ_Vyapp.Db.DTO;
using FAQ_Vyapp.Db.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FAQ_Vyapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FAQController : ControllerBase
    {
        private readonly FAQRepository _repository;

        public FAQController(FAQRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<QuestionDTO> Get() =>
            _repository.GetQuestions();

        [HttpPut("{id}")]
        public int Put(int id, int rating) =>
            _repository.ChangeRating(id, rating);
    }
}