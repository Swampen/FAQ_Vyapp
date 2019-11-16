using System.ComponentModel.DataAnnotations;

namespace FAQ_Vyapp.Models.DTO
{
    public class NewQuestionDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Not a valid e-mail address")]
        public string Email { get; set; }
        [Required]
        public string Question { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
