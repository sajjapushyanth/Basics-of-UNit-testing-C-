using NUnit.Framework;
using TestNinja.Mocking;

namespace UnitTestProject_1.Mocking
{
    private Mock<IFileReader> _fileReader
    [SetUp]
    public void SetUp()
    {
        _fileReader = new Mock<IFileReader>();
        
    }
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoService(new FakeFileReader());
            
            //service.FileReader = new FakeFileReader();
            
            var result=service.ReadVideoTitle();
            Assert.That(result,Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosareProcessed_Retrun_EmptyString()
        {
            
        }
        
    }
}