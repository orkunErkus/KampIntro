using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1990 && gamer.FirsthName == "orkun" && gamer.LastName =="erkuş" && gamer.IdentitiyNumber == 11111664994)
            {
                return true;
            }
            else {
                return false;
                   }
        }
    }
}
