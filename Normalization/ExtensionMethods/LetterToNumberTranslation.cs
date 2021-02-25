using Normalization.Utilis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Normalization.ExtensionMethods
{
    public static class LetterToNumberTranslation
    {
        public static string ToNumberString(this string data)
        {
            int number;
            var charArray = data.ToUpper().ToCharArray();
            List<char> convertedLetters = new List<char>();
            var lettersFounded = string.Concat(data.ToUpper().Where(x => !int.TryParse(x.ToString(), out number) 
            && !char.IsPunctuation(x)).Select(x => x.ToString().Trim())).ToList();

            lettersFounded.ForEach(x => convertedLetters.Add(NumbersSimilarToWords.dic[x]));
           
            for (int i = 0; i < convertedLetters.Count; i++)
            {
                var foundedCharacter= charArray.Where(x => x == lettersFounded[i]).FirstOrDefault();
                var index = Array.IndexOf(charArray, foundedCharacter);
                
               charArray[index] = convertedLetters[i]; 
            }

            return string.Concat(charArray);

        } 
    }
}
