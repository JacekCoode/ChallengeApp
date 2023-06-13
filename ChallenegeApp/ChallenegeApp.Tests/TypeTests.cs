namespace ChallenegeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenVariableTypeStringAreEqual()
        {
            // arrange
            string employee1 = "Adam";
            string employee2 = "Adam";
            // assert
            Assert.AreEqual(employee1, employee2);
        }
        [Test]
        public void WhenVariableTypeIntAreEqual()
        {
            // arrange
            int employee1 = 2;
            int employee2 = 2;
            // assert
            Assert.AreEqual(employee1, employee2);
        }
        [Test]
        public void GetUserShouldRetrutDifferentObects()
        {
            // arrange
            var employee1 = GetUser("Adam", "Nowak", 34);
            var employee2 = GetUser("Adam", "Nowak", 34);
            // assert
            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]
        public void GetUserShouldRetrutValueInDifferenObject()
        {
            // arrange
            var employee1 = GetUser("Adam", "Nowak", 34);
            var employee2 = GetUser("Adam", "Nowak", 34);
            // act
            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        private Employee GetUser(string name, string lastName, int age)
        {
            return new Employee(name, lastName, age);
        }
    }
}
