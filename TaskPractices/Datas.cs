using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPractices.Models;

namespace TaskPractices
{
    static class Datas
    {
        public static List<string> Countries()
        {
            List<string> countries = new() { "Azerbaycan", "Turkiye","Almaniya" };
            return countries;
        }

        public static List<Person> People()
        {
            List<Person> people = new List<Person>();
            Person person1 = new()
            {
                Id = 1,
                FullName = "Fidan Bashirova",
                Email = "fidan@gmail.com",
                BirthDate = new DateTime(2001, 06, 08)
            };

            Person person2 = new()
            {
                Id = 2,
                FullName = "Kubra Memmedova",
                Email = "kubra@gmail.com",
                BirthDate = new DateTime(1998, 07, 15)
            };
            Person person3 = new()
            {
                Id = 3,
                FullName = "Surac Ismayilov",
                Email = "surac@gmail.com",
                BirthDate = new DateTime(1999, 11, 08)
            };

            Person person4 = new()
            {
                Id = 4,
                FullName = "Ismayil Afendizade",
                Email = "ismayil@gmail.com",
                BirthDate = new DateTime(1994, 07, 03)
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);


            return people;
        }
    }
}
