using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Adress : ValueObject
    {
        public Adress(string street, string number, string neightborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neightborhood = neightborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Address.Street", "Nome deve conter pelo menos 3 caracteres")

);
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neightborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}