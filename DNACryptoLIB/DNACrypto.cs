using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DNACryptoLIB
{
    public class DNACrypto : CryptoLIB
    {
        protected override string GetEncryptedTextFromBinaries(List<string> input)
        {
            string returnDNAText = "";

            foreach (string s in input)
            {
                if (s.Length != 8)
                {
                    throw new Exception("DNA-GetEncryptedText: Binary Length Must Be 8");
                }

                string tempKey;
                string tempValue;
                for (int i = 0; i < 8; i += 2)
                {
                    tempKey = s.Substring(i, 2);
                    if (DNACodeDictionary.TryGetValue(tempKey, out tempValue))
                    {
                        returnDNAText += tempValue;
                    }
                    else
                    {
                        throw new Exception(string.Format("DNA-GetEncryptedText: Input {0} Is Not Valid", tempKey));
                    }
                }
            }

            return returnDNAText;
        }

        public override string GetASCIIFromComplemetaryEncodedText(string encodedText)
        {
            if (string.IsNullOrEmpty(encodedText))
                throw new Exception("GetASCIIFromComplemetaryEncodedText: Input Text Cannot Be Empty");
            if (encodedText.Length % 4 != 0)
                throw new Exception("GetASCIIFromComplemetaryEncodedText: Input Text Length Must Be Multiple of 4");

            string ASCII = "";

            if (Regex.IsMatch(encodedText, "^[ATGC]+$"))
            {
                for (int i = 0; i < encodedText.Length; i += 4)
                {
                    string DNAWord = "";
                    for (int h = i; h < i + 4; h++)
                    {
                        DNAWord += GetComplimentChar(encodedText[h]);
                    }
                   
                    int result = GetIntegerFromEnCodeWord(DNAWord);
                    ASCII += Convert.ToChar(result);
                }               
                return ASCII;
            }
            else
            {
                throw new Exception("GetASCIIFromComplemetaryEncodedText: Input Text Should Only Contains A, T, G, or C");
            }
        }

        private char GetComplimentChar(char inputChar)
        {
            switch(inputChar)
            {
                case 'A':
                    return 'T';
                case 'T':
                    return 'A';
                case 'G':
                    return 'C';
                case 'C':
                    return 'G';
                default:
                    throw new Exception(string.Format("GetComplimentChar: Invalid Input {0}", inputChar));
            }
        }

        private int GetIntegerFromEnCodeWord(string word)
        {
            if (word.Length == 4)
            {
                string temp = "";
                for (int i = 0; i < 4; i++)
                {
                    temp += DNACodeDictionary.FirstOrDefault(x => x.Value.Equals(word[i].ToString())).Key;
                }
                int returnValue;
                // Make sure it is integer
                if (Int32.TryParse(temp, out returnValue))
                {
                    //Convert binary string to decimal 
                    return Convert.ToInt32(temp, 2);
                }
                else
                {
                    throw new Exception(string.Format("GetIntegerFromEnCodeWord: Cannot Convert {0} To Integer", temp));
                }
            }
            throw new Exception("GetIntegerFromEnCodeWord: Encode Word Length Must Be 4");
        }

    }
}
