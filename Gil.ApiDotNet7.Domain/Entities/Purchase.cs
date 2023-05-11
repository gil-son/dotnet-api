using System;
namespace Gil.ApiDotNet7.Domain.Entities
{
    public class Purchase(int productId, int personId, DateTime? date)
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }
      
      
    Purchase(int productId, int personId, DateTime? date)
    {
        Validation(productId, personId, date);
    }

    Purchase(int id, int productId, int personId, DateTime? date)
    {
        DomainValidationException.When(productId <= 0, "The product Id is required!");
        Id = Id;
        Validation(id, productId, personId, date);
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