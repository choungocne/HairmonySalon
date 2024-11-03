using Harmony.Repositories.Interfaces;
using HarmonySalon.Reponsitories.Entities;
using Harmony.Services;
namespace Harmony.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _repository;
		public UserService(IUserRepository repository)
		{
			_repository = repository;
		}


		public Task<List<User>> Users()
		{
			return _repository.GetAllUser();
		}
	}
}

namespace Harmony.Services
{
	public interface IUserService
	{
	}
}