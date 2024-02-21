using src.Employee;

namespace EmployeeTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestEmployeeConstructorFull()
        {
            Employee employee = new Employee("Chris Allers", 47899, "Accounting", "Vice President");
            Assert.AreEqual("Chris Allers", employee.Name);
            Assert.AreEqual(47899, employee.IDNumber);
            Assert.AreEqual("Accounting", employee.Department);
            Assert.AreEqual("Vice President", employee.Position);
        }

        [TestMethod]
        public void TestEmployeeConstructorHalf()
        {
            Employee employee = new Employee("Chris Allers", 47899);
            Assert.AreEqual("Chris Allers", employee.Name);
            Assert.AreEqual(47899, employee.IDNumber);
            Assert.AreEqual(String.Empty, employee.Department);
            Assert.AreEqual(String.Empty, employee.Position);
        }

        [TestMethod]
        public void TestEmployeeConstructorSmall()
        {
            Employee employee = new Employee();
            Assert.AreEqual(String.Empty, employee.Name);
            Assert.AreEqual(0, employee.IDNumber);
            Assert.AreEqual(String.Empty, employee.Department);
            Assert.AreEqual(String.Empty, employee.Position);
        }
    }   
}