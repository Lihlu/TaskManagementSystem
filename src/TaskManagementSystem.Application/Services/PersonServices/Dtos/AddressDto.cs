using Abp.AutoMapper;
using TaskManagementSystem.Domain.Person;

namespace TaskManagementSystem.Services.PersonServices.Dtos
{
    [AutoMap(typeof(Address))]
    public class AddressDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}
