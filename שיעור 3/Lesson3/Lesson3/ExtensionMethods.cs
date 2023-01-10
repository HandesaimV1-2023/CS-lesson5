using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;

public  static class ExtensionMethods
{
    public static char GetLastLetter(this string s) // זיס סטרינג נכנס כהרחבה למחלקת סטרינג
    {
        return s[s.Length - 1];
    }
    // פונקצית הרחבה שמוסיפה רווחים בין אות לאות
    public static string AddSpaces(this string s)
    {
        string s2 = "";
        foreach (var item in s)
        {
            s2+= item ;
            s2 += ' ';
                
        }
        return s2;
    }

    public static string AddCharacter(this string s , char character)
    {
        string s2 = "";
        foreach (var item in s)
        {
            s2 += item;
            s2 += character;

        }
        return s2;
    }

}
