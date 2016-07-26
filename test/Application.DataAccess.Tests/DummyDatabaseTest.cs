using Xunit;

namespace Application.DataAccess.Tests
{
    public class DummyDatabaseTest
    {
        [Fact]
        public void GetName_ReturnsCorrectValue() 
        {
            var sut = new DummyDatabase();

            var result = sut.GetName();

            Assert.Equal("World", result);
        }
    }
}
