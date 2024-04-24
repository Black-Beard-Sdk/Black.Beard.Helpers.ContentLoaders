using Bb;

namespace FileTests
{
    [TestClass]
    public class UnitTest1
    {


        public UnitTest1()
        {

        }


        [TestMethod]
        public void TestMethod1()
        {

            var file = Path.Combine(Environment.CurrentDirectory, "test1.csv").AsFile();
            foreach (var item2 in file.ReadBigCsvToJson(true, ";"))
            {

            }

        }
           
    }
}