using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNACryptoLIB
{
    public class RNACrypto : CryptoLIB
    {     
        protected override string GetEncryptedTextFromBinaries(List<string> input)
        {
            string returnDNAText = "";

            foreach (string s in input)
            {
                if (s.Length != 8)
                {
                    throw new Exception("RNA-GetEncryptedText: Binary Length Must Be 8");
                }

                string tempKey;
                string tempValue;
                for (int i = 0; i < 8; i += 2)
                {
                    tempKey = s.Substring(i, 2);
                    if (RNACodeDictionary.TryGetValue(tempKey, out tempValue))
                    {
                        returnDNAText += tempValue;
                    }
                    else
                    {
                        throw new Exception(string.Format("RNA-GetEncryptedText: Input {0} Is Not Valid", tempKey));
                    }
                }
            }

            return returnDNAText;
        }

        public override string GetASCIIFromComplemetaryEncodedText(string encodedText)
        {
            throw new NotImplementedException();
        }
    }
}
