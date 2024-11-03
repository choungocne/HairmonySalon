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

		public Task AuthenticateExternalAsync(ExternalAuthenticationContext context)
		{
			throw new NotImplementedException();
		}

		public Task AuthenticateLocalAsync(LocalAuthenticationContext context)
		{
			throw new NotImplementedException();
		}

		public Task GetProfileDataAsync(ProfileDataRequestContext context)
		{
			throw new NotImplementedException();
		}

		public Task IsActiveAsync(IsActiveContext context)
		{
			throw new NotImplementedException();
		}

		public Task PostAuthenticateAsync(PostAuthenticationContext context)
		{
			throw new NotImplementedException();
		}

		public Task PreAuthenticateAsync(PreAuthenticationContext context)
		{
			throw new NotImplementedException();
		}

		public Task SignOutAsync(SignOutContext context)
		{
			throw new NotImplementedException();
		}

		public Task<List<User>> Users()
		{
			return _repository.GetAllUser();
		}
	}
}
