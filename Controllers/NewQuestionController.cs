using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAQ_Vyapp.Db.Repository;
using FAQ_Vyapp.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QandA_Vyapp.Db;
using QandA_Vyapp.Db.Entity;

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
        

    }   
}
