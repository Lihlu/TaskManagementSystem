using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TaskManagementSystem.Domain.Person;
using TaskManagementSystem.Users.Dto;

namespace TaskManagementSystem.Services.PersonServices.Dtos
{
    [AutoMap(typeof(Person))]
    public class CreatePersonDto : EntityDto<Guid>
    {
        public CreateUserDto CreateUserDto { get; set; }
        public AddressDto AddressDto { get; set; }

    }
}
