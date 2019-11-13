using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Vyapp.Db.DTO
{
    public class QuestionDTO
    {
        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public int Rating { get; set; }

    }
}
