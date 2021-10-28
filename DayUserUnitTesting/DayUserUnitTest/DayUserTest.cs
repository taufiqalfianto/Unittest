using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace DayUserUnitTest
{
    [TestFixture]
    public class DayUserTest
    {
        private Day day;
        private User user;
        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();

        }

        [Test]
        public void NameOfDayTest()
        {
            Assert.AreEqual("Rabu", day.NameOfDay(3));
        }
        [Test]
        public void IsValidUserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }
    }
}
