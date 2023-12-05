using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Departman
	{
		[Key]
		public int DepartmanID { get; set; }
		public string DepartmanAd { get; set; }
	}
}
