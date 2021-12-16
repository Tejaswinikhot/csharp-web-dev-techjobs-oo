using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job job5;
        Job job6;
        Job job7;
        Job job8;
        Job job9;
        Employer employer;
        Location location;
        PositionType positionType;
        CoreCompetency coreCompetency;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            employer = new Employer("ACME");
            location = new Location("Desert");
            positionType = new PositionType("Quality control");
            coreCompetency = new CoreCompetency("Persistence");
            job3 = new Job("Product tester", employer, location, positionType, coreCompetency);
            job4 = new Job("Product tester", employer, location, positionType, coreCompetency);
            job5 = new Job(null, employer, location, positionType, coreCompetency);
            job6 = new Job("Product tester", null, location, positionType, coreCompetency);
            job7 = new Job("Product tester", employer, null, positionType, coreCompetency);
            job8 = new Job("Product tester", employer, location, null, coreCompetency);
            job9 = new Job("Product tester", employer, location, positionType, null);

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(job1.Id == 1);
            Assert.IsFalse(job2.Id == 1);
            Assert.IsTrue(job2.Id == 2);
            Assert.AreNotEqual(job1, job2);
            Assert.AreEqual(job1.Id, job2.Id, 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        { 
            Assert.AreEqual(employer.Value, job3.EmployerName.Value);
            Assert.AreEqual(location.Value, job3.EmployerLocation.Value);
            Assert.AreEqual(positionType.Value, job3.JobType.Value);
            Assert.AreEqual(coreCompetency.Value, job3.JobCoreCompetency.Value);
            Assert.AreEqual("Product tester", job3.Name);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestJobsToStringAllData()
        {
            String jobStringVal = "ID: " + job4.Id;
            jobStringVal += "\n" + "Name: " + job4.Name;
            jobStringVal += "\n" + "Employer: " + job4.EmployerName.ToString();
            jobStringVal += "\n" + "Location: " + job4.EmployerLocation.ToString();
            jobStringVal += "\n" + "Position Type: " + job4.JobType.ToString();
            jobStringVal += "\n" + "Core Competency: " + job4.JobCoreCompetency.ToString();
            jobStringVal += "\n";
            Assert.AreEqual(job4.ToString(), jobStringVal);
        }

        [TestMethod]
        public void TestJobsToStringMissingAll()
        {
            Assert.AreEqual(job1.ToString(), "OOPS! This job does not seem to exist.");
        }

        [TestMethod]
        public void TestJobsToStringMissingName()
        {
            String jobStringVal5 = "ID: " + job5.Id;
            jobStringVal5 += "\n" + "Name: Data not available";
            jobStringVal5 += "\n" + "Employer: " + job5.EmployerName.ToString();
            jobStringVal5 += "\n" + "Location: " + job5.EmployerLocation.ToString();
            jobStringVal5 += "\n" + "Position Type: " + job5.JobType.ToString();
            jobStringVal5 += "\n" + "Core Competency: " + job5.JobCoreCompetency.ToString()+ "\n";
            Assert.AreEqual(job5.ToString(), jobStringVal5);
        }

        [TestMethod]
        public void TestJobsToStringMissingEmployerName()
        {
            String jobStringVal6 = "ID: " + job6.Id;
            jobStringVal6 += "\n" + "Name: " + job6.Name.ToString();
            jobStringVal6 += "\n" + "Employer: Data not available";
            jobStringVal6 += "\n" + "Location: " + job6.EmployerLocation.ToString();
            jobStringVal6 += "\n" + "Position Type: " + job6.JobType.ToString();
            jobStringVal6 += "\n" + "Core Competency: " + job6.JobCoreCompetency.ToString() + "\n";
            Assert.AreEqual(job6.ToString(), jobStringVal6);
        }

        [TestMethod]
        public void TestJobsToStringMissingEmployerLocation()
        {
            String jobStringVal7 = "ID: " + job7.Id;
            jobStringVal7 +=  "\n" + "Name: " + job7.Name.ToString();
            jobStringVal7 +=  "\n" + "Employer: " + job7.EmployerName.ToString();
            jobStringVal7 +=  "\n" + "Location: Data not available" ;
            jobStringVal7 +=  "\n" + "Position Type: " + job7.JobType.ToString();
            jobStringVal7 +=  "\n" + "Core Competency: " + job7.JobCoreCompetency.ToString() + "\n";
            Assert.AreEqual(job7.ToString(), jobStringVal7);
        }

        [TestMethod]
        public void TestJobsToStringMissingJobType()
        {
            String jobStringVal8 = "ID: " + job8.Id;
            jobStringVal8 +=  "\n" + "Name: " + job8.Name.ToString();
            jobStringVal8 +=  "\n" + "Employer: " + job8.EmployerName.ToString();
            jobStringVal8 +=  "\n" + "Location: "+ job8.EmployerLocation.ToString(); ;
            jobStringVal8 +=  "\n" + "Position Type: Data not available";
            jobStringVal8 +=  "\n" + "Core Competency: " + job8.JobCoreCompetency.ToString()+ "\n";
            Assert.AreEqual(job8.ToString(), jobStringVal8);
        }

        [TestMethod]
        public void TestJobsToStringMissingJobCoreCompetency()
        {
            String jobStringVal9 = "ID: " + job9.Id;
            jobStringVal9 += "\n" + "Name: " + job9.Name.ToString();
            jobStringVal9 += "\n" + "Employer: " + job9.EmployerName.ToString();
            jobStringVal9 += "\n" + "Location: "+ job9.EmployerLocation.ToString(); ;
            jobStringVal9 += "\n" + "Position Type: " + job9.JobType.ToString();
            jobStringVal9 += "\n" + "Core Competency: Data not available\n";
            Assert.AreEqual(job9.ToString(), jobStringVal9);

        }
    }
}
