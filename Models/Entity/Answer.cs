using System.ComponentModel.DataAnnotations;

namespace QandA_Vyapp.Db.Entity
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        
    }
}