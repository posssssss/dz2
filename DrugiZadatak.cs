using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.cistKod
{
    class DrugiZadatak
    {
        public static List<char> uniqueChars(string text)
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                int occurrenceCount = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        occurrenceCount++;
                    }
                }
                if (occurrenceCount == 1)
                {
                    chars.Add(text[i]);
                }
            }
            return chars;
        }
    }


}
class DrugiZadatakRJEŠENJE
{
    public static char OccurrenceCharCounter(string text, char slovo)
    {
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (slovo == text[i])
            {
                counter++;
            }
        }
        return counter;
    }

    public static List<char> UniqueChars(string text)
    { 
        List<char> chars = new List<char>();
        for (int i = 0; i < text.Length; i++)
        {
            chars.Add(OccurrenceCharCounter(text,text[i]));
        }
        return chars;
    }

        
}
