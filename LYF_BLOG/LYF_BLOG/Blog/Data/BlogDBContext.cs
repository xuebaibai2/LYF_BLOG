using LYF_BLOG.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Blog.Data
{
    public class BlogDBContext : ApplicationDbContext
    {
        public virtual DbSet<BlogUser> BlogUser { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Board> Board { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<FollowTopic> FollowTopic { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostReport> PostReport { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicTrack> TopicTrack { get; set; }
    }
}