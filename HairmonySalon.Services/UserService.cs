using Harmony.Repositories.Interfaces;
using HarmonySalon.Reponsitories.Entities;
<<<<<<< HEAD
using Harmony.Services;
=======
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;



>>>>>>> e5ccdb388b3ff135e611b16a1b7e08d9e9f1d629
namespace Harmony.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _repository;
		public UserService(IUserRepository repository)
		{
			_repository = repository;
		}

<<<<<<< HEAD
=======
		public void AssignUserGroupPermission(int groupId, char permission, params int[] entityIds)
		{
			throw new NotImplementedException();
		}

		

		public void ClearLoginSession(Guid sessionId)
		{
			throw new NotImplementedException();
		}

		public int ClearLoginSessions(int userId)
		{
			throw new NotImplementedException();
		}

		public Guid CreateLoginSession(int userId, string requestingIpAddress)
		{
			throw new NotImplementedException();
		}

		
>>>>>>> e5ccdb388b3ff135e611b16a1b7e08d9e9f1d629

		public Task<List<User>> Users()
		{
			return _repository.GetAllUser();
		}

		public bool ValidateLoginSession(int userId, Guid sessionId)
		{
			throw new NotImplementedException();
		}
	}
}

namespace Harmony.Services
{
	public interface IUserService
	{
	}
}