using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1990, FirsthName = "orkun", LastName = "erkuş", IdentitiyNumber = 187962142 });
        }
    }
}
