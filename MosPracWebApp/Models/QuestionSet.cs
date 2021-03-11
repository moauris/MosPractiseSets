using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosPracWebApp.Models
{
    public class QuestionSet
    {
        public int QuestionSetID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Topic> Topics { get; set; }
        public List<Question> Questions { get; set; }
    }
}
