using System;
using System.ComponentModel.DataAnnotations;

namespace FAQ_Vyapp.Models.Entity
{
    public class NewQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }
        public DateTime Date { get; set; }

    }
}
