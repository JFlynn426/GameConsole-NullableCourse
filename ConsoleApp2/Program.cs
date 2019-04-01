using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Sarah";
     
            PlayerDisplayer.Write(player);
        }
    }
}
