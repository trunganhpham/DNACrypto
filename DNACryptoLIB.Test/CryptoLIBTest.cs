using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNACryptoLIB.Test
{
    [TestFixture]
    public class CryptoLIBTest
    {
        DNACryptoLIB.DNACrypto dnaCrypto;
        DNACryptoLIB.RNACrypto rnaCrypto;
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            dnaCrypto = new DNACryptoLIB.DNACrypto();
            rnaCrypto = new DNACryptoLIB.RNACrypto();
        }

        /*
         * Objective 1
         */
        [Test]
        public void GetDNAEncodedText_OutPut_ValidValue()
        {
            string input = "a";
            string result = dnaCrypto.GetEncryptedText(input);
            Assert.AreEqual(result, "TGAT");

            input = "cat";
            result = dnaCrypto.GetEncryptedText(input);
            Assert.AreEqual(result, "TGACTGATTCTA");

            input = "cat boy";
            result = dnaCrypto.GetEncryptedText(input);
            Assert.AreEqual(result, "TGACTGATTCTAAGAATGAGTGCCTCGT");

            result = dnaCrypto.GetEncryptedText(null);
            Assert.AreEqual(result, "AAAA");
        }

        /*
         * Objective 2
         */
        [Test]
        public void GetRNAEncodedText_OutPut_ValidValue()
        {
            string input = "a";
            string result = rnaCrypto.GetEncryptedText(input);
            Assert.AreEqual(result, "UGAU");

            input = "cat";
            result = rnaCrypto.GetEncryptedText(input);
            Assert.AreEqual(result, "UGACUGAUUCUA");

            input = "cat boy";
            result = rnaCrypto.GetEncryptedText(input);
            Assert.AreEqual(result, "UGACUGAUUCUAAGAAUGAGUGCCUCGU");
        }

        /*
         * Objective 3
         */
        [Test]
        public void GetStartIndexOfSearchStringInDNAEncodedText()
        {
            string inputStrand = "TGACTGATTCTAAGAATGAGTGCCTCGT";
            int result = dnaCrypto.IsEncryptedTextContainsString(inputStrand, "boy");
            Assert.AreEqual(result, 16);

            result = dnaCrypto.IsEncryptedTextContainsString(inputStrand, "coy");
            Assert.AreEqual(result, -1);

            ActualValueDelegate<object> testDelegate = () => dnaCrypto.IsEncryptedTextContainsString(null, "boy");
            Assert.That(testDelegate, Throws.TypeOf<Exception>());
        }


        /*
         * Objective 4
         */
        [Test]
        public void GetASCIIFromComplemetaryEncodedText()
        {           
            string input = "ACTGACTAAGAT";
            string result = dnaCrypto.GetASCIIFromComplemetaryEncodedText(input);
            Assert.AreEqual(result, "cat");

            input = "ACTGACTAAGATTCTTACTCACGGAGCA";
            result = dnaCrypto.GetASCIIFromComplemetaryEncodedText(input);
            Assert.AreEqual(result, "cat boy");

            input = "ACTGAC";
            ActualValueDelegate<object> testDelegate = () => dnaCrypto.GetASCIIFromComplemetaryEncodedText(input);
            Assert.That(testDelegate, Throws.TypeOf<Exception>());

            input = "ACTK";
            ActualValueDelegate<object> testDelegate1 = () => dnaCrypto.GetASCIIFromComplemetaryEncodedText(input);
            Assert.That(testDelegate, Throws.TypeOf<Exception>());

            input = "ACTK";
            ActualValueDelegate<object> testDelegate2 = () => dnaCrypto.GetASCIIFromComplemetaryEncodedText(null);
            Assert.That(testDelegate, Throws.TypeOf<Exception>());
        }


        /*
         * Test Object 5
         */

        [Test]
        public void GetLongestCommonSequence()
        {
            string strand1 = "ATAGC";
            string strand2 = "ACTACGC";
            string result = dnaCrypto.FindLongestCommonSubSequence(strand1, strand2);
            Assert.AreEqual(result, "ATAGC");

            strand1 = "ATAGC";
            strand2 = "ACTAKGC";
            ActualValueDelegate<object> testDelegate = () => dnaCrypto.FindLongestCommonSubSequence(strand1, strand2);
            Assert.That(testDelegate, Throws.TypeOf<Exception>());
        }        
    }
}
