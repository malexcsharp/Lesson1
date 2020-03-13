using System;
using System.Collections.Generic;
using Family2020.Data.Loops.Context;
using Family2020.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Family2020.Test
{
    [TestClass]
    public class MyTesterTest
    {
        private MyTester _stats;

        [TestInitialize]
        public  void InitTest()
        {
            var context = new DataContext();
            _stats = new MyTester(context.Families);
        }


        [TestMethod]
        public void GetFamilyWithNoKidsTest()
        {
            

            //Act
            List<Family> fam = _stats.GetFamilyWithNoKids();

            //Assert
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count >0);
            Assert.AreEqual(1, fam.Count);
            Assert.AreEqual(3, fam[0].FamilyId);
        }

        [TestMethod]
        public void GetFamilyWithMostKidsTest()
        {
            

            //Act
            List<Family> fam = _stats.GetFamilyWithMostKids();

            //Assert
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count > 0);
            Assert.AreEqual(1, fam[0].FamilyId);
        }

        [TestMethod]
        public void GetFamilyByNameTest()
        {
            

            //Act
            List<Family> fam = _stats.GetFamilyByName("jim");
            Assert.IsTrue(fam[0].FamilyId == 1);
            fam = _stats.GetFamilyByName("Emma");
            Assert.IsTrue(fam[0].FamilyId == 2);
            fam = _stats.GetFamilyByName("Matthew");
            Assert.IsTrue(fam[0].FamilyId == 2);

            //Assert

        }
        [TestMethod]
        public void FamilyAvarageAgeTest()
        {
            int fatherAge = 25;
            int motherAge = 23;

            var family = new Family();
            family.Father = new Adult();
            family.Mother = new Adult();
            family.Father.DateOfBirth = DateTime.Today.AddYears(-fatherAge);
            family.Mother.DateOfBirth = DateTime.Today.AddYears(-motherAge);

            family.Children.Add(new Person() { DateOfBirth = DateTime.Today.AddYears(-12) });

            Assert.AreEqual(20, family.AvgAge);

        }

        [TestMethod]
        public void GetFamilyWithYoungestChildTest()
        {
            

            //Act
            List<Family> fam = _stats.GetFamilyWithYoungestChild();

            //Assert
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count >0);
            Assert.AreEqual(1, fam[0].FamilyId);
        }

        
            [TestMethod]
        public void GetFamilyWithOldestChildTest()
        {
            

            //Act
            List<Family> fam = _stats.GetFamilyWithOldestChild();

            //Assert
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count >0);
            Assert.AreEqual(4, fam[0].FamilyId);
        }
    }
}
