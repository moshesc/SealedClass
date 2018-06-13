using System;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the object of seald class
            CustomerDetails obj = new CustomerDetails();
            string Name = obj.AccountInfo();

            //Writing output to console
            Console.WriteLine(Name);
            Console.ReadLine();
        }
    }

    public sealed class CustomerDetails //Sealed Class
    {
        public string AccountInfo()
        {
            return "John Choan";
        }
    }
}
