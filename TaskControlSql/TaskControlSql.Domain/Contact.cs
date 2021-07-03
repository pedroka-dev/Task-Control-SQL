using System;
using System.Collections.Generic;

namespace TaskControlSql.Domain
{
    public class Contact : Entity
    {
        private string name;
        private string email;
        private string phoneNumber;
        private string businessCompany;
        private string companyPosition;

        public Contact(int id, string name, string email, string phoneNumber, string businessCompany, string companyPosition)
        {
            if (id < 0)
                throw new ArgumentException("Attribute 'id' cannot be a number smaller than 0.");
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("Attribute 'email'  must be a valid email not be null or empty.");
            if (string.IsNullOrEmpty(phoneNumber))
                throw new ArgumentNullException("Attribute 'phoneNumber'and cannot be null or empty.");

            this.id = id;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.businessCompany = businessCompany;
            this.companyPosition = companyPosition;
        }

        public string Name { get => name; }
        public string Email { get => email; }
        public string PhoneNumber { get => phoneNumber; }
        public string BusinessCompany { get => businessCompany; }
        public string CompanyPosition { get => companyPosition; }

        public override bool Equals(object obj)
        {
            return obj is Contact contact &&
                   id == contact.id &&
                   name == contact.name &&
                   email == contact.email &&
                   phoneNumber == contact.phoneNumber &&
                   businessCompany == contact.businessCompany &&
                   companyPosition == contact.companyPosition;
        }

        public override int GetHashCode()
        {
            int hashCode = 98067652;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(businessCompany);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(companyPosition);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Contact [ id='{id}', name='{name}', email='{email}', phoneNumber='{phoneNumber}', businessCompany='{businessCompany}', positionCompany='{companyPosition}' ]";
        }
    }
}
