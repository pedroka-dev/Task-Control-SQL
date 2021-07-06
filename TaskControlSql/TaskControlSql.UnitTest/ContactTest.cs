using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void Should_InstantiateContact_Correctly()
        {
            Contact contact;
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            contact = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);

            contact.Id.Should().Be(correctId);
            contact.Name.Should().Be(correctName);
            contact.Email.Should().Be(correctEmail);
            contact.PhoneNumber.Should().Be(correctPhoneNumber);
            contact.BusinessCompany.Should().Be(correctBusinessCompany);
            contact.CompanyPosition.Should().Be(correctCompanyPosition);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowArgumentException_IdIsNegativeNumber()
        {
            Contact contact;
            int wrongtId = -1;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            contact = new Contact(wrongtId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowArgumentNullException_EmailNullOrEmpty()
        {
            Contact contact;
            int correctId = 0;
            string correctName = "José";
            string wrongEmail = "";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            contact = new Contact(correctId, correctName, wrongEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowArgumentNullException_PhoneNumberNullOrEmpty()
        {
            Contact contact;
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string wrongPhoneNumber = "";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            contact = new Contact(correctId, correctName, correctEmail, wrongPhoneNumber, correctBusinessCompany, correctCompanyPosition);
        }
    }
}
