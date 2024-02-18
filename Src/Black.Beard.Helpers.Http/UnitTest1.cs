using Bb;
using System.Xml.Linq;

namespace Black.Beard.Helpers.Http
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
                        
            var tempFile = new FileInfo(Path.Combine(Path.GetTempPath(), Path.GetTempFileName()));
            
            tempFile.Refresh();

            if (tempFile.Exists)
                tempFile.Delete();

            string name = "Black.Beard.Componentmodel";
            var relativePath = Path.Combine("api", "v2", "package", name);
            var uri = new Uri("http://www.nuget.org");
            uri = new Uri(uri, relativePath);

            uri.Download(tempFile);

            tempFile.Refresh();

            var t = tempFile.Exists;

            if (t)
                tempFile.Delete();

            Assert.IsTrue(t);
               

        }

    }
}