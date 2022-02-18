using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplicationRSS.Models
{
    public class Post
    {
        public Post(
            string title,
            string description,
            string content,
            string category,
            string author)
        {
            this.Title = title;
            this.Description = description;
            this.Content = content;
            this.Category = category;
            this.Author = author;
            this.PostId = Guid.NewGuid();
            this.Slug = Regex.Replace(
                    this.Title.ToLower(), @"\s", "-", RegexOptions.Compiled);
            this.PublishedOn = DateTime.Now;
            this.AuthorEmail = $"{this.Author}@mail.com";
        }

        public Guid PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string AuthorEmail { get; set; }
    }
}
