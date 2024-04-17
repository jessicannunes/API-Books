namespace Books_APIweb.Model
{
    public class Book
    {
        public int Id { get; set; }
        public int Isbn { get; set; }
        public string? Title { get; set; }
        public string? PublishingCompany{ get; set; }
        public decimal? Price { get; set; }

    }
}
