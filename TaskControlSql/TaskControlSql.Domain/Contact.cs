using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.Domain
{
    class Contact : Entity
    {
        private string name;
        private string email;
        private string phoneNumber;
        private string businessCompany;
        private string companyPosition;

        public Contact(int id, string name, string email, string phoneNumber, string businessCompany, string positionCompany)
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
            this.companyPosition = positionCompany;
        }

        public string Name { get => name;}
        public string Email { get => email;}
        public string PhoneNumber { get => phoneNumber;}
        public string BusinessCompany { get => businessCompany;}
        public string CompanyPosition { get => companyPosition; }

        public override string ToString()
        {
            return $"TodoTask [ id='{id}, name='{name}', email='{email}', phoneNumber='{phoneNumber}', businessCompany='{businessCompany}', positionCompany='{companyPosition}' ]";
        }
    }
}
