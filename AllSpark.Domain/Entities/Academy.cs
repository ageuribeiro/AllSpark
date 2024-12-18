using AllSpark.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSpark.Domain.Entities
{
    public sealed class Academy
    {
        public int Id { get; private set; }
        public string ? Name { get; private set; }
        public string ? Address { get; private set; }
        public string ? City { get; private set; }
        public string ? Region { get; private set; }
        public string ? PostalCode { get; private set; }
        public string ? Country { get; private set; }

        public Academy(string name, string address, string city, string region, string postalCode, string country)
        {
            ValidateDomain(name, address, city, region, postalCode, country);
            Name = name;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }

        public Academy(int id, string name, string address, string city, string region, string postalCode, string country)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateDomain(name, address, city, region, postalCode, country);

            Id = id;
            
        }
        public ICollection<User> ? Users { get; set; }

        public ICollection<Rule> ? Rules { get; set; }

        private void ValidateDomain(string name, string address, string city, string region, string postalCode, string country)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                "Invalid name. Name is required.");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters.");

            DomainExceptionValidation.When(address.Length < 10,
                "Invalid address. too short, minimum 10 characters.");
            Name = name;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;


        }
    }
}
