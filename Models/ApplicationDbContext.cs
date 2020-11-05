﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GigHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<ApplicationUser>()
        //        .HasMany(u => u.Followers)
        //        .WithRequired(f => f.Followee)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<ApplicationUser>()
        //        .HasMany(u => u.Followees)
        //        .WithRequired(f => f.Follower)
        //        .WillCascadeOnDelete(false);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}