using System.Collections.Generic;

namespace MosPracWebApp.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Option> Options { get; set; }
        //public List<string> Explanations { get; set; }
        public int QuestionSetID { get; set; }
    }
}