using System.ComponentModel.DataAnnotations;

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
