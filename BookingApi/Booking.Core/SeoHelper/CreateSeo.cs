using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CorePackage.SeoHelper
{
    public static class CreateSeo
    {
        public static string CreateSeoUrl(string input, string language)
        {
            // Convert the input string to lowercase
            input = input.ToLowerInvariant();

            // Convert Turkish special characters to their ASCII equivalent
            if (language == "tr")
            {
                input = input.Replace("ç", "c").Replace("ğ", "g").Replace("ı", "i").Replace("ö", "o").Replace("ş", "s").Replace("ü", "u");
            }

            // Convert Russian Cyrillic characters to their ASCII equivalent
            if (language == "ru")
            {
                input = input.Replace("а", "a").Replace("б", "b").Replace("в", "v").Replace("г", "g").Replace("д", "d").Replace("е", "e").Replace("ё", "yo").Replace("ж", "zh").Replace("з", "z").Replace("и", "i").Replace("й", "y").Replace("к", "k").Replace("л", "l").Replace("м", "m").Replace("н", "n").Replace("о", "o").Replace("п", "p").Replace("р", "r").Replace("с", "s").Replace("т", "t").Replace("у", "u").Replace("ф", "f").Replace("х", "kh").Replace("ц", "ts").Replace("ч", "ch").Replace("ш", "sh").Replace("щ", "sch").Replace("ъ", "").Replace("ы", "y").Replace("ь", "").Replace("э", "e").Replace("ю", "yu").Replace("я", "ya");
            }

            // Convert Azerbaijani special characters to their ASCII equivalent
            if (language == "az")
            {
                input = input.Replace("ə", "e").Replace("ı", "i").Replace("ö", "o").Replace("ş", "s").Replace("ü", "u").Replace("ç", "c").Replace("ğ", "g");
            }

            // Replace any remaining non-letter or non-digit character with a hyphen
            input = Regex.Replace(input, @"[^a-z0-9]", "-");

            // Remove any leading or trailing hyphens
            input = input.Trim('-');

            // Append the number to the end of the string
            var output = $"{input}";

            // Return the resulting string
            return output;
        }

    }
}