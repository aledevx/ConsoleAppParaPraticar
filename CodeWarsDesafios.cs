using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

    /// <summary>
    /// This time no story, no theory. The examples below show you how to write function accum:
    /// Examples:
    /// accum("abcd") -> "A-Bb-Ccc-Dddd"
    /// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    /// accum("cwAt") -> "C-Ww-Aaa-Tttt"
    /// </summary>
    public String Accum(string s)
    {
        List<string> letterList = new List<string>();

        for (int x = 0; x <= s.Length - 1; x++)
        {
            char[] charList = new char[x + 1];

            for (int y = 1; y <= x + 1; y++)
            {
                string letter = s[x].ToString();
                if (y != 1)
                {
                    charList[y - 1] = Convert.ToChar(letter.ToLower());
                }
                else
                {
                    charList[y - 1] = Convert.ToChar(letter.ToUpper());
                }
            }
            letterList.Add(new string(charList));
        }

        var result = string.Join("-", letterList);

        return result;

    }
    ///<summary>
    ///Write a function that accepts an array of 10 integers (between 0 and 9), that returns a
    ///string of those numbers in the form of a phone number.
    ///returns "(123) 456-7890"
    ///</summary>
    public string CreatePhoneNumber(int[] numbers)
    {
        char[] mask = new char[] { '(', 'x', 'x', 'x', ')', ' ', 'x', 'x', 'x', '-', 'x', 'x', 'x', 'x' };

        int checkpoint = 0;

        for (int x = 0; x <= mask.Length - 1; x++)
        {
            if (mask[x] == 'x')
            {
                mask[x] = Convert.ToChar(numbers[checkpoint].ToString());
                checkpoint++;
            }
        }

        var phoneNumber = String.Join("", mask);

        return phoneNumber;

        //Interesting solution from the community
        //return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
    }
}
