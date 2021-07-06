using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class ContactControllerTest
    {
        ContactController contactController;
        public ContactControllerTest()
        {
            contactController = new ContactController();
            contactController.DeleteAllEntities();
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertNewContact()
        {
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            Contact contact = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            string response = contactController.CreateEntity(contact);

            response.Should().Be("OP_SUCCESS");
            contactController.ReceiveEntity(contact.Id).Should().Be(contact);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertMultipleContacts()
        {
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            Contact contact1 = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            Contact contact2 = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            Contact contact3 = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            string response1 = contactController.CreateEntity(contact1);
            string response2 = contactController.CreateEntity(contact2);
            string response3 = contactController.CreateEntity(contact3);

            response1.Should().Be("OP_SUCCESS");
            contactController.ReceiveEntity(contact1.Id).Should().Be(contact1);
            response2.Should().Be("OP_SUCCESS");
            contactController.ReceiveEntity(contact2.Id).Should().Be(contact2);
            response3.Should().Be("OP_SUCCESS");
            contactController.ReceiveEntity(contact3.Id).Should().Be(contact3);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnUpdateContact()
        {
            int correctId = 0;
            string newName = "Ednaldo Pereira";
            string newEmail = "ednaldopereira.chance@yahoo.com.br";
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            Contact contact = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            Contact updatedcontact = new Contact(correctId, newName, newEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            contactController.CreateEntity(contact);
            updatedcontact.Id = contact.Id;
            string response = contactController.UpdateEntity(updatedcontact);

            response.Should().Be("OP_SUCCESS");
            contactController.ReceiveEntity(updatedcontact.Id).Should().Be(updatedcontact);
        }

        [TestMethod]
        public void Should_ReturnFalse_OnExistEntityWithoutContact()
        {
            Contact contact;
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            contact = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            bool response = contactController.ExistEntity(contact.Id);

            response.Should().BeFalse();
        }


        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithOneContact()
        {
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            Contact contact = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            contactController.CreateEntity(contact);
            bool response = contactController.ExistEntity(contact.Id);

            response.Should().BeTrue();
        }

        [TestMethod]
        public void Should_ReturnTrue_OnExistEntityWithMultipleContacts()
        {
  
            int correctId = 0;
            string correctName = "José";
            string correctEmail = "jose@jose.com.jose";
            string correctPhoneNumber = "495959195295";
            string correctBusinessCompany = "josé e co. ltda.";
            string correctCompanyPosition = "josé senior";

            Contact contact1 = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            Contact contact2 = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            Contact contact3 = new Contact(correctId, correctName, correctEmail, correctPhoneNumber, correctBusinessCompany, correctCompanyPosition);
            contactController.CreateEntity(contact1);
            contactController.CreateEntity(contact2);
            contactController.CreateEntity(contact3);
            bool response1 = contactController.ExistEntity(contact1.Id);
            bool response2 = contactController.ExistEntity(contact2.Id);
            bool response3 = contactController.ExistEntity(contact3.Id);

            response1.Should().BeTrue();
            response2.Should().BeTrue();
            response3.Should().BeTrue();
        }
    }
}
