using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
       public bool IsAPalindrome(string word)
        {
            var backwords = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                backwords += word.ToLower()[i];
            }
            if (backwords == word.ToLower())
            {
                return true;
            }
          //  if (word == "")
          //  {
          //      return false;
          //  }
            else
            {
                return false;
            }

        }
    }
}
