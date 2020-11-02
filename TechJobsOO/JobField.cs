using System;
namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
                   //Value == field.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }

    public class Employer : JobField
    {
        public Employer(string value) : base(value)
        {
            Value = value;
        }
    }

    public class Location : JobField
    {
        public Location(string value) : base(value)
        {
            Value = value;
        }
    }

    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value)
        {
            Value = value;
        }
    }

    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
            Value = value;
        }
    }


}
