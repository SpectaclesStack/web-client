using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Model
{
    public class Question
    {
        public Question() { }
        public int QuestionId { get; set; }
        public int userid { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }
        public required DateTime CreateAt { get; set; }
    }
}
