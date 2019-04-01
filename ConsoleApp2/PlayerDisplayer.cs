using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }
            if (player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");

            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            if (player.DateofBirth == null)
            {
                Console.WriteLine("No date of birth has been specified");
            }
            else
            {
                Console.WriteLine(player.DateofBirth);
            }
            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("player is newbie");
            }
            else
            {
                Console.WriteLine("player is experienced");
            }
        }


    }
}
