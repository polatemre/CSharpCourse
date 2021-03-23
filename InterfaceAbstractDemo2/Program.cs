using System;

namespace InterfaceAbstractDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            IUserValidationService userValidationManager = new UserValidationManager();
            userValidationManager.Validate(new Gamer() { FirstName = "EMRE", LastName = "POLAT", NationalityId = "12345678910", BirthYear = 1997 });
            IGamerService gamerManager = new GamerManager(userValidationManager);
            */

            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer()
            {
                FirstName = "EMRE",
                LastName = "POLAT",
                NationalityId = "12345678910",
                BirthYear = 1997
            });

        }
    }
}
