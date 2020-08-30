using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Models.Concrete
{
    public class Question
    {
        public string Title { get; set; }
        public string[] Options { get; set; } // {"birinci","ikinci","ucuncu"}
    }
}
