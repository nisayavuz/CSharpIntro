using System.Globalization;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor, classı ilk kez yapılandırdığımızda çalışacak olan bloktur.
            Customer customer3 = new Customer { City = "Ankara" , Id = 1, FirstName ="Nisa", LastName = "Yavuz"};
            Customer customer4 = new Customer( 1, "Nisa" , "Yavuz" , "Ankara");
            Console.WriteLine(customer4.FirstName);
        }

    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }

        public Customer( int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;    
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}