using System.ComponentModel.DataAnnotations;

namespace Backend_API.Models
{
	public class BusinessContactDetails
	{
		[Key]
		public int BusinessContactDetailsId { get; set; }

		public string BusinessName { get; set; }

		public string BusinessPhone { get; set; }

		public string BusinessEmail { get; set; }

		public string BusinessMailingAddress { get; set; }
	}
}
