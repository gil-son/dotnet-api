using System;
using Gil.ApiDotNet7.Domain.Validations;
namespace Gil.ApiDotNet7.Domain.Entities
{
    public sealed class Product
    {
        
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get;  set; }
        
        public Product(string name, string codErp, decimal price)
        {
            Validation(name, codErp, price);
        }

        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationException.When(id <= 0, "The id is required!");
            Id = id;
            Validation(name, codErp, price);
        }

        private void Validation(string name, string codErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "The name can't be null!");
            DomainValidationException.When(string.IsNullOrEmpty(codErp), "The codErp can't be null!");
            DomainValidationException.When(price <= 0, "The price is required!");

            Name = name;
            CodErp = codErp;
            Price = price;
        }

    }
}