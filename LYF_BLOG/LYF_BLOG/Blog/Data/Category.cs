using LYF_BLOG.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LYF_BLOG.Blog.Data
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Topic = new HashSet<Topic>();
        }
        //------------------------------------Property--------------------------------------//
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sort order number is required")]
        [RegularExpression(@"0|^[1-9][0-9]*",ErrorMessage ="Only number is allowed")]
        public int SortOrder { get; set; }

        public string Description { get; set; }

        public int TopicCount { get; set; }

        public int PostCount { get; set; }

        //------------------------------------Foreign Key--------------------------------------//
        public int BoardId { get; set; }
        
        [ForeignKey("BoardId")]
        public virtual Board Board { get; set; }

        public virtual ICollection<Topic> Topic { get; set; }
    }
}