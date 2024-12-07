using question_api.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace question_api.Model
{
#pragma warning disable

    public class Question
    {

        public Guid Id { get; set; }

        [Required]
        public string Prompt { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        [Required]
        public string Option3 { get; set; }
        [Required]
        public string Option4 { get; set; }
        [Required]
        public string Option5 { get; set; }
        [Required]
        public int CorrectAnswer { get; set; }

        //[NotMapped]
        //public NivelDificuldade NivelDificuldade { get; set; }
    }
}
