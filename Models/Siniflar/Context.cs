using Microsoft.EntityFrameworkCore;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=FARUK\\SQLEXPRESS;initial catalog=TicariOtomasyon;integrated Security=true");
		}

		public DbSet<Admin> Admins { get; set; }
		public DbSet<Cari> Caris { get; set; }
		public DbSet<Departman> Departmans { get; set; }
		public DbSet<FaturaKalem> FaturaKalems { get; set; }
		public DbSet<Fatura> Faturas { get; set; }
		public DbSet<Gider> Giders { get; set; }
		public DbSet<Kategori> Kategoris { get; set; }
		public DbSet<Personel> Personels { get; set; }
		public DbSet<SatisHareket> SatisHarekets { get; set; }
		public DbSet<Urun> Uruns { get; set; }
		public DbSet<UrunDetay> UrunDetays { get; set; }
	}
}
