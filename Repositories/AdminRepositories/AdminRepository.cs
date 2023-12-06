using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.AdminRepositories
{
	public class AdminRepository : IAdminRepository
	{
		Context c = new Context();

		public Admin GetForLogin(Admin admin)
		{
			var value = c.Admins.FirstOrDefault(x => x.KullaniciAd == admin.KullaniciAd && x.Sifre == admin.Sifre);
			return value;
		}
	}
}
