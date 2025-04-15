using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter16
{
    internal class GetType
    {
        static void PrintInterfaces(Type type)
        {
            Type[] interfaces = type.GetInterfaces();
            foreach (Type t in interfaces)
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";
                Console.WriteLine($"Access: {accessLevel} , Type: {field.FieldType.Name}, Name : {field.Name}");
               
            }
            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write($"Type: {method.ReturnType.Name}, Name: {method.Name}, Parameter: ");
                ParameterInfo[] arg = method.GetParameters();
                for (int i = 0; i < arg.Length; i++)
                {
                    Console.Write($"{arg[i].ParameterType.Name}");
                    if (i < arg.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
        }

        static void PrintProperties(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine($"Type: {property.PropertyType.Name}, Name: {property.Name}");
            }
            Console.WriteLine();
        }
    }
}
