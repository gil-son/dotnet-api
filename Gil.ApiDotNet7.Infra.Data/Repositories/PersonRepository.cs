using System;
using Microsoft.EntityFrameworkCore;
using Gil.ApiDotNet7.Domain.Entities;
using Gil.ApiDotNet7.Infra.Data.Context;
using Gil.ApiDotNet7.Domain.Repositories;
namespace Gil.ApiDotNet7.Infra.Data.Repositories
{

    public class PersonRepository : IPersonRepository
    {

        private readonly ApplicationDbContext _db;
        public PersonRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Person> CreateAync(Person person)
        {
            _db.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task DeleteAsync(Person person)
        {
            _db.Remove(person);
            await _db.SaveChangesAsync();
        }

        public async Task EditeAync(Person person)
        {
            _db.Update(person);
            await _db.SaveChangesAsync(); 
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _db.People.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Person>> GetPeopleAsync()
        {
            return await _db.People.ToListAsync();
        }
    }
}
