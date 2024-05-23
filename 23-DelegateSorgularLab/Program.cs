﻿using Bogus;
namespace _23_DelegateSorgularLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             *  Listelerde kullanilan pek cok metod ActionDelegate ile
             *  Func delegate alir. Eger Func delegate'in donus tipi bool ise
             *  buna predicate delegate denir.
             * 
             * 
             */

            Faker faker = new Faker("tr");
            List<Person> liste = new List<Person>()
            {
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr"),
                new Person(locale:"tr")
            };
            List<Person> liste2 = new();
            for (int i = 0; i < 100; i++)
            {
                liste2.Add(new Person(locale: "tr"));
            }

            var femaleList = liste2.Where(p=>p.Gender.ToString()=="Female").ToList();
            //Metodlu kullanimi
            var femaleList2 = liste2.Where(CinsiyetBul).ToList();

            // femaleList.ForEach(p => Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.Address.City));
            Console.WriteLine("**************************");
            var maleList = liste2.Where(p => p.Gender.ToString() == "Male").ToList();
            //maleList.ForEach(p => Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.Address.City));

            // Burasi Ercan'i bulamadigi zaman hata verecektir
            //var ilkErkekEleman = maleList.First(p=>p.FirstName=="Ercan");
            var ilkKadinEleman = femaleList.First();

            // Burada FirstOrDefault ömetodu herhangi bir sonuc bulamaz ise hata vermez
            // Geriye null doner
            var ilkErkekEleman2 = maleList.FirstOrDefault(p => p.FirstName == "Ercan");
            var ilkKadinEleman2 = femaleList.FirstOrDefault();


            Console.WriteLine(maleList.Contains(ilkErkekEleman2));

            Person ayse = new Person() { Gender = Bogus.DataSets.Name.Gender.Female, FirstName = "Ayse", LastName = "Kaya" };
            var sonuc = femaleList.FirstOrDefault(ayse);
            femaleList.Add(ayse);
            sonuc = femaleList.FirstOrDefault(ayse);

            Console.WriteLine("Hello, World!");
        }

        public static bool CinsiyetBul(Person person)
        {
            return person.Gender.ToString() == "Male";
        }
    }
}
