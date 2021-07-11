using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGemi.Models
{
    public class Ek
    {
        

        public int InsertGemi(string name, string country, string contact, string tel)
        {
            Ship s = new Ship();
            DBGemiContext c = new DBGemiContext();
            
            s.ShipName = name;
            s.Country = country;
            s.ContactInfo = contact;
            s.Tel = tel;
            c.Ships.Add(s);
            c.SaveChanges();
            var newId = s.ShipID; 
            return newId;
        }
         public void DeleteGemi(int GemiId)
        {
            Ship s = new Ship();
            DBGemiContext c = new DBGemiContext();
            int del = GemiId;
            var DelGemiId = c.Ships.FirstOrDefault(x => x.ShipID == del);
            c.Ships.Remove(DelGemiId);
            c.SaveChanges();
            return;
        }
          public void UpdateGemi(int GemiId, string name, string country, string contact, string tel)
        {
            Ship s = new Ship();
            DBGemiContext c = new DBGemiContext();
            int del = GemiId; 
            var DelGemiId = c.Ships.FirstOrDefault(x => x.ShipID == del);            
            DelGemiId.ShipName = name;
            DelGemiId.Country = country;
            DelGemiId.ContactInfo = contact;
            DelGemiId.Tel = tel;
            c.SaveChanges();
            return;

        }

    }

}

