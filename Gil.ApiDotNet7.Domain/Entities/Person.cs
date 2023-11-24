using System;
using Gil.ApiDotNet7.Domain.Validations;
namespace Gil.ApiDotNet7.Domain.Entities
{
    public sealed class Person
    {
        public int? Id { get; private set; }
        public string? Name { get; private set; }
        public string? Document { get; private set; }
        public string? Phone { get; private set; }
        public ICollection<Purchase> Purchases { get;  set; }

        public Person(string document, string name, string phone)
        {
            Validation(document, name, phone);
        }

        public Person(int id, string document, string name, string phone)
        {
            
            DomainValidationException.When(id < 0, "Id must be more than zero");
            Id = id;
            Validation(document, name, phone);

        }

        private void Validation(string document, string name, string phone)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "The name can't be null!");
            DomainValidationException.When(string.IsNullOrEmpty(document), "The document can't be null!");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "The phone can't be null!");

            Name = name;
            Document = document;
            Phone = phone;

        }

    }
}