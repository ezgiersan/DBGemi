using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestDBGemi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInsertGemi()
        {
            DBGemi.Models.Ek newShip = new DBGemi.Models.Ek();
            DBGemi.Models.DBGemiContext c = new DBGemi.Models.DBGemiContext();
            
            int newId=newShip.InsertGemi("poyraz", "Türkiye", "poyraz@gmail.com", "+0905339995566");
            
            var nShip = c.Ships.FirstOrDefault(x => x.ShipID == newId);
            Assert.AreEqual(nShip.ShipID, newId);

        } 

        [TestMethod]
        public void TestDeleteGemi()
        {
            DBGemi.Models.Ek newShip = new DBGemi.Models.Ek();
            DBGemi.Models.DBGemiContext c = new DBGemi.Models.DBGemiContext();

            int newId = newShip.InsertGemi("poyraz", "Türkiye", "poyraz@gmail.com", "+0905339995566");
            newShip.DeleteGemi(newId);
            var nShip = c.Ships.FirstOrDefault(x => x.ShipID == newId);
            Assert.IsNull(nShip);
            

        }
       
        [TestMethod]
        public void TestUpdateGemi()
        {
            DBGemi.Models.Ek newShip = new DBGemi.Models.Ek();            
            DBGemi.Models.DBGemiContext c = new DBGemi.Models.DBGemiContext();

            int newId = newShip.InsertGemi("poyraz", "Türkiye", "poyraz@gmail.com", "+0905339995566");
            newShip.UpdateGemi(newId,"poyraz", "Türkiye", "poyraz@gmail.com", "+0905339995566");
            var nShip = c.Ships.FirstOrDefault(x => x.ShipID == newId);
            Assert.AreEqual(nShip.ShipName, "poyraz");
            Assert.AreEqual(nShip.Country, "Türkiye");
            Assert.AreEqual(nShip.ContactInfo, "poyraz@gmail.com");
            Assert.AreEqual(nShip.Tel, "+0905339995566");
        }

    }
}
