namespace question_api.Models
{
    public class Item
    {
         public Guid Id { get; set; }
        public string? Question { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? Option4 { get; set; }
        public string? Option5 { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
