using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatatypesPractice
{
    public  static class Tools
    {
        public static string ToJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static double ExtractNumbers(string input)
        {
            //Regex.Match(input, @"\d+").Value
            // Regular expression pattern to match alphabetic characters
            string pattern = @"\d+";
            // Use Regex.Match to find the first match
            Match match = Regex.Match(input, pattern);
            // If match is found, return the matched value
            if (match.Success)
            {
                return Convert.ToDouble(match.Value);
            }
            // If no match is found, return empty string
            return default(double);
        }

        public static string ExtractAlphaChars(string input)
        {
            
            // Regular expression pattern to match alphabetic characters
            string pattern = "[A-Za-z]+";
            // Use Regex.Match to find the first match
            Match match = Regex.Match(input, pattern);
            // If match is found, return the matched value
            if (match.Success)
            {
                return match.Value;
            }
            // If no match is found, return empty string
            return "";
        }
    }
}
