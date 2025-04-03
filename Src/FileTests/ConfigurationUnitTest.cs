using Bb.Configurations;
using Bb;

namespace FileTests
{
    [TestClass]
    public class ConfigurationUnitTest
    {

        [TestMethod]
        public void UnitTest1()
        {


            var expected = new ConfigurationModelTest()
            {
                Name = "testName",
                Age = 10,
                Address = "testAddress"
            };

            var key = GlobalConfiguration.GetFilename(expected.GetType());
            var file = "test".GetTempPath()
                .Combine(key + ".json")
                .AsFile();

            file
                .FullName
                .SerializeAndSaveConfiguration(key, expected);

            var model = file.FullName.LoadFromFileAndDeserializesConfiguration<ConfigurationModelTest>(key);

            Assert.AreEqual(expected.Name, model.Name);
            Assert.AreEqual(expected.Address, model.Address);
            Assert.AreEqual(expected.Age, model.Age);

        }


            [TestMethod]
        public void UnitTest2()
        {


            var expected = new ConfigurationModelTest()
            {
                Name = "testName",
                Age = 10,
                Address = "testAddress"
            };

            var conf = new GlobalConfiguration()
                .SetRoot("test".GetTempPath())
                .WithDirectory(GlobalConfiguration.Configuration, "Config")
                .WithDirectory(GlobalConfiguration.Schema, "Config")
                ;

            conf.AppendDocument(GlobalConfiguration.Configuration, expected);

            var model = conf.GetDocument<ConfigurationModelTest>(GlobalConfiguration.Configuration);

            Assert.AreEqual(expected.Name, model.Name);
            Assert.AreEqual(expected.Address, model.Address);
            Assert.AreEqual(expected.Age, model.Age);


        }



    }




    public class ConfigurationModelTest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    


}