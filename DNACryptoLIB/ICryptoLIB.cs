namespace DNACryptoLIB
{
    public interface ICryptoLIB
    {
        string FindLongestCommonSubSequence(string strand1, string strand2);
        string GetASCIIFromComplemetaryEncodedText(string encodedText);
        string GetEncryptedText(string inputWords);
        int IsEncryptedTextContainsString(string EncryptedText, string inputASCIIString);
    }
}