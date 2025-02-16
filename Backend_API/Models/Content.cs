﻿

using Backend_API.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Backend_API.Models
{
	public class Content
	{
		public int ContentId { get; set; }

		public string Title { get; set; }

		public string Body { get; set; }

		public string AuthorId { get; set; }

        public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		[ForeignKey(nameof(Category.CategoryId))]
		public int CategoryId { get; set; }

		// nav, related data
        public virtual Category? Category { get; set; }
        //public virtual SiteUser Author { get; set; }


    }
}
