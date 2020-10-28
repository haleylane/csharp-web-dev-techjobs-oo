using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyTest1()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            //Job test_job = new Job("Web Dev", new Employer("Sony"), new Location("Overland Park", new PositionType("Number One", new CoreCompetency("JavaScript"));
            Job test_job = new Job();
            Job test_job_2 = new Job();
            Assert.AreEqual(test_job.Id + 1, test_job_2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(test_job.Name, "Product tester");
            Assert.AreEqual(test_job.EmployerName.Value, "ACME");
            Assert.AreEqual(test_job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(test_job.JobType.Value, "Quality control");
            Assert.AreEqual(test_job.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job = new Job("Web Dev", new Employer("Sony"), new Location("Overland Park"), new PositionType("Number One"), new CoreCompetency("JavaScript"));
            Job test_job_2 = new Job("Web Dev", new Employer("Sony"), new Location("Overland Park"), new PositionType("Number One"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(test_job.Equals(test_job_2));
        }
    }

}
