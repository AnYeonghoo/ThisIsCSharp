using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter16
{
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = "";
            phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name} , {phone}");
        }

        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }

    }
    internal class DynamicInstance
    {
        static void MainDynamicInstance()
        {
            Type type = Type.GetType("DynamicInstance.Profile");
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("phone");
            object profile = Activator.CreateInstance(type, "박상현", "512-1234");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "박찬호", null);
            phoneProperty.SetValue(profile, "997-5511", null);
            Console.WriteLine($"{nameProperty.GetValue(profile, null)}, : {phoneProperty.GetValue(profile, null)}");
        }
    }
}
