using Bb;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System.Text.RegularExpressions;

namespace Randoms.UnitTests
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestRandomInteger()
        {
            var randomizer = Randomizer.GenerateInteger();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomBytes()
        {
            var randomizer = Randomizer.GenerateByte();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomDouble()
        {
            var randomizer = Randomizer.GenerateDouble();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomfloat()
        {
            var randomizer = Randomizer.GenerateFloat();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomLong()
        {
            var randomizer = Randomizer.GenerateLong();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomShort()
        {
            var randomizer = Randomizer.GenerateShort();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomstring()
        {
            var randomizer2 = Randomizer.GenerateText();
            var result2 = randomizer2.Generate(false);
        }

        [TestMethod]
        public void TestRandomstringRegEx()
        {
            string pattern = @"\d{5}\w{4}";
            var randomizer = Randomizer.GenerateTextByRegex(pattern);
            var result = randomizer.Generate(false);
            Assert.IsTrue(Regex.Match(result, pattern).Success);
        }

        [TestMethod]
        public void TestRandomDatetime()
        {
            var randomizer = Randomizer.GenerateDateTime();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomTimespan()
        {
            var randomizer = Randomizer.GenerateTimeSpan(true);
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomEmail()
        {
            var randomizer = Randomizer.GenerateEmailAddress();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomIpv4()
        {
            var randomizer = Randomizer.GenerateIpV4();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomIpv6()
        {
            var randomizer = Randomizer.GenerateIpV6();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomBinary()
        {
            var randomizer = Randomizer.GenerateBinary();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomCity()
        {
            var randomizer = Randomizer.GenerateCity();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomLastname()
        {
            var randomizer = Randomizer.GenerateLastName();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomCountry()
        {
            var randomizer = Randomizer.GenerateCountry();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomFirstname()
        {
            var randomizer = Randomizer.GenerateFirstName();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomFullname()
        {
            var randomizer = Randomizer.GenerateFullName();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomIban()
        {
            var randomizer = Randomizer.GenerateIbanBban("FR");
            var result = randomizer.Generate();
        }

        //[TestMethod]
        //public void TestRandomMacaddress()
        //{

        //    var options = new FieldOptionsMACAddress()
        //    {
        //        Min = "",
        //        Max = "",
        //        Uppercase = true,
        //        ValueAsString = true,
        //    };
        //    var randomizer = new RandomizerMACAddress(options);
        //    var result = randomizer.Generate();

        //}

        [TestMethod]
        public void TestRandomLipsum()
        {
            var randomizer = Randomizer.GenerateLipsum(2);
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomNaughtyStrings()
        {

            var options = new FieldOptionsTextNaughtyStrings()
            {
                UseNullValues = false,
                ValueAsString = true,
            };
            var randomizer = new RandomizerTextNaughtyStrings(options);
            var result = randomizer.Generate();

        }



        [TestMethod]
        public void TestRandomPassword()
        {
            var txt = Randomizer.GeneratePassword(18);
            Assert.IsTrue(txt.Length == 18);
        }


    }
}