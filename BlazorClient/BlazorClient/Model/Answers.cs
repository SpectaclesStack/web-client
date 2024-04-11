
using BlazorClient.Model;
namespace BlazorClient.Model
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public DateTime ? CreateAt { get; set; }
        public string ? Answer {  get; set; }

    }
}