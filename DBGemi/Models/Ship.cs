using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGemi.Models
{
   public class Ship
    {
        [Key]
        public int ShipID { get; set; }
        public string ShipName { get; set; }
        public string Country { get; set; }
        public string ContactInfo { get; set; }
        public string Tel { get; set; }
    }
}

