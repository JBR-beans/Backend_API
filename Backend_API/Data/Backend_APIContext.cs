using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Backend_API.Areas.Identity.Data;

namespace Backend_API.Data
{
    public class Backend_APIContext : IdentityDbContext<SiteUser>
    {
        public Backend_APIContext (DbContextOptions<Backend_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Backend_API.Models.Content> Content { get; set; } = default!;
        public DbSet<Backend_API.Models.Category> Category { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			
			// to add in seed data, there cant be any dynamic values
			// in class we used DateTime.now to fill in CreatedAt and UpdatedAt
			// changing this to a set value allowed the seed data to work

            // seed data
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Category",
                    PostedContent = []
                }
				);

			modelBuilder.Entity<Content>().HasData(
				new Content
				{
					ContentId = 1,
					Title = "1Title",
					Author = "Author",
					Body = "body",
					CreatedAt = new DateTime(2025, 04, 14),
					UpdatedAt = new DateTime(2025, 04, 14),
					CategoryId = 1
				},
				new Content
				{
					ContentId = 2,
					Title = "2Title",
					Author = "Author",
					Body = "body",
					CreatedAt = new DateTime(2025, 04, 14),
					UpdatedAt = new DateTime(2025, 04, 14),
					CategoryId = 1
				},
				new Content
				{
					ContentId = 3,
					Title = "3Title",
					Author = "Author",
					Body = "body",
					CreatedAt = new DateTime(2025, 04, 14),
					UpdatedAt = new DateTime(2025, 04, 14),
					CategoryId = 1
				},
				new Content
				{
					ContentId = 4,
					Title = "4Title",
					Author = "Author",
					Body = "body",
					CreatedAt = new DateTime(2025, 04, 14),
					UpdatedAt = new DateTime(2025, 04, 14),
					CategoryId = 1
				}
				);

			modelBuilder.Entity<Feedback>().HasData(
				new Feedback
				{
					FeedbackId = 1,
					Title = "first feedback",
					Description = "the contents of the feedback",
					CreatedAt = new DateTime(2023, 12, 12),
					UpdatedAt = new DateTime(2023, 12, 12)
				}
				);

			modelBuilder.Entity<BusinessContactDetails>().HasData(
				new BusinessContactDetails
				{
					BusinessContactDetailsId = 1,
					BusinessName = "the business's name LLC",
					BusinessEmail = "busybusiness@email.com",
					BusinessPhone = "(123)456-7890",
					BusinessMailingAddress = "42 Wallaby Way, Sydey, Australia"
				}
				);
            // map nav properties
            modelBuilder.Entity<Content>().Navigation(c => c.Category).AutoInclude();
			modelBuilder.Entity<Category>().Navigation(c => c.PostedContent).AutoInclude();
		}
        public DbSet<Backend_API.Models.Feedback> Feedback { get; set; } = default!;
        public DbSet<Backend_API.Models.BusinessContactDetails> BusinessContactDetails { get; set; } = default!;
	}
}
