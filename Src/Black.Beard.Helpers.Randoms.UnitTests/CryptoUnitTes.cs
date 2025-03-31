using Bb;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System.Text.RegularExpressions;

namespace Randoms.UnitTests
{

    [TestClass]
    public class CryptoUnitTest
    {

        [TestMethod]
        public void TestRandomInteger()
        {

            var pwd = Randomizer.GeneratePassword(32);

            var ll = pwd.Length;

            var source = Randomizer.GeneratePassword(18);

            var encoded = source.EncryptStringAes256(pwd);
            var e = encoded.DecryptStringAes256(pwd);

            Assert.IsTrue(e == source);

        }

       

        [TestMethod]
        public void TestRandomPassword()
        {
            var txt = Randomizer.GeneratePassword(18);
            Assert.IsTrue(txt.Length == 18);
        }


    }
}