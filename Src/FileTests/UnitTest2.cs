using Bb;
using Json.Schema;

namespace FileTests
{
    [TestClass]
    public class UnitTest2
    {


        public UnitTest2()
        {

        }


        [TestMethod]
        public void GenerateSchema()
        {

            var id = new Uri("http://example.com/schema/TestGeneratedSchema");
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