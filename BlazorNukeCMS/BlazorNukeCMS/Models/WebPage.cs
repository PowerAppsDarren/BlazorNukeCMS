namespace BlazorNukeCMS.Models
{
    public class WebPage
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
