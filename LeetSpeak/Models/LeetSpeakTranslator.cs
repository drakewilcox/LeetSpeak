using System;

namespace LeetSpeak
{
  public class LeetSpeakTranslator
  {
    public string TranslateMethod(string userInput)
    {
      
      char[] letterArray = userInput.ToCharArray();
      
    for (int index = 0; index < letterArray.Length; index ++)
    {
      if (letterArray[index] == ' ' && letterArray[index + 1] == 's')
      {
        index += 2;
      }
      else if (letterArray[index] == 'e')
      {
        letterArray[index] = '3';
      }
      else if (letterArray[index] == 'o')
      {
        letterArray[index] = '0';
      }
      else if (letterArray[index] == 'I')
      {
        letterArray[index] = '1';
      }
      else if (letterArray[index] == 't')
      {
        letterArray[index] = '7';
      }
      else if (letterArray[index] == 's')
        letterArray[index] = 'Z';
  
    }
    string result = string.Join("", letterArray);
    return result;
    }
  }
}