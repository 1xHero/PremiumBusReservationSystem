using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PremiumBusReservationSystem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumBusReservationSystemTests1
{
    [TestClass]
    public class MyTicket
    {
        [TestMethod]
        public void CheckUserTicket()
        {
            // arrange
            List<string> expected = new List<string>();
          
           // expected.Add("admin2");
            expected.Add("test");

            var f = new Form7();
            //Act
            
            
            
            // Assert
            
                
                for(int i = 0; i < expected.Count; i++) 
            {

            Assert.IsTrue(f.IsUeserHaveTicket(expected[i]));
            }
            
        }
    }
}
