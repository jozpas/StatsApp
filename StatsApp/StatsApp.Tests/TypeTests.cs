

namespace StatsApp.Tests
{

    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            var employee = GetEmployee("Jan");
            var employee2 = GetEmployee("Jan");

            Assert.AreEqual(employee.Name, employee2.Name);


            //int number = 1;
            //int number2 = 2;

            // Assert.AreEqual(employee, employee2);

        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }


        [Test]
        public void TEST2()
        {

            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);

        }
    }
}
