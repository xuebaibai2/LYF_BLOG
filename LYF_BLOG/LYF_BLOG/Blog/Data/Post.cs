using LYF_BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("Post")]
    public class Post
    {
        public Post()
        {
            Attachment = new HashSet<Attachment>();
            //Category = new HashSet<Category>();
            Post1 = new HashSet<Post>();
            PostReport = new HashSet<PostReport>();
            //Topic1 = new HashSet<Topic>();
        }
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }

        public int Position { get; set; }

        public int Indent { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }

        public string Edited { get; set; }

        [StringLength(500)]
        public string EditReason { get; set; }

        public bool ModeratorChanged { get; set; }

        public int Flag { get; set; }

        public bool Deleted { get; set; }

        [StringLength(500)]
        public string DeleteReason { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Posted { get; set; }

        public int SpamScore { get; set; }

        public int SpamReporters { get; set; }

        public string CustomProperties { get; set; }

        //------------------------------------Foreign Key--------------------------------------//

        public int TopicId { get; set; }

        public int? ReplyToPostId { get; set; }

        public int AuthorId { get; set; }

        //[Required]
        //[StringLength(256)]
        //public string AuthorName { get; set; }
        
        [ForeignKey("AuthorId")]
        public virtual BlogUser ApplicationUser { get; set; }
        
        [ForeignKey("ReplyToPostId")]
        public virtual Post Post2 { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }

        public virtual ICollection<Attachment> Attachment { get; set; }

        //public virtual ICollection<Category> Category { get; set; }

        public virtual ICollection<Post> Post1 { get; set; }

        public virtual ICollection<PostReport> PostReport { get; set; }

        //public virtual ICollection<Topic> Topic1 { get; set; }
    }
}