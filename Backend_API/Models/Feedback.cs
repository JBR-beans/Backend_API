using System.ComponentModel.DataAnnotations;

namespace Backend_API.Models
{
	public class Feedback
	{
		[Key]
		public int FeedbackId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

	}
}
