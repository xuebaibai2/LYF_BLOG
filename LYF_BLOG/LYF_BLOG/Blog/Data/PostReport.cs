using LYF_BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("PostReport")]
    public partial class PostReport
    {
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime? Timestamp { get; set; }

        [Required]
        [StringLength(500)]
        public string Reason { get; set; }
        
        public bool Feedback { get; set; }

        public bool Resolved { get; set; }

        public string ResolvedTimestamp { get; set; }

        //------------------------------------Foreign Key--------------------------------------//
        public int ResolvedById { get; set; }

        public int PostId { get; set; }

        public int ReportedById { get; set; }

        [ForeignKey("ReportedById")]
        public virtual BlogUser ApplicationUser { get; set; }

        [ForeignKey("ResolvedById")]
        public virtual BlogUser ApplicationUser1 { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}