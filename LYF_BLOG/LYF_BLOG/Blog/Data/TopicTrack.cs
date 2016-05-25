using LYF_BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("TopicTrack")]
    public partial class TopicTrack
    {
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }

        public string LastViewed { get; set; }

        //------------------------------------Foreign Key--------------------------------------//
        public int TopicId { get; set; }

        public int ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual BlogUser ApplicationUser { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
    }
}