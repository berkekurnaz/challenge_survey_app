using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AChallenge.WebUI.Models
{
    public class HomeViewModel
    {
        public Coordinator Coordinator { get; set; }
        public Respondent Respondent { get; set; }
    }
}
