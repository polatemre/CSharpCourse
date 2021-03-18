using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity // Bunun gibi varlık, somut sınıflar eğer inherit veya implement almıyorsa
                                    // ileride nesnellik zaafiyeti yaşamamak için bir implement atarız.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

    }
}
