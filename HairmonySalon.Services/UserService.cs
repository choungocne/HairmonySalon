using Harmony.Repositories.Interfaces;
using HarmonySalon.Reponsitories.Entities;
using Harmony.Services.Interfaces;

namespace Harmony.Services
{
    public class UserService : IUserService
	{
		private readonly IUserRepository _repository;
		public UserService(IUserRepository repository)
		{
			_repository = repository;
		}

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
