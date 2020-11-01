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
            string errorMessage = "Data not available";
            //string stringy = "\n" + "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + JobCoreCompetency + "\n";
            if (Name == "" || (Name is null))
            {

                return "\n" + "ID: " + Id + "\n" + "Name: " + errorMessage + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + JobCoreCompetency + "\n";
            }
            else if (EmployerName.Value == "" || (EmployerName.Value is null))
            {

                return "\n" + "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + errorMessage + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + JobCoreCompetency + "\n";
            }
            else if (EmployerLocation.Value == "" || (EmployerLocation.Value is null))
            {
                return "\n" + "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + errorMessage + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + JobCoreCompetency + "\n";
            }
            else if (JobType.Value == "" || (JobType.Value is null))
            {
                return "\n" + "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + errorMessage + "\n" + "Core Competency: " + JobCoreCompetency + "\n";
            }
            else if (JobCoreCompetency.Value == "" || (JobCoreCompetency is null))
            {
                return "\n" + "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + errorMessage + "\n";
            }
            else if ((Name is null) && (EmployerName is null) && (EmployerLocation is null) && (JobType.Value is null) && (JobCoreCompetency.Value is null))
            {
                return "OOPS! This job does not seem to exist.";
            }
            else
            {
                return "\n" + "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + JobCoreCompetency + "\n";
            }
        }
    }
    
}
