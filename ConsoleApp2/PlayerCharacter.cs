using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateofBirth { get; set; }
        public bool? IsNoob { get; set; }
        public PlayerCharacter()
        {
            DateofBirth = null;
            DaysSinceLastLogin = null;
        }
    }
   
 
}
