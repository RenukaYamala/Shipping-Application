using System;
using System.ComponentModel;
using ShipmentApplication.Users;
using ShipmentApplication.Payments;
using ShipmentApplication.Shipments;
namespace ShipmentApplication
{
    public class ShipmentApplication
    {
        
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            User user = new User();
            Driver driver = new Driver();
            Console.WriteLine("Hello !!!");
            Console.WriteLine("Enter the type of user:");
            Console.WriteLine("1.Shipper or 2.Driver");
            int TypeOfUser = Convert.ToInt32(Console.ReadLine());
            if (TypeOfUser != 1 && TypeOfUser != 2)
            {
                Console.WriteLine("You Have Entered Wrong Option! Please choose 1 or 2");
                Console.ReadKey();
            }
            else
            {
                if (TypeOfUser == 1)
                {
                    Console.WriteLine("Enter Details of User::");
                    Console.WriteLine("Enter First Name:");
                    shipper.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name:");
                    shipper.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    shipper.Address = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    shipper.Password = Console.ReadLine();
                    Console.WriteLine("Enter Contactnumber:");
                    shipper.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter EmailId:");
                    shipper.Email = Console.ReadLine();
                    //Random random = new Random();
                    shipper.SetUser(shipper);
                    var details = shipper.GetUser();
                    Console.WriteLine("The registered User Details are\n");
                    //Too avoid righting The following lines of code use inbuilt properties
                    //Console.WriteLine(details.FirstName);
                    //Console.WriteLine(details.LastName);
                    DisplayDetails(details);
                    user.Login(details.FirstName,details.Password,details);
                    
                    

                    Console.ReadKey();
                }
                if (TypeOfUser == 2)
                {
                    Console.WriteLine("Enter first name of Driver");
                    driver.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Lastn name of Driver");
                    driver.LastName = Console.ReadLine();
                    Console.WriteLine("Enter address of Driver");
                    driver.Address = Console.ReadLine();
                    Console.WriteLine("Enter Password of Driver");
                    driver.Password = Console.ReadLine();
                    Console.WriteLine("Enter Contactnumber of Driver");
                    driver.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter EmailId:");
                    driver.Email = Console.ReadLine();
                    Console.WriteLine("Enter Licence Number:");
                    driver.LicenceNumber = Console.ReadLine();
                    Console.WriteLine("Enter Vehicle Number:");
                    driver.VehicleNumber = Console.ReadLine();
                    Console.WriteLine("Enter TypeOf Vehicle Number:");
                    driver.TypeOfVehicle = Console.ReadLine();
                    Console.WriteLine("Enter Wight it can hold:");
                    driver.WeightHold = Console.Read();
                    driver.SetUser(driver);
                    var details = driver.GetUser();
                    Console.WriteLine("The registered Driver Details are\n");
                    DisplayDetails(details);
                    user.Login(details.FirstName, details.Password,details);
                    Console.ReadKey();
                }
            }
            //Too display details of any object
            void DisplayDetails(Object details)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(details))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(details);
                    Console.WriteLine("{0}:{1}", name, value);
                }
            }


        }
    }
}
