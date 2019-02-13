using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Translator
{
  public class LeetspeakTranslator
  {
    public string Translate(string str)
    {
      char[] array = str.ToCharArray();

      for (int i = 0; i < array.Length; i++)
      {
          if ((array[i] == 'e') || (array[i] == 'E'))
          {
            array[i] = '3';
          }
          else if ((array[i] == 'o') || (array[i] == 'O'))
          {
            array[i] = '0';
          }
          else if (array[i] == 'I')
          {
            array[i] = '1';
          }
          else if ((array[i] == 't') || (array[i] == 'T'))
          {
            array[i] = '7';
          }
          else if ((array[i] == 's') || (array[i] == 'S')){
            if ((i > 0) && (!(Regex.IsMatch(array[i - 1].ToString(), "[^A-Za-z0-9]+$"))))
            {
              array[i] = 'z';
            }
          }
      }
      string result = string.Join("", array);
      return result;
    }

    public static void Main()
    {
      Console.WriteLine("Enter a phrase to translate into Leetspeak:");
      string input = Console.ReadLine();
      LeetspeakTranslator translator = new LeetspeakTranslator();

      Console.WriteLine(translator.Translate(input));
    }
  }
}
