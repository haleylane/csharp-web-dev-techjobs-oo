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

        [TestMethod]
        public void TestToString()
        {
            Job testJob = new Job("Web Dev", new Employer("Sony"), new Location("Overland Park"), new PositionType("Number One"), new CoreCompetency("JavaScript"));
            
            string expectedStringValue = "\n\n";
            string checkerString = testJob.ToString();
            string a = checkerString.Substring(0, 1);
            string b = checkerString.Substring(checkerString.Length-1);
            string ab = a + b;

            Assert.AreEqual(expectedStringValue, ab);
        }

        [TestMethod]
        public void TestToString2()
        {
            //2the string should contain a lable for each field, followed by the data stored in that field, and each field should be on it's own line.
            Job testJob = new Job("Web Dev", new Employer("Sony"), new Location("Overland Park"), new PositionType("Number One"), new CoreCompetency("JavaScript"));
            string checkerString = testJob.ToString();
            string expectedStringa = "\nID: 7\nName: Web Dev\nEmployer: Sony\nLocation: Overland Park\nPosition Type: Number One\nCore Competency: JavaScript\n";

            Assert.AreEqual(expectedStringa, checkerString);
        }


        //3.if a field is empty, the method should add, "Data not available" after the label.
        [TestMethod]
        public void TestToString3()
        {
            Job testerJob = new Job("",new Employer("Sony"), new Location("Overland Park"), new PositionType("Number One"), new CoreCompetency("JavaScript"));
            string testerJobString = testerJob.ToString();
            string expectedStringb = "\nID: 8\nName: Data not available\nEmployer: Sony\nLocation: Overland Park\nPosition Type: Number One\nCore Competency: JavaScript\n";
            Assert.AreEqual(expectedStringb, testerJobString);
        }

        //4.bonus if a job object only contains data for the id field, the method should return "OOPS! This job does not seem to exist."
    }

}
