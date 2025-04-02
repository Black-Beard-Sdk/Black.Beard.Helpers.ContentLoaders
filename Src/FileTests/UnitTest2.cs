using Bb;
using Bb.Configurations;
using Json.Schema;
using System.Reflection;

namespace FileTests
{



    [TestClass]
    public class ConfigurationUnitTest
    {

        [TestMethod]
        public void UnitTest1()
        {

            var p = Assembly.GetEntryAssembly().Location;
            var o = Assembly.GetExecutingAssembly().Location;

            var conf = new GlobalConfiguration()
                .With(GlobalConfiguration.Configuration, c =>
                {
                    c.AddDirectory(new DirectoryInfo(@"f:\test\Configs"));
                })
                .With(GlobalConfiguration.Schema, c =>
                {
                    c.AddDirectory(new DirectoryInfo(@"f:\test\Schemas"));
                });

            conf.AppendDocument(GlobalConfiguration.Configuration, new { Test = "toto" });

        }



    }



    [TestClass]
    public class UnitTest2
    {


        public UnitTest2()
        {

        }


        [TestMethod]
        public void GenerateSchema1()
        {

            var id = new Uri("http://example.com/schema/TestGeneratedSchema");
            var schema = typeof(TestGeneratedSchema)
                .GenerateSchemaForConfiguration(id);

        }

        [TestMethod]
        public void GenerateSchema2()
        {

            Uri id = null;
            var schema = typeof(TestGeneratedSchema)
                .GenerateSchemaForConfiguration(id);

        }

    }


    public class TestGeneratedSchema
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> Phones { get; set; }
        public Dictionary<string, string> Address { get; set; }
    }



}