using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QandA_Vyapp.Db.Entity
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public Answer Answer { get; set; }
    }
}
