using System;
using Microsoft.EntityFrameworkCore;
using Gil.ApiDotNet7.Domain.Entities;
using Gil.ApiDotNet7.Infra.Data.Context;

namespace Gil.ApiDotNet7.Domain.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Product> CreateAync(Product product)
        {
            _db.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsync(Product product)
        {
            _db.Remove(product);
            await _db.SaveChangesAsync();
        }

        public async Task EditeAync(Product product)
        {
            _db.Update(product);
            await _db.SaveChangesAsync(); 
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _db.Product.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Product>> GetPeopleAsync()
        {
            return await _db.Product.ToListAsync();
        }
    }
}
