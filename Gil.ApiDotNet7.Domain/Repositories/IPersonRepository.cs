using System;
using Gil.ApiDotNet7.Domain.Entities;
namespace Gil.ApiDotNet7.Domain.Repositories
{

    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(int id);
        Task<ICollection<Person>> GetPeopleAsync();
        Task<Person> CreateAync(Person person);
        Task EditeAync(Person person);
        Task DeleteAsync(Person person);
    }
}
