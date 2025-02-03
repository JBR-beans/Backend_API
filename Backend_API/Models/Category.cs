
using System.ComponentModel.DataAnnotations;

namespace Backend_API.Models
{
	public class Category
	{
		// primary key
		[Key]
        public int CategoryId { get; set; }
		public string CategoryName { get; set; }	

		// nav
		public virtual ICollection<Content> PostedContent { get; set; }

    }
}