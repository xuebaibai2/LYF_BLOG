using LYF_BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("Topic")]
    public class Topic
    {
        public Topic()
        {
            FollowTopic = new HashSet<FollowTopic>();
            //Category = new HashSet<Category>();
            Post = new HashSet<Post>();
            //Topic1 = new HashSet<Topic>();
            TopicTrack = new HashSet<TopicTrack>();
        }
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public int ViewCount { get; set; }

        public int PostCount { get; set; }

        public int Flag { get; set; }

        public int Type { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? LastPosted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Posted { get; set; }

        public int? SpamScore { get; set; }

        public int SpamReporters { get; set; }

        public string CustomProperties { get; set; }

        //------------------------------------Foreign Key--------------------------------------//
        public int? LastPostId { get; set; }
        
        public int LastPostAuthorId { get; set; }

        public int CategoryId { get; set; }
        
        public int AuthorId { get; set; }

        public int? OriginalTopicId { get; set; }
        
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        
        [ForeignKey("AuthorId")]
        public virtual BlogUser ApplicationUser { get; set; }
        
        [ForeignKey("LastPostAuthorId")]
        public virtual BlogUser ApplicationUser1 { get; set; }
        
        [ForeignKey("LastPostId")]
        public virtual Post Post1 { get; set; }
        
        [ForeignKey("OriginalTopicId")]
        public virtual Topic Topic2 { get; set; }

        public virtual ICollection<FollowTopic> FollowTopic { get; set; }

        public virtual ICollection<Post> Post { get; set; }

        //public virtual ICollection<Topic> Topic1 { get; set; }
        
        public virtual ICollection<TopicTrack> TopicTrack { get; set; }
    }


}