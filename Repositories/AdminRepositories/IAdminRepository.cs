using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.AdminRepositories
{
	public interface IAdminRepository
	{
		Admin GetForLogin(Admin admin);
	}
}
