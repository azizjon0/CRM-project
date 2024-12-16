using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_App
{
    //Contains consts and functions which are used by multiple classes
    internal class global
    {
        //Controls the default colour of certain search boxes
        //Note - This value should never be set to black (currently no error checking in place for this)
        public static Color DefaultSearchBoxColour = Color.Gray;


        //If any string within "terms" contains the string within "search", then returns true. Otherwise, returns false
        //Note: Strings do not need to exactly match, the search string just needs to be contained within a term. e.g. "Username" contains the string "name", so it would return true.
        public static bool CheckSearchTerm(string[] terms, string search)
        {
            foreach (string term in terms)
            {
                if (term.Contains(search))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
