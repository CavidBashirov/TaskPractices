using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPractices.Models;

namespace TaskPractices.Services.Interfaces
{
    interface IPersonService
    {
        List<Person> GetPeople();

        Person GetById(int id);
        List<Person> Sorting(string orderType);
    }
}
