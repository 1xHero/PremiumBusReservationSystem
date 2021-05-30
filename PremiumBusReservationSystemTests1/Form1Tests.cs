using Microsoft.VisualStudio.TestTools.UnitTesting;
using PremiumBusReservationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumBusReservationSystem.Tests
{
    [TestClass()]
    public class LoginForm
    {
        [TestMethod()]
        public void IsAdmin()
        {
            // arrange
            string username = "admin";
            var f = new Form1();
            //Act
            
            var resault = f.IsAdmin(username);
            // Assert
            Assert.IsTrue(resault);
        }
    }
}