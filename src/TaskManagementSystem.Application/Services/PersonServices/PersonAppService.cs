using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using TaskManagementSystem.Domain.Person;
using TaskManagementSystem.Services.PersonServices.Dtos;
using TaskManagementSystem.Users.Dto;

namespace TaskManagementSystem.Services.PersonServices
{
    public class PersonAppService : AsyncCrudAppService<Person, CreatePersonDto, Guid>, IPersonAppService
    {
        private readonly PersonManager _personManager;
        public PersonAppService(IRepository<Person, Guid> repository, PersonManager personManager) : base(repository)
        {
            _personManager = personManager;
        }

        public async override Task<CreatePersonDto> CreateAsync(CreatePersonDto input)
        {
            Address address = new Address
            {
                Street = input.AddressDto.Street,
                City = input.AddressDto.City,
                Province = input.AddressDto.Province,
                PostalCode = input.AddressDto.PostalCode,
            };


            await _personManager.CreatePersonAsync(input.CreateUserDto.Name,
                 input.CreateUserDto.Surname,
                 input.CreateUserDto.EmailAddress,
                 input.CreateUserDto.UserName,
                 input.CreateUserDto.Password,
                 address);

            return input;

        }
    }
}
