using System.ComponentModel.DataAnnotations;

namespace L01P022022ZL650.Models
{
	public class facultades
	{
		[Key]
		public int Id { get; set; }

		public string facultad { get; set; }
	}
}
