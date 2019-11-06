using System.ComponentModel.DataAnnotations;

namespace QandA_Vyapp.Db.DTO
{
    public class AnswerDTO
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
    }
}