using TestNinja.Mocking;

namespace UnitTestProject_1
{
    public class FakeFileReader:IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}