using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People { Name = "Mridul", Age = 23, Address = "kalidaha,feni,chittagong" };
            People people2 = new People { Name = "Bijoy", Age = 27, Address = "shitakunda,chittagong" };
            People people3 = new People { Name = "sakib", Age = 27, Address = "jossore,bangladesh" };

            Peoples peoples = new Peoples();
            peoples.AddPeople(people1);
            peoples.AddPeople(people2);
            peoples.AddPeople(people3);

            Console.WriteLine(peoples.TotalPeoplesCount());
            peoples["Mridul"].Address = "kalidaha,feni,chittagong,bangladesh." ;
            Console.WriteLine(peoples["Mridul"].Address);

        }
    }
}


