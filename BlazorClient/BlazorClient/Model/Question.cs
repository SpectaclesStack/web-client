using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Model
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int userid { get; set; }
        //[Required]
        public string ? Title { get; set; }
        //[Required]
        public string ? Body { get; set; }
        public DateTime ? CreateAt { get; set; }
    }
}
