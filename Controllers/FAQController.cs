using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAQ_Vyapp.Db.Repository;
using Microsoft.AspNetCore.Mvc;
using QandA_Vyapp.Db.DTO;

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
    }
}