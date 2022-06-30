namespace UserRegistration_Day19
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();


            Console.Write("Enter the First name: ");
            string Firstname = Console.ReadLine();
            userRegistration.validatefirstname(Firstname);


            Console.WriteLine("Enter the Last name:");
            string Lastname = Console.ReadLine();
            userRegistration.validateLastName(Lastname);

            Console.WriteLine("Enter the Email address");
            string Email = Console.ReadLine();
            userRegistration.validateEmail(Email);








        }
        
    }
}
