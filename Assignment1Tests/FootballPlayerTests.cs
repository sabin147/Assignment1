using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer p1 = new FootballPlayer() { Id = 1, Name = "Sabin", Age = 21, ShirtNumber = 1 };
        [TestMethod()]
        public void ToStringTest()
        {
            string nam = p1.ToString();
            Assert.AreEqual("The player Sabin has id 1 is 21 years old and has shirtnumber 1", nam);
        }
        
        [TestMethod()]
        public void NameLessThan2CharacterTest()
        {
            
            FootballPlayer p2 = new FootballPlayer() { Id = 2, Name = "A", Age = 20, ShirtNumber = 2 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => p2.ValidateName());
        }
        [TestMethod()]
        public void NegativeAgeTest()
        {
            FootballPlayer p3 = new FootballPlayer() { Id = 3, Name = "Adeel", Age = 0, ShirtNumber = 3 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => p3.ValidateAge());
        }
        [TestMethod()]
        public void ShirtNumberLessThan0Test()

        {
            FootballPlayer p4 = new FootballPlayer() { Id = 4, Name = "Sabin", Age = 22, ShirtNumber = -1 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => p4.ValidateShirtNumber());
        }
        [TestMethod()]
        public void ShirtNumberGreaterThan99Test()
        {
            FootballPlayer p5 = new FootballPlayer() { Id = 5, Name = "Saugat", Age = 25, ShirtNumber = 100 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => p5.ValidateShirtNumber());
        }
    }
}