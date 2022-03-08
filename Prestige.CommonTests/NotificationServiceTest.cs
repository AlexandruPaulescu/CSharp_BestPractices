using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Common;
using System;

namespace Prestige.CommonTests
{
    [TestClass]
    public class NotificationServiceTest
    {
        [TestMethod]
        public void TestNotifyTalent()
        {
            // Arrange
            var notificationService = new NotificationService();
            var expect = "talent : john";
            // Act
            var actual = notificationService.NotifyTalent("john");
            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
