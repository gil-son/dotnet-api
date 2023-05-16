using System;
using Gil.ApiDotNet7.Domain.Validations;
namespace Gil.ApiDotNet7.Domain.Entities
{
    public sealed class Purchase
    {

        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }
         
        public Purchase(int productId, int personId, DateTime? date)
        {
            Validation(productId, personId, date);
        }

        public Purchase(int id, int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(id <= 0, "The Id is required!");
            Id = Id;
            Validation(productId, personId, date);
        }
      
        private void Validation(int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(productId <= 0, "The product Id is required!");
            DomainValidationException.When(personId <= 0, "The person Id is required!");
            DomainValidationException.When(!date.HasValue, "The data from purchase is required!");

            PersonId = personId;
            ProductId = productId;
            Date = date.Value;
        }
    }
}