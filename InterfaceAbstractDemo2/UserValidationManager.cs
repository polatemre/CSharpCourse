using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "EMRE" && gamer.LastName == "POLAT" && gamer.NationalityId == "12345678910" && gamer.BirthYear == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
