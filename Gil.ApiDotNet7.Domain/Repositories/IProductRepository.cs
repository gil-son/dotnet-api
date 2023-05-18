using System;
using Gil.ApiDotNet7.Domain.Entities;
namespace Gil.ApiDotNet7.Domain.Repositories
{

    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<ICollection<Product>> GetPeopleAsync();
        Task<Product> CreateAync(Product product);
        Task EditeAync(Product product);
        Task DeleteAsync(Product product);
    }
}
