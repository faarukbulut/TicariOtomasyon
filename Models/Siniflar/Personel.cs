﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Personel
	{
		[Key]
		public int PersonelID { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string PersonelAd { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string PersonelSoyad { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(250)]
		public string PersonelGorsel { get; set; }

		public SatisHareket SatisHareket { get; set; }
		public Departman Departman { get; set; }
	}
}
