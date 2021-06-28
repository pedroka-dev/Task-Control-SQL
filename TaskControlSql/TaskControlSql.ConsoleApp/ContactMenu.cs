using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskControlSql.ConsoleApp.Control;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.ConsoleApp.View
{
    class ContactMenu : RegistrationMenu<Contact>
    {

        public ContactMenu(ContactController contactController, ConsoleColor fontColor)
        {
            this.mainController = contactController;
            MenuTypeTitle = "contact";
            this.fontColor = fontColor;
        }

        public override void RegisterElement()
        {
            DisplayerHeader("REGISTER CONTACT");

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

            Contact contact;
            try
            {
                contact = new Contact(0, name, email, phoneNumber, businessCompany, companyPosition);
            }
            catch (Exception e)
            {
                DisplayErrorText("Error: " + e.Message);
                return;
            }
            string response = mainController.CreateEntity(contact);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Register Operation Sucessful.");
                Console.ReadLine();
                return;
            }
        }

        public override void ModifyElement()
        {
            VisualizeAllElements();
            DisplayerHeader("MODIFY CONTACT");

            Console.WriteLine(" - Enter id of the friend to Modify.");
            string idTxt = Console.ReadLine();

            if (!int.TryParse(idTxt, out int id))
            {
                DisplayErrorText("Attribute id must a valid integer.");
                return;
            }
            if (!mainController.ExistEntity(id))
            {
                DisplayErrorText("Entity id does not exist.");
                return;
            }

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

            Contact contact;
            try
            {
                contact = new Contact(id, name, email, phoneNumber, businessCompany, companyPosition);
            }
            catch (Exception e)
            {
                DisplayErrorText("Error: " + e.Message);
                return;
            }

            string response = mainController.UpdateEntity(contact);

            if (response != "OP_SUCCESS")
                DisplayErrorText(response);
            else
            {
                DisplaySuccessText("Modify Operation Sucessful");
                Console.ReadLine();
                return;
            }
        }
        
        protected override List<Contact> OrderList(List<Contact> EntityList)
        {
            return EntityList.OrderBy(x => x.CompanyPosition).ToList();
        }
    }
}
