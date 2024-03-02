using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppParaPraticar;

public class CodeWarsDesafios
{

    ///<summary>
    ///Write a function that takes in a string of one or more words, and returns the same string,
    ///but with all words that have five or more letters reversed (Just like the name of this Kata).
    ///Strings passed in will consist of only letters and spaces. Spaces will be included only when
    ///more than one word is present.
    /// </summary>
    public string StopSpinningMyWords(string sentence)
    {
        string[] wordList = sentence.Split(' ');

        for (int x = 0; x < wordList.Length; x++)
        {
            if (wordList[x].Length > 4)
            {
                char[] invertedWord = wordList[x].ToCharArray().Reverse().ToArray();
                wordList[x] = new string(invertedWord);
            }
        }

        var result = String.Join(" ", wordList);
        return result;
    }

    ///<summary>
    ///Usually when you buy something, you're asked whether your credit card number, phone number or answer
    ///to your most secret question is still correct. However, since someone could look over your shoulder,
    ///you don't want that shown on your screen. Instead, we mask it.
    ///Your task is to write a function maskify, which changes all but the last four characters into '#'.
    ///</summary>
    public string Maskify(string cc)
    {
        if (cc.Length < 5)
        {
            return cc;
        }

        char[] masked = cc.ToCharArray();

        for (int x = 0; x < masked.Length - 4; x++)
        {
            masked[x] = '#';
        }

        return new string(masked);
    }
    ///<summary>
    ///Your task is to make a function that can take any non-negative integer as an argument and return
    ///it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.
    ///</summary>
    public int DescendingOrder(int num)
    {

        var numString = num.ToString();

        var numChar = numString.ToCharArray();

        char aux = '0';

        for (int x = 0; x <= numChar.Length - 2; x++)
        {
            for (int y = x + 1; y <= numChar.Length - 1; y++)
            {
                int val1 = (int)Char.GetNumericValue(numChar[x]);
                int val2 = (int)Char.GetNumericValue(numChar[y]);
                if (val1 < val2)
                {
                    aux = numChar[x];
                    numChar[x] = numChar[y];
                    numChar[y] = aux;
                }
            }
        }

        var result = Int32.Parse(numChar);

        return result;
    }

    public String Accum(string s)
    {
        List<string> lista = new List<string>();

        for (int x = 0; x <= s.Length - 1; x++)
        {
            Console.WriteLine(s[x]);
            lista.Add(s[x].ToString());

        }

        return "";

    }

}
