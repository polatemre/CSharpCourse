using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2
{
    class GamerManager : IGamerService
    {
        // Eğer bir sınıfın içerisinde başka bir sınıfı kullanacaksak onu newlemeyiz constructor olarak veririz.
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt eklendi: " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt eklenemedi: " + gamer.FirstName);
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi: " + gamer.FirstName);
        }
    }
}
