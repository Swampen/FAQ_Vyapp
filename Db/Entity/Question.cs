using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA_Vyapp.Db.Entity
{
    public class Question
    {
        public string Text { get; set; }
        public Answer Answer { get; set; }
    }
}
