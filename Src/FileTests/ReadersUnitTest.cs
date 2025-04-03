using Bb;
using System.Diagnostics;

namespace FileTests
{


    [TestClass]
    public class ReadersUnitTest
    {


        //[Theory]
        //[InlineData("file:///C:/path/to/file", "c:\\path\\to\\file")]
        //[InlineData("C:/path/to/%66ile", "c:\\path\\to\\file")]
        //[InlineData("C:/path/to/FILE", "c:\\path\\to\\file")]
        //[InlineData("C:/path/to/%20file", "c:\\path\\to\\ file")]
        //public void Format_ShouldReturnExpectedResult(string input, string expected)
        //{
        //    // Act
        //    var result = PathHelper.FormatPath(input);

        //    // Assert
        //    Assert.Equal(expected, result);
        //}


        public ReadersUnitTest()
        {

        }


        [TestMethod]
        public void TestwriteFile()
        {

            var file = Path.Combine(Environment.CurrentDirectory, "test1.csv").AsFile();

            var data = new List<string[]>()
            {
                new string[] { "1", "2", "3" },
                new string[] { "4", "5", "6" },
                new string[] { "7", "8", "9" },
            };


            file.Save(c =>
            {         
                data.SerializeToStream(c);                
            });

        }

        [TestMethod]
        public void TestLoadCsv()
        {

            var file = Path.Combine(Environment.CurrentDirectory, "test1.csv").AsFile();
            foreach (var item2 in file.ReadBigCsvToJson(true, ";"))
            {

            }

        }


        [TestMethod]
        public void TestLoadMcsv()
        {

            var dic = new Dictionary<string, Box>();
            var file = @"C:\Users\g.beard\Downloads\S_20240920010118402_99EB9C96_post\GEODATA_NPF_FR11_FR11_DPD_WWW_D20240920T030251_5669106"
                .AsFile();
            var f = file.LoadMultiCsv("PUDOGENERALINFO:PUDOADDRESS|PUDOHOURS|PUDODOWNTIME|PUDOMGMTENTITY|PUDODOWNTIMELINE",
                c =>
                {

                    c.See("PUDOGENERALINFO", (c) =>
                    {

                        var l = c["PUDOTYPE"];
                        switch (l)
                        {

                            case "":
                            case "400":
                            case "501":
                                break;

                            case "200":
                            case "300":
                            case "100":
                                {

                                    var key = c["PUDOID"].Substring(0, 2);
                                    if (!dic.TryGetValue(key, out var value))
                                    {
                                        dic.Add(key, value = new Box()
                                        {
                                            IsLocker = false,
                                        });
                                    }
                                    value.Total++;
                                    if (c["SERVICEPUDO"].Contains("306"))
                                        value.Value++;

                                    break;
                                }

                            default:
                                break;
                        }

                        return true;

                    });

                }
                );

            foreach (var item in dic)
                Debug.WriteLine($"{item.Key}; {item.Value.Value} / {item.Value.Total} ({item.Value.Total - item.Value.Value})");

        }


        public class Box
        {

            public int Total { get; set; }

            public int Value { get; set; }
            public bool IsLocker { get; internal set; }
        }


    }

}