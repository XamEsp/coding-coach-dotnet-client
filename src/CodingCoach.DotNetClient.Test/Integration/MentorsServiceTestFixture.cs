using System.Threading.Tasks;
using CodingCoach.DotNetClient.Services;
using NUnit.Framework;

namespace CodingCoach.DotNetClient.Test.Integration
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetOkTest()
        {
            // Arrange
            Configuration.Environment = Env.Prod;
            var mentorsService = new MentorsService();

            // Act
            var mentors = await mentorsService.Get();

            // Assert
            Assert.That(mentors?.Data?.Count ?? 0, Is.GreaterThan(0));
        }
    }
}