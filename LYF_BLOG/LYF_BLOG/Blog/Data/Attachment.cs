using LYF_BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("Attachment")]
    public class Attachment
    {
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Filename { get; set; }
        
        public int Size { get; set; }

        public int DownloadCount { get; set; }

        [Required]
        [StringLength(500)]
        public string Path { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Created { get; set; }

        //------------------------------------Foreign Key--------------------------------------//
        public int PostId { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual BlogUser ApplicationUser { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}