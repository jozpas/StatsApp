
using System.Xml.Linq;

namespace StatsApp
{
    public class Person
    {
        public static string Company = "HAP";

        public Person(string name, string lastname, int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
        }

        public Person(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
    }
}
