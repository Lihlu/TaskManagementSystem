using System;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using TaskManagementSystem.Authorization.Users;

namespace TaskManagementSystem.Domain.Person
{
    public class PersonManager : DomainService
    {
        private readonly UserManager _userManager;
        private readonly IRepository<Person, Guid> _personRepository;

        public PersonManager(UserManager userManager, IRepository<Person, Guid> personRepository)
        {
            _personRepository = personRepository;
            _userManager = userManager;
        }

        public async Task<Person> CreatePersonAsync(
            string firstName,
            string surname,
            string emailAddress,
            string username,
            string password,
            Address address
            )
        {
            var user = new User
            {
                Name = firstName,
                Surname = surname,
                EmailAddress = emailAddress,
                UserName = username,
            };

            // TODO: Tenancy

            var identityResult = await _userManager.CreateAsync(user, password);

            var person = new Person
            {
                Address = address,
                UserId = user.Id,
            };

            await _personRepository.InsertAsync(person);

            return person;

        }
    }
}
