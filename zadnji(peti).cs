using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.cistKod
{
    class DrugiZadatak_peti_
    {
        public List<string> palindromes(List<string> strings)
        {
            List<string> res = new List<string>();
            if (strings == null) return res;
            foreach (string str in strings)
            {
                string temp1 = str.Replace(" ", "").ToLower();
                string temp2 = new string(temp1.Reverse().ToArray());
                //Palindromee
                if (temp1.Equals(temp2))
                {
                    res.Add(str);
                }
            }
            return res;
        }
    }
}
class DrugiZadatak_peti_RJEŠENJE
{

    public List<string> FindPalindromes(List<string> strings)
    { 
        List<string[]> palindromes = new List<string[]>();

        if (strings == null)
        {
            return palindromes;
        }

        foreach (string text in strings)
        {
            if (IsPalindrome(text))
            {
                palindromes.Add(text);
            }

        }
        return palindromes;
    }
    public bool IsPalindrome(string text)
    { 
        if(string.IsNullOrEmpty(text)) return false;

        string trimmedString = text.Replace(" ", "").ToLower();
        string reversedString = new string(trimmedString.Reverse().ToArray());
        return reversedString.Equals(trimmedString);
    }
}
