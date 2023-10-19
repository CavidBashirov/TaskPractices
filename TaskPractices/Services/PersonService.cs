using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPractices.Enums;
using TaskPractices.Models;
using TaskPractices.Services.Interfaces;

namespace TaskPractices.Services
{
    class PersonService : IPersonService
    {
        public List<Person> GetPeople()
        {
            return Datas.People();
        }

        public Person GetById(int id)
        {
            var people = Datas.People();
            var person = people.FirstOrDefault(m => m.Id == id);
            return person;
        }

        public List<Person> Sorting(string orderType)
        {
            List<Person> people=null;
            if (orderType == OrderBy.Asc.ToString())
            {
                people = Datas.People().OrderBy(m => m.Id).ToList();
            }
            else if(orderType == OrderBy.Desc.ToString())
            {
                people=Datas.People().OrderByDescending(m=> m.Id).ToList();
            }

            return people;
        }
    }
}
