using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPractices.Exceptions;
using TaskPractices.Models;
using TaskPractices.Services;
using TaskPractices.Services.Interfaces;

namespace TaskPractices.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }


        public void GetAll()
        {
            List<Person> people = _personService.GetPeople();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id} - {person.FullName} - {person.Email} - {person.BirthDate.ToString("dd MMMM yyyy")}");
            }
        }
        public void GetById()
        {
            Person person = _personService.GetById(2);
            Console.WriteLine($"{person.Id} - {person.FullName} - {person.Email} - {person.BirthDate.ToString("dd MMMM yyyy")}");
        }

        public void Sorting()
        {
            try
            {
                string orderType = Console.ReadLine();
                List<Person> people = _personService.Sorting(orderType);
                if (people is null)
                    throw new NotFoundExceptions();

                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Id} - {person.FullName} - {person.Email} - {person.BirthDate.ToString("dd MMMM yyyy")}");
                }
            }
            catch (NotFoundExceptions ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
