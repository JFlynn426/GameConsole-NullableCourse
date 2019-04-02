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

            int days = player.DaysSinceLastLogin ?? -1;

            /*int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;*/

            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
            Console.WriteLine($"{player.DaysSinceLastLogin} days since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);

            //}
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");

            //}
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
