using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            // TODO
            var titleExpression = new Regex(@"Title\: (.*),+");

            var match = titleExpression.Match(str);

            if (!match.Success)
            {
                return "Title not found";
            }
            else
            {
                return match.Groups[1].Value;
            }
         
        }

        public static string GetType(string str)
        {

            var typeExpression = new Regex(@"Type\: (.*),Title\: (.*),");

            var match = typeExpression.Match(str);

            if (!match.Success)
            {
                return "No type found";
            }
            else
            {
                return match.Groups[1].Value;
            }

        }
                    
            public static string GetLength(string str)
        {
            

            var lengthExpression = new Regex(@",Length\: (.*)");

            var match = lengthExpression.Match(str);

           
            if (!match.Success)
            {
                return "No type found";
            }
            else
            {
                return match.Groups[1].Value;
            }




        }

        public static bool IsValidLine(string str)
        {
            

        
            var validExpression = new Regex(@"Type\:.*,Title\:.*Length\:.*");

            var match = validExpression.Match(str);

            
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }



        }
    }
}
