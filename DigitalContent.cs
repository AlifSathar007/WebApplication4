using System;

namespace EventAndContentApp.Models
{
    public class DigitalContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentUrl { get; set; }
        public string Description { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
