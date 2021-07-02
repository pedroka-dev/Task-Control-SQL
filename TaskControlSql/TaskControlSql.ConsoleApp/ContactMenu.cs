using System;
using System.Collections.Generic;
using System.Linq;
using TaskControlSql.Control;
using TaskControlSql.Domain;

namespace TaskControlSql.ConsoleApp
{
    class ContactMenu : RegistrationMenu<Contact>
    {

        public ContactMenu(ContactController contactController, ConsoleColor fontColor)
        {
            this.mainController = contactController;
            MenuTypeTitle = "contact";
            this.fontColor = fontColor;
        }



        protected override List<Contact> OrderList(List<Contact> EntityList)
        {
            return EntityList.OrderBy(x => x.CompanyPosition).ToList();
        }

        protected override Contact UserInputToEntity(int id)
        {
            Console.WriteLine(" - Enter name of the contact:");
            string name = Console.ReadLine();

            Console.WriteLine(" - Enter email of the contact:");
            string email = Console.ReadLine();

            Console.WriteLine(" - Enter phone number of the contact:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine(" - Enter name of the business company of the contact:");
            string businessCompany = Console.ReadLine();

            Console.WriteLine(" - Enter working position of the contact on the company:");
            string companyPosition = Console.ReadLine();

            Contact contact = new Contact(id, name, email, phoneNumber, businessCompany, companyPosition);
            return contact;
        }
    }
}
