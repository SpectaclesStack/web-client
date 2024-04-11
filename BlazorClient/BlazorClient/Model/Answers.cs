
using BlazorClient.Model;
namespace BlazorClient.Model
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public required Questions Questions { get; set; }
        public required Users Users { get; set; }
        public required DateTime CreateAt { get; set; }
        public required string Answer {  get; set; }

    }
}