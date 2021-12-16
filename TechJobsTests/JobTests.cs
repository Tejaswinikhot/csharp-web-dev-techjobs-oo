using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsTrue(job1.Id == 1);
            Assert.IsFalse(job2.Id == 1);
            Assert.IsTrue(job2.Id == 2);
            Assert.AreNotEqual(job1, job2);
            Assert.AreEqual(job1.Id, job2.Id, 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job3 = new Job("Product tester", employer, location, positionType, coreCompetency);

            Assert.AreEqual(employer.Value, job3.EmployerName.Value);
            Assert.AreEqual(location.Value, job3.EmployerLocation.Value);
            Assert.AreEqual(positionType.Value, job3.JobType.Value);
            Assert.AreEqual(coreCompetency.Value, job3.JobCoreCompetency.Value);
            Assert.AreEqual("Product tester", job3.Name);
            Assert.IsTrue(job3.Id == 3);
            Assert.IsTrue(employer.Id == 1);
            Assert.IsTrue(location.Id == 2);
            Assert.IsTrue(positionType.Id == 3);
            Assert.IsTrue(coreCompetency.Id == 4);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job4 = new Job("Product tester", employer, location, positionType, coreCompetency);

            Job job5 = new Job("Product tester", employer, location, positionType, coreCompetency);
            Assert.IsFalse(job4.Equals(job5));
        }

        [TestMethod]
        public void TestJobsToStringAllData()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job6 = new Job("Product tester", employer, location, positionType, coreCompetency);
            Assert.IsTrue(job6.Id==6);
            String jobStringVal = "ID: " + job6.Id;
            jobStringVal = jobStringVal + "\n" + "Name: " + job6.Name;
            jobStringVal = jobStringVal + "\n" + "Employer: " + job6.EmployerName.ToString();
            jobStringVal = jobStringVal + "\n" + "Location: " + job6.EmployerLocation.ToString();
            jobStringVal = jobStringVal + "\n" + "Position Type: " + job6.JobType.ToString();
            jobStringVal = jobStringVal + "\n" + "Core Competency: " + job6.JobCoreCompetency.ToString();
            jobStringVal = jobStringVal + "\n";
            Assert.AreEqual(job6.ToString(), jobStringVal);
        }

        [TestMethod]
        public void TestJobsToStringMissingAll()
        {
            Job job7 = new Job();
            Assert.IsTrue(job7.Id == 7);
            Assert.AreEqual(job7.ToString(), "OOPS! This job does not seem to exist.");
        }

        [TestMethod]
        public void TestJobsToStringMissingName()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job8 = new Job(null, employer, location, positionType, coreCompetency);
            Assert.IsTrue(job8.Id==8);
            String jobStringVal8 = "ID: " + job8.Id;
            jobStringVal8 = jobStringVal8 + "\n" + "Name: Data not available";
            jobStringVal8 = jobStringVal8 + "\n" + "Employer: " + job8.EmployerName.ToString();
            jobStringVal8 = jobStringVal8 + "\n" + "Location: " + job8.EmployerLocation.ToString();
            jobStringVal8 = jobStringVal8 + "\n" + "Position Type: " + job8.JobType.ToString();
            jobStringVal8 = jobStringVal8 + "\n" + "Core Competency: " + job8.JobCoreCompetency.ToString();
            jobStringVal8 = jobStringVal8 + "\n";
            Assert.AreEqual(job8.ToString(), jobStringVal8);
        }

        [TestMethod]
        public void TestJobsToStringMissingEmployerName()
        {
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job9 = new Job("Product tester", null, location, positionType, coreCompetency);
            Assert.IsTrue(job9.Id == 9);
            String jobStringVal9 = "ID: " + job9.Id;
            jobStringVal9 = jobStringVal9 + "\n" + "Name: " + job9.Name.ToString();
            jobStringVal9 = jobStringVal9 + "\n" + "Employer: Data not available";
            jobStringVal9 = jobStringVal9 + "\n" + "Location: " + job9.EmployerLocation.ToString();
            jobStringVal9 = jobStringVal9 + "\n" + "Position Type: " + job9.JobType.ToString();
            jobStringVal9 = jobStringVal9 + "\n" + "Core Competency: " + job9.JobCoreCompetency.ToString();
            jobStringVal9 = jobStringVal9 + "\n";
            Assert.AreEqual(job9.ToString(), jobStringVal9);
        }

        [TestMethod]
        public void TestJobsToStringMissingEmployerLocation()
        {
            Employer employer = new Employer("ACME");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job10 = new Job("Product tester", employer, null, positionType, coreCompetency);
            Assert.IsTrue(job10.Id == 10);
            String jobStringVal10 = "ID: " + job10.Id;
            jobStringVal10 = jobStringVal10 + "\n" + "Name: " + job10.Name.ToString();
            jobStringVal10 = jobStringVal10 + "\n" + "Employer: " + job10.EmployerName.ToString();
            jobStringVal10 = jobStringVal10 + "\n" + "Location: Data not available" ;
            jobStringVal10 = jobStringVal10 + "\n" + "Position Type: " + job10.JobType.ToString();
            jobStringVal10 = jobStringVal10 + "\n" + "Core Competency: " + job10.JobCoreCompetency.ToString();
            jobStringVal10 = jobStringVal10 + "\n";
            Assert.AreEqual(job10.ToString(), jobStringVal10);
        }

        [TestMethod]
        public void TestJobsToStringMissingJobType()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            Job job11 = new Job("Product tester", employer, location, null, coreCompetency);
            Assert.IsTrue(job11.Id == 11);
            String jobStringVal11 = "ID: " + job11.Id;
            jobStringVal11 = jobStringVal11 + "\n" + "Name: " + job11.Name.ToString();
            jobStringVal11 = jobStringVal11 + "\n" + "Employer: " + job11.EmployerName.ToString();
            jobStringVal11 = jobStringVal11 + "\n" + "Location: "+ job11.EmployerLocation.ToString(); ;
            jobStringVal11 = jobStringVal11 + "\n" + "Position Type: Data not available";
            jobStringVal11 = jobStringVal11 + "\n" + "Core Competency: " + job11.JobCoreCompetency.ToString();
            jobStringVal11 = jobStringVal11 + "\n";
            Assert.AreEqual(job11.ToString(), jobStringVal11);
        }

        [TestMethod]
        public void TestJobsToStringMissingJobCoreCompetency()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            Job job12 = new Job("Product tester", employer, location, positionType, null);
            Assert.IsTrue(job12.Id == 12);
            String jobStringVal12 = "ID: " + job12.Id;
            jobStringVal12 = jobStringVal12 + "\n" + "Name: " + job12.Name.ToString();
            jobStringVal12 = jobStringVal12 + "\n" + "Employer: " + job12.EmployerName.ToString();
            jobStringVal12 = jobStringVal12 + "\n" + "Location: "+ job12.EmployerLocation.ToString(); ;
            jobStringVal12 = jobStringVal12 + "\n" + "Position Type: " + job12.JobType.ToString();
            jobStringVal12 = jobStringVal12 + "\n" + "Core Competency: Data not available";
            jobStringVal12 = jobStringVal12 + "\n";
            Assert.AreEqual(job12.ToString(), jobStringVal12);

        }
    }
}
