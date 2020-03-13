using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family2020.Models
{
  public class Person
    {
        private readonly int MyProperty;

        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }            
        }

        public int PersonId { get; set; }
        public string Name { get; set; }        
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    


    }
}
