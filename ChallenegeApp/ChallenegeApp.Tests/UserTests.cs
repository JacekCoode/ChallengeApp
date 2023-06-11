namespace ChallenegeApp.Tests
{
    public class Tests
    {
     



        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam" , "Nowak" , 33);
            employee.AddScore(15);
            employee.AddScore(-6);
            employee.AddScore(-4);
            // act
            var result = employee.Result;

            // assert
           Assert.AreEqual(5, result);

        }
    }
}