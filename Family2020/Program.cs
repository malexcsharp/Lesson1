using Family2020.Data.Loops.Context;
using Family2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family2020.Extentions;

namespace Family2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataContext();
            var families = context.Families;

            var zip = "12345";
            var zipWrong = "123456";
            var zipWrong2 = "sd125";
            var zipRight = "123456789"; 

            Console.WriteLine( zip.IsValidZip());
            Console.WriteLine(zipWrong.IsValidZip());
            Console.WriteLine(zipWrong2.IsValidZip());
            Console.WriteLine(zipRight.IsValidZip()); 



            var myName = "Vasya";
            Console.WriteLine(myName.SayHello());

            var tester = new MyTester(families);

            //List<Family> familes = tester.GetFamilyWithNoKids();

            //List<Family> familes = tester.GetFamilyWithMostKids();

            //List<Family> familes = tester.GetFamilyByName("Ella");

            //List<Family> familes = tester.GetFamilyWithYoungestChild();

            //List<Family> familes = tester.GetFamilyWithOldestChild();

            //List<Family> familes = tester.GetFamilyWithNameStartsWith("O");

            List<Family> familes = tester.GetFamilyWithParentNameStartsWith("A");

            // tester.GetFamilyWithFathersAge();

            foreach (var item in familes)
            {
                PrintFamily(item);
            }
            //tester.Run();

            //foreach (var item in families)
            //{
            //    Console.WriteLine(item);

            //}
            Console.ReadLine();
        }

        public static void PrintFamily(Family family)
        {
            Console.WriteLine(family);
        }

        public static void PrintFamilies(List<Family> families)
        {
            foreach (var family in families)
            {
                PrintFamily(family);
            }

        }
    }
}
