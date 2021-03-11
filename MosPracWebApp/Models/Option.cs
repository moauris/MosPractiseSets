namespace MosPracWebApp.Models
{
    public class Option
    {
        public Option() { }
        public Option(string cont)
        {
            Content = cont;
        }
        public int OptionID { get; set; }
        public string Content { get; set; }
        public int QuestionID { get; set; }
    }
}