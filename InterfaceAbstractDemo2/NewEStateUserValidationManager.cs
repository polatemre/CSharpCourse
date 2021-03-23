using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
