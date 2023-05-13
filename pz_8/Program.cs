using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
    {
        IContact person = ContactFactory.CreateContact("person");
        person.Name = "Сергей Соболев";
        person.Phone = "+79228982893";
        person.Email = "sergey12@gmail.com";
        person.Address = "ул. Гагарина д. 8";
        ((Person)person).Birthday = "05.03.2003";
        person.Display();
    }
    }
}

