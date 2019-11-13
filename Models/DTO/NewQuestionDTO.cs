using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Vyapp.Models.DTO
{
    public class NewQuestionDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
