using System.ComponentModel.DataAnnotations;

namespace FAQ_Vyapp.Db.Entity
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public int Rating { get; set; }
    }
}
