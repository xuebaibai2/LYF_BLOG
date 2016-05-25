using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    [Table("Board")]
    public partial class Board
    {
        public Board()
        {
            Category = new HashSet<Category>();
        }
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Disabled { get; set; }

        public virtual ICollection<Category> Category { get; set; }
    }
}