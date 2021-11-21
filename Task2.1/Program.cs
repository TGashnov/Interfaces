using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изначальный список:");
            Console.WriteLine(string.Join("\n", persons));
            Console.WriteLine();
            Console.WriteLine(new string('*', Console.WindowWidth));
            Console.WriteLine();
            var sortedPersons = persons.OrderBy(pers => pers).ToList();
            Console.WriteLine("Сортированный по возрастанию список:");
            Console.WriteLine(string.Join("\n", sortedPersons));
            Console.WriteLine();
            Console.WriteLine(new string('*', Console.WindowWidth));
            Console.WriteLine();
            var reverseSortedPersons = persons.OrderByDescending(pers => pers).ToList();
            Console.WriteLine("Сортированный по убыванию список:");
            Console.WriteLine(string.Join("\n", reverseSortedPersons));
        }

        static List<Person> persons = new List<Person>()
        {
            new Person("Виктор", "Викторов", DateTime.Parse("21 января 2001")),
            new Person("Андрей", "Викторов", DateTime.Parse("26 января 2003")),
            new Person("Андрей", "Викторов", DateTime.Parse("21 января 2009")),
            new Person("Павел", "Копчиков", DateTime.Parse("23 февраля 2020")),
            new Person("Руслан", "Нургалиев", DateTime.Parse("11 ноября 2020")),
            new Person("Снежана", "Пулькина", DateTime.Parse("17 июня 2000")),
            new Person("Андрей", "Баков", DateTime.Parse("09 мая 2002")),
            new Person("Лариса", "Пикова", DateTime.Parse("02 октября 2009")),
            new Person("Виктор", "Викторов", DateTime.Parse("21 января 2001 00:00:01")),
        };
    }

    class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;
            if (Surname.CompareTo(person.Surname) == 1)
                return 1;
            else if (Surname.CompareTo(person.Surname) == -1)
                return -1;
            else
            {
                if (Name.CompareTo(person.Name) == 1)
                    return 1;
                else if (Name.CompareTo(person.Name) == -1)
                    return -1;
                else
                {
                    if (BirthDate.CompareTo(person.BirthDate) == -1)
                        return -1;
                    else return 1;
                }
            }
        }

        public override string ToString()
        {
            return Surname + " " + Name + " " + BirthDate;
        }
    }
}
