using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;
using System;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            // Act
            string result = currentActor.GetOccupation();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            // Arrange
            var currentActor = new Actor("Clearly Actor");
            var expected = "Clearly Actor";
            // Act
            string result = currentActor.ActorName;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActor()
        {
            // Arrange
            string details = "Booking can change if actor " +
                "is causing problems.";
            var currentActor = new Actor("John Malkov");
            var expected = "Actor John Malkov is booked. " + details;
            // Act
            string result = currentActor.BookActor();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFormattingOnSetterForBookActor()
        {
            // Arrange
            string details = "Booking can change if actor " +
                "is causing problems.";
            var currentActor = new Actor("John Malkov   ");
            var expected = "Actor John Malkov is booked. " + details;
            // Act
            string result = currentActor.BookActor();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            // Arrange
            string details = "Booking can change if actor " +
                "is causing problems.";
            var currentActor = new Actor("Maria Lisponova");
            var expected = "Actor Maria Lisponova is booked on " + DateTime.Now.ToString() + "." + details;
            // Act
            string result = currentActor.BookActor(DateTime.Now.ToString());
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            // Arrange
            var currentActor = new Actor { ActorName = "Kio Nim", ActorAge = 12 };
            var expected = 12;
            // Act
            int result = currentActor.ActorAge;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            // Arrange
            var currentActor = new Actor { ActorName = "Kio Nim II", ActorDescription = "Best guy"};
            var expected = "Best guy";
            // Act
            string result = currentActor.ActorDescription;
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
