using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family2020.Models
{
    public class Family
    {
        public Family()
        {
            Children = new List<Person>();
        }
        public List<Person> Children { get; set; }
        public int FamilyId { get; set; }
        public string Nickname { get; set; }
        public Adult Father { get; set; }
        public Adult Mother { get; set; }

        private int myVar;

        public int AvgAge
        {
            get {
                var childrenAge = 0;
                foreach (var item in Children)
                {
                    childrenAge+=item.Age;
                }
                
                return (Mother.Age + Father.Age + childrenAge)/ (2+Children.Count); }
           
        }



        public override string ToString()
        {
            //foreach (var family in Families)
            //{

            //}

            var separator = "    ";
            var builder = new StringBuilder();

            builder.AppendLine($"Family {Nickname} ({FamilyId})");
            builder.AppendLine($"{separator}Parerets");
            builder.AppendLine($"{separator}{separator}{Father.Name} - {DateTime.Now.Year - Father.DateOfBirth.Year}, {Father.Job}, {Father.LicenseNumber}");
            builder.AppendLine($"{separator}{separator}{Mother.Name} - {DateTime.Now.Year - Mother.DateOfBirth.Year}, {Mother.Job}, {Mother.LicenseNumber}");
            builder.AppendLine($"{separator}Kids");
            foreach (var child in Children)
            {
                builder.AppendLine($"{separator}{separator}{child.Name} - {DateTime.Now.Year - child.DateOfBirth.Year}");
            }
            builder.AppendLine("");
            builder.AppendLine("------------------------------------------------------------------------------------");

            return builder.ToString();

        }

       
    }

}
