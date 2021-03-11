namespace MosPracWebApp.Models
{
    public class Topic
    {
        public Topic() { }
        public Topic(string cont)
        {
            Content = cont;
        }
        public int TopicID { get; set; }
        public string Content { get; set; }
        public int QuestionSetID { get; set; }
    }
}