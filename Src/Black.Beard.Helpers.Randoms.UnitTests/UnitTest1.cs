using Bb;
using Newtonsoft.Json.Linq;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System.Text.RegularExpressions;

namespace Black.Beard.Helpers.Randoms.UnitTests
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestRandomInteger()
        {
            var randomizer = Bb.Randoms.GenerateInteger();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomBytes()
        {
            var randomizer = Bb.Randoms.GenerateByte();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomDouble()
        {
            var randomizer = Bb.Randoms.GenerateDouble();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomfloat()
        {
            var randomizer = Bb.Randoms.GenerateFloat();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomLong()
        {
            var randomizer = Bb.Randoms.GenerateLong();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomShort()
        {
            var randomizer = Bb.Randoms.GenerateShort();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomstring()
        {
            var randomizer2 = Bb.Randoms.GenerateText();
            var result2 = randomizer2.Generate(false);
        }

        [TestMethod]
        public void TestRandomstringRegEx()
        {
            string pattern = @"\d{5}\w{4}";
            var randomizer = Bb.Randoms.GenerateTextByRegex(pattern);
            var result = randomizer.Generate(false);
            Assert.IsTrue(Regex.Match(result, pattern).Success);
        }

        [TestMethod]
        public void TestRandomDatetime()
        {
            var randomizer = Bb.Randoms.GenerateDateTime();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomTimespan()
        {
            var randomizer = Bb.Randoms.GenerateTimeSpan(true);
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomEmail()
        {
            var randomizer = Bb.Randoms.GenerateEmailAddress();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomIpv4()
        {
            var randomizer = Bb.Randoms.GenerateIpV4();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomIpv6()
        {
            var randomizer = Bb.Randoms.GenerateIpV6();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomBinary()
        {
            var randomizer = Bb.Randoms.GenerateBinary();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomCity()
        {
            var randomizer = Bb.Randoms.GenerateCity();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomLastname()
        {
            var randomizer = Bb.Randoms.GenerateLastName();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomCountry()
        {
            var randomizer = Bb.Randoms.GenerateCountry();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomFirstname()
        {
            var randomizer = Bb.Randoms.GenerateFirstName();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomFullname()
        {
            var randomizer = Bb.Randoms.GenerateFullName();
            var result = randomizer.Generate();
        }

        [TestMethod]
        public void TestRandomIban()
        {
            var randomizer = Bb.Randoms.GenerateIbanBban("FR");
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
            var randomizer = Bb.Randoms.GenerateLipsum(2);
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
            var txt = Bb.Randoms.GeneratePassword(18);
            Assert.IsTrue(txt.Length == 18);
        }


    }
}