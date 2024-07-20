using System.Reflection;
using ReflectionStructure.Models;

namespace ReflectionStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reflection(typeof(Account));
            Reflection(typeof(Product));
            Reflection(typeof(Object));
        }

        static void Reflection(Type type)
        {

            Console.WriteLine($"=========================== Details of type: {type.Name} ===========================");
            Console.WriteLine($"Number of Methods: {type.GetMethods().Length}");
            Console.WriteLine($"Number of Constructors: {type.GetConstructors().Length}");
            Console.WriteLine($"Number of Properties: {type.GetProperties().Length}");
        }
    }
}
