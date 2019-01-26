using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DNACryptoLIB
{
    public abstract class CryptoLIB : ICryptoLIB
    {
        protected Dictionary<string, string> DNACodeDictionary = new Dictionary<string, string>()
        {
            { "00", "A" },
            { "01", "T" },
            { "10", "G" },
            { "11", "C" },
        };

        protected Dictionary<string, string> RNACodeDictionary = new Dictionary<string, string>()
        {
            { "00", "A" },
            { "01", "U" },
            { "10", "G" },
            { "11", "C" },
        };
        // Objective 1 and 2 : DNACrypto and RNACrypto
        /// <summary>
        /// Get encoded text for input string
        /// </summary>
        /// <param name="inputWords">ASCII string input</param>
        /// <returns>Encoded Text</returns>
        public string GetEncryptedText(string inputWords)
        {
            List<string> binaryValues = ConvertToBinariesFromString(inputWords);
            return GetEncryptedTextFromBinaries(binaryValues);           
        }

        // Objective 3
        /// <summary>
        /// Check if the encoded DNA Text contains the value of the
        /// input ASCII string
        /// </summary>
        /// <param name="EncryptedText">DNA Strand</param>
        /// <param name="inputASCIIString">Search ASCII value</param>
        /// <returns>Return -1 if it does not find the ASCII input string in the
        /// encoded text. Otherwise, return start index of the string in DNA encoded text</returns>
        public int IsEncryptedTextContainsString(string EncryptedText, string inputASCIIString)
        {
            if (string.IsNullOrEmpty(EncryptedText))
                throw new Exception("IsEncryptedTextContainsString: Encrypted Text Cannot Be Empty");
            if (EncryptedText.Length % 4 != 0)
                throw new Exception("IsEncryptedTextContainsString: Encrypted Text Length Must Be Multiple of 4");
            if (!Regex.IsMatch(EncryptedText, "^[ATGC]+$"))
            {
                throw new Exception("IsEncryptedTextContainsString: Encrypted Text Should Only Contains A, T, G, or C");
            }

            string searchText = GetEncryptedText(inputASCIIString);

            int index = EncryptedText.IndexOf(searchText);

            return index;
        }

        //Objective 4
        /// <summary>
        /// Get ASCII Text From Complementary DNA input strand
        /// This abstract method is implemented in DNACrypto subclass
        /// </summary>
        /// <param name="encodedText">Complementary DNA Input strand</param>
        /// <returns>ASCII string</returns>
        public abstract string GetASCIIFromComplemetaryEncodedText(string encodedText);

        //Objective 5
        /// <summary>
        /// Get the Longest Common Sequence string from 2 DNA strands
        /// </summary>
        /// <param name="strand1">DNA Strand 1</param>
        /// <param name="strand2">DNA Strand 2</param>
        /// <returns>LCS string</returns>
        public string FindLongestCommonSubSequence(string strand1, string strand2)
        {    
            if(string.IsNullOrEmpty(strand1) || string.IsNullOrEmpty(strand2))
            {
                throw new Exception(string.Format("FindLongestCommonSubSequence: Input Strands Cannot Be Empty"));
            }

            if (!Regex.IsMatch(strand1, "^[ATGC]+$") || !Regex.IsMatch(strand2, "^[ATGC]+$"))
            {
                throw new Exception(string.Format("FindLongestCommonSubSequence: Input Strands Should Only Contains A, T, G, or C"));
            }

            int[,] l = new int[strand1.Length+1, strand2.Length+1];
            int lcs = 0;
            string substr = string.Empty;            

            for (int i = 0; i <= strand1.Length; i++)
            {
                for (int h = 0; h <= strand2.Length; h++)
                {
                    // Fill 0s for 1st row and column
                    if(i==0 || h ==0)
                    {
                        l[i, h] = 0;
                    }
                    else
                    {
                        if (strand1[i - 1] == strand2[h - 1])
                        {
                            // Assign current cell value by adding the top left cell value by 1
                            l[i, h] = l[i - 1, h - 1] + 1;

                            //Keep track of the longest value and its pointer
                            if (l[i, h] > lcs)
                            {
                                lcs = l[i, h];
                                substr += strand1[i-1];                                
                            }
                        }
                        else
                        {
                            /* Assign current cell value to Max value of 
                            *  the cell on the top or the cell on the left*/
                            l[i, h] = l[i - 1, h] > l[i, h - 1] ? l[i - 1, h] : l[i, h - 1];
                        }
                    }                    
                }
            } 
            //Console.WriteLine("LCS Length = {0}, LCS = {1}", lcs, substr);
            return substr;
        }
          

        /// <summary>
        /// Get encoded text from the list of 8 bits binary inputs
        /// Each 8 bits represent for a character.
        /// This abstract method is implemented in DNACrypto and
        /// RNACrypto subclass for polymorphism behavior. 
        /// </summary>
        /// <param name="input">List of 8 bits binary format string</param>
        /// <returns>Encoded Text</returns>
        protected abstract string GetEncryptedTextFromBinaries(List<string> input);


        /// <summary>
        /// Get list of binary value strings for the input words
        /// </summary>
        /// <param name="inputWords">ASCII string</param>
        /// <returns>List of 8 bits binary </returns>
        private List<string> ConvertToBinariesFromString(string inputWords)
        {
            List<string> returnValues = new List<string>();
            byte[] bytes = null;

            if (string.IsNullOrEmpty(inputWords))
            {
                bytes = new byte[] { 0x00 };
            }
            else
            {
                bytes = Encoding.ASCII.GetBytes(inputWords);
            }

            string binValue;
            foreach (byte b in bytes)
            {
                binValue = Convert.ToString(b, 2);
                // Make sure they have the length of 8
                if(binValue.Length < 8)
                {
                    int leadingZeroNeed = 8 - binValue.Length;
                    for(int i=0; i < leadingZeroNeed; i++)
                    {
                        binValue = '0' + binValue;
                    }
                }
                returnValues.Add(binValue);
            }
            return returnValues;
        }   

    }
}
