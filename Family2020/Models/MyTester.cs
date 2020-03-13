using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Family2020.Models
{
    public class MyTester
    {
        private readonly List<Family> _data;

        public MyTester(List<Family> data)
        {
            _data = data;
        }

        public void Run()
        {
            var family = new Family();
            var Father = new Adult();
            var Mother = new Adult();


            family.FamilyId = 1;
            family.Nickname = "Johnsons";

            Father.PersonId = 1;
            Father.Name = "Jim";
            Father.LastName = "Johnson";
            Father.DateOfBirth = Convert.ToDateTime("05/29/1987");
            Father.LicenseNumber = "2344454";
            Father.Job = "Programmer";
            family.Father = Father;

            Mother.PersonId = 2;
            Mother.Name = "Amy";
            Mother.LastName = "Johnson";
            Mother.DateOfBirth = Convert.ToDateTime("11/13/1986");
            Mother.LicenseNumber = "8888";
            Mother.Job = "Nurse";
            family.Mother = Mother;

            var child = new Child();
            child.PersonId = 3;
            child.NickName = "Ninsa";
            child.Name = "Bob";
            child.LastName = "Johnson";
            child.DateOfBirth = Convert.ToDateTime("01/14/2016");

            var child2 = new Child();
            child2.PersonId = 3;
            child2.NickName = "Ella";
            child2.Name = "Ella";
            child2.LastName = "Johnson";
            child2.DateOfBirth = Convert.ToDateTime("01/14/2014");

            var child3 = new Child();
            child3.PersonId = 3;
            child3.NickName = "Ella";
            child3.Name = "Sophia";
            child3.LastName = "Johnson";
            child3.DateOfBirth = Convert.ToDateTime("01/14/2017");


            family.Children.Add(child);
            family.Children.Add(child2);
            family.Children.Add(child3);

            Console.WriteLine(family.ToString());
        }

        public List<Family> GetFamilyWithParentNameStartsWith(string v)
        {
            Console.WriteLine("------------GetFamilyWithParentNameStartsWith--------------");
            //List<Family> response = new List<Family>();
            List<Family> response = _data.Where(p => p.Father.Name.StartsWith(v) && p=>p.Mother.Name.StartsWith(v)).ToList();


            //foreach (var family in _data)
            //{
            //    if (family.Father.Name.StartsWith(v) || family.Mother.Name.StartsWith(v))
            //    {
            //        response.Add(family);
            //    }                

            //}


            return response;
        }

        public List<Family> GetFamilyWithNameStartsWith(string v)
        {
            Console.WriteLine("------------GetFamilyWithNameStartsWith--------------");
            //List<Family> response = _data.Where(p=>p.)

            List<Family> response = new List<Family>();

            //foreach (var family in _data)
            //{
            //    if (family.Father.Name.StartsWith(v) || family.Mother.Name.StartsWith(v))
            //    {
            //        response.Add(family);
            //    }
            //    foreach (var item in family.Children)
            //    {
            //        if (item.Name.StartsWith(v))
            //        {
            //            response.Add(family);
            //        }
            //    }
            //}            

            return response;
        }

        public List<Family> GetFamilyWithOldestChild()
        {
            Console.WriteLine("------------GetFamilyWithOldestChild--------------");

            List<Family> response = _data.Where(p => p.Children.)

            //List <Family> response = new List<Family>();
            //var childrenAge = new List<int>();
            //foreach (var family in _data)
            //{
            //    foreach (var item in family.Children)
            //    {
            //        childrenAge.Add(item.Age);
            //    }
            //}
            //int maxAge = childrenAge.Max();
            //foreach (var family in _data)
            //{
            //    foreach (var item in family.Children)
            //    {
            //        if (item.Age == maxAge)
            //        {
            //            response.Add(family);
            //        }
            //    }
            //}

            return response;
        }

        public List<Family> GetFamilyWithYoungestChild()
        {
            Console.WriteLine("------------GetFamilyWithYoungestChild--------------");

            //List<Family> response = new List<Family>();
            var childrenAge = new List<int>();
            foreach (var family in _data)
            {
                foreach (var item in family.Children)
                {
                    childrenAge.Add(item.Age);
                }
            }
            int minAge = childrenAge.Min();

            List<Family> response = _data.Where(p=>p.Children.DateOfBirth == minAge))

            //foreach (var family in _data)
            //{
            //    foreach (var item in family.Children)
            //    {
            //        if (item.Age == minAge)
            //        {
            //            response.Add(family);
            //        }
            //    }
            //}

            return response;
        }

        public List<Family> GetFamilyWithNoKids()
        {
            Console.WriteLine("------------GetFamilyWithNoKids--------------");

            List<Family> response = _data.Where(p => p.Children.Count == 0).ToList();

            //List<Family> response = new List<Family>();
            //foreach (var item in _data)
            //{
            //    if (item.Children.Count==0)
            //    {
            //        response.Add(item);
            //    }
            //}
            return response;
        }

        public List<Family> GetFamilyWithMostKids()
        {
            Console.WriteLine("------------GetFamilyWithMostKids--------------");

            //List<Family> response = new List<Family>();

            List<int> child = new List<int>();
            int chMax = 0;


            foreach (var item in _data)
            {

                if (item.Children.Count > chMax)
                {
                    chMax = item.Children.Count;
                }

            }
            int maxCount = child.Max();

            List<Family> response = _data.Where(p => p.Children.Count == maxCount).ToList();


            //foreach (var item in _data)
            //{
            //    if (item.Children.Count == chMax)
            //    {
            //        response.Add(item);
            //    }
            //}

            return response;
        }

        public List<Family> GetFamilyByName(string nameToFind)
        {
            Console.WriteLine("------------GetFamilyByName--------------");

            List<Family> response = new List<Family>();
            List<Person> childrenName = new List<Person>();
            foreach (var family in _data)
            {
                if (family.Father.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase) || family.Mother.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase))
                {
                    response.Add(family);
                }
                else
                {
                    foreach (var child in family.Children)
                    {
                        if (child.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase))
                        {
                            response.Add(family);
                            break;
                        }

                    }

                }
            }
            return response;
        }

        public void GetFamilyWithFathersAge()
        {
            Console.WriteLine("------------GetFamilyWithFathersAge--------------");

            List<Family> response = new List<Family>();
            foreach (var item in _data)
            {
                Console.WriteLine($"{item.Father.Name} {item.Father.Age}");
            }

        }
    }
}
