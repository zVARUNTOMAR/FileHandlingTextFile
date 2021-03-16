using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileHandlingDemo
{
    internal class Tutorial
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"D:\Games\Customers.txt", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();

            Customer NewCustomer = new Customer("varun",23,"delhi");

            formatter.Serialize(stream, NewCustomer);
            //end

            //deseralization start
            stream.Position = 0;

            Customer AgainNewCustomer = (Customer)formatter.Deserialize(stream);

            Console.WriteLine("Name : {0}",AgainNewCustomer.name);
            Console.WriteLine("Age : {0}", AgainNewCustomer.age);
            Console.WriteLine("City : {0}", AgainNewCustomer.city);

            stream.Close();
        }
    }
}