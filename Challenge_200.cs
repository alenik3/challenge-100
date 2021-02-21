using System;
using System.Text;

public class Challenge_200
{
    static string Maskify(string s)
    {
        return ReplacingBackCharacters(s, 4, '#');
    }

    static string ReplacingBackCharacters(string s, int i, char charToReplace)
    {
        if (string.IsNullOrEmpty(s)) return "";
        // empty. return, throw whatever.

        string returnString = "";
        int length = s.Length;
        string endString, tmpString;

        if (length < i)
            return s;
        try
        {
            endString = s.Substring(length - i, i);
            tmpString = s.Substring(0, length - i + 1);

            StringBuilder sb = new StringBuilder(tmpString);

            foreach (var c in tmpString.ToCharArray()) { sb.Replace(c, charToReplace); }

            returnString = sb.ToString() + endString;

        }
        catch (ArgumentException e)
        {
            //throw whatever
        }

        return returnString;
    }

    static int Potatoes(string s)
    {
        int potatoesCount = 0;
        string strPotatoe = "potato";

        char[] charArr = s.ToCharArray();
        char[] charArrPotatoe = strPotatoe.ToCharArray();
        int potLenght = strPotatoe.Length;

        int countOfMatches = 0;

        foreach (char ch in charArr)
        {
            if (ch == charArrPotatoe[countOfMatches])
            {
                countOfMatches++;
            }
            if (potLenght == countOfMatches)
            {
                potatoesCount++;
                countOfMatches = 0;
            }
        }

        return potatoesCount;
    }
}
