using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using LYF_BLOG.Blog.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LYF_BLOG.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }
        public bool Approved { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? LastActivityDate { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public string RegisterIPAddress { get; set; }
        public string LastLoginIPAddress { get; set; }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("BlogDB", throwIfV1Schema: false) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Topic>()
                    .HasRequired(m => m.ApplicationUser)
                    .WithMany(t => t.Topic)
                    .HasForeignKey(m => m.AuthorId)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Topic>()
                    .HasRequired(m => m.ApplicationUser1)
                    .WithMany(t => t.Topic1)
                    .HasForeignKey(m => m.LastPostAuthorId)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                    .HasRequired(m => m.ApplicationUser)
                    .WithMany(t => t.Post)
                    .HasForeignKey(m => m.AuthorId)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostReport>()
                    .HasRequired(m => m.ApplicationUser)
                    .WithMany(t => t.PostReport)
                    .HasForeignKey(m => m.ReportedById)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostReport>()
                    .HasRequired(m => m.ApplicationUser1)
                    .WithMany(t => t.PostReport1)
                    .HasForeignKey(m => m.ResolvedById)
                    .WillCascadeOnDelete(false);

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        public string Description { get; set; }
    }
}