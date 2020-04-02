using NUnit.Framework;

namespace CodingCoach.DotNetClient.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetOkTest()
        {
            // Arrange
            var mentorsService = new MentorsService();

            // Act
            var mentors = mentorsService.Get();

            // Assert
            Assert.True(!string.IsNullOrWhiteSpace(mentors));
        }
    }
}