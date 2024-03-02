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


}
