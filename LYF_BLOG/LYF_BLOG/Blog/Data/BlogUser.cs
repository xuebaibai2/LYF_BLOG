using LYF_BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("BlogUser")]
    public class BlogUser
    {
        public int Id { get; set; }

        public string ProviderId { get; set; }

        [ForeignKey("ProviderId")]
        public virtual ApplicationUser Provider { get; set; }

        public virtual ICollection<Attachment> Attachment { get; set; }

        public virtual ICollection<FollowTopic> FollowTopic { get; set; }

        public virtual ICollection<Post> Post { get; set; }

        public virtual ICollection<PostReport> PostReport { get; set; }

        public virtual ICollection<PostReport> PostReport1 { get; set; }

        public virtual ICollection<Topic> Topic { get; set; }

        public virtual ICollection<Topic> Topic1 { get; set; }

        public virtual ICollection<TopicTrack> TopicTrack { get; set; }
    }
}