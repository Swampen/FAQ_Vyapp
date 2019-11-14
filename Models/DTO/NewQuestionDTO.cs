using System.ComponentModel.DataAnnotations;

namespace FAQ_Vyapp.Models.DTO
{
    public class NewQuestionDTO
    {
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Not a valid e-mail address")]
        public string Email { get; set; }
        public string Question { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
