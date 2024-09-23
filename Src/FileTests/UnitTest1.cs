using Bb;
using System.Diagnostics;

namespace FileTests
{
    [TestClass]
    public class UnitTest1
    {


        public UnitTest1()
        {

        }


        [TestMethod]
        public void TestLoadCsv()
        {

            var file = Path.Combine(Environment.CurrentDirectory, "test1.csv").AsFile();
            foreach (var item2 in file.ReadBigCsvToJson(true, ";"))
            {

            }

        }

        public class Box
        {

            public int Total { get; set; }

            public int Value { get; set; }
            public bool IsLocker { get; internal set; }
        }

    
    }

}