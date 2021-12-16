using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {

            String job = ""; 
            if (String.IsNullOrEmpty(this.Name) &&
                (this.EmployerName == null || String.IsNullOrEmpty(this.EmployerName.ToString())) &&
                (this.EmployerLocation == null || String.IsNullOrEmpty(this.EmployerLocation.ToString())) &&
                (this.JobType == null || String.IsNullOrEmpty(this.JobType.ToString())) &&
                (this.JobCoreCompetency == null || String.IsNullOrEmpty(this.JobCoreCompetency.ToString())))
            {
                return "OOPS! This job does not seem to exist.";
            }
            else {
                job = job + "ID: " + this.Id;
                if (String.IsNullOrEmpty(this.Name))
                {
                    job = job + "\n" + "Name: Data not available";
                }
                else
                {
                    job = job + "\n" + "Name: " + this.Name;
                }

                if (this.EmployerName == null || String.IsNullOrEmpty(this.EmployerName.ToString()))
                {
                    job = job + "\n" + "Employer: Data not available";
                }
                else
                {
                    job = job + "\n" + "Employer: " + this.EmployerName.ToString();
                }

                if (this.EmployerLocation == null || String.IsNullOrEmpty(this.EmployerLocation.ToString()))
                {
                    job = job + "\n" + "Location: Data not available";
                }
                else
                {
                    job = job + "\n" + "Location: " + this.EmployerLocation.ToString();
                }

                if (this.JobType == null || String.IsNullOrEmpty(this.JobType.ToString()))
                {
                    job = job + "\n" + "Position Type: Data not available";
                }
                else
                {
                    job = job + "\n" + "Position Type: " + this.JobType.ToString();
                }

                if (this.JobCoreCompetency == null || String.IsNullOrEmpty(this.JobCoreCompetency.ToString()))
                {
                    job = job + "\n" + "Core Competency: Data not available";
                }
                else
                {
                    job = job + "\n" + "Core Competency: " + this.JobCoreCompetency.ToString();
                }
                job = job + "\n";
            }

            
            return job;
        }
    }
}
