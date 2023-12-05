﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Departman
	{
		[Key]
		public int DepartmanID { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string DepartmanAd { get; set; }

		public bool Durum { get; set; }
		public ICollection<Personel> Personels { get; set; }
	}
}
