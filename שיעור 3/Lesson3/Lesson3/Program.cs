// See https://aka.ms/new-console-template for more information
using Lesson3;
//Action
//Predicate
//Comparison
public delegate void example1(string s);
public class Program
{
    
   static  void  f1(string s)
    {
        Console.WriteLine("1----->");
        Console.WriteLine(s+"2");
        Console.WriteLine(s.AddCharacter(','));
        Console.WriteLine(s.AddSpaces());
    }

    public static int CompareStrsByLength(string s1,string s2) // זאת פונקציה מסוג קומפרשן
    {
       
        return s1.Length - s2.Length;
    }
    public static int CompareStrsByLastLetter(string s1, string s2)
    {
        
       // return s1[s1.Length - 1] - s2[s2.Length-1];
       return (s1.GetLastLetter() - s2.GetLastLetter());
      //  return (s1.GetLastLetter(s1) - s2.GetLastLetter(s2));

    }
    public static bool CheckStartWithA(string s)
    {
        return s[0] == 'A';
    }
    public static void Main()
    {
        Console.WriteLine("s--today------>");
        string s = "today";
        s = s.AddSpaces();
        Console.WriteLine(s);
        s = s.AddCharacter('*');//  addCharacters(s,"*")
        Console.WriteLine(s);

        int x;
        example1 func; // הגדרת משתנה שמכיל מצביעים= כתובות לפונקציות
        x = 5;
        // שם של פונקציה הוא בסהכ כתובת ולכן מותר להציב כתובת בתוך משתנה
        // error func = Main;
        func= Console.WriteLine;// כאן לא מפעילים את הפונקציה אלא רק מציבים את כתובת הפונקציה במשתנה אחר
                                // כמו שמשתנה אפשר להציב לו ערך רק מהסוג שלו כך גם בפונקציות
        Console.WriteLine("you are!");
        Console.WriteLine("func----->");
        func("you");  // כאן יש הפעלה של הפונקציה
        Console.WriteLine("func+f1----->");
        func += f1;
        
        func("abcd"); // כאן מזמנים שתי פונקציות אחת אחרי השניה
        Console.WriteLine("----->");
        func -= f1;

        func("aaaa");
        Console.WriteLine("----->");
        Console.WriteLine("Hello, World!");


        List<string> strs = new List<string>() { "sara", "rachel", "ruth", "neomi" };
        // מיון לפי האותיות 
        strs.Sort();
        Console.WriteLine("-----------");
        foreach (string str in strs)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("-----------");
        strs.Find(CheckStartWithA);// כאן מפעילים את פינד ולא את הפרמטר
        
        foreach (var item in strs)
        {
            Console.WriteLine(item);
        }


        // איך נמין לפי אורך המילה?
        strs.Sort(CompareStrsByLength); // כאן מז\מנים את סורט ולא את קומפרבי
        // איך נמין לפי האות האחרונה? 
        strs.Sort(CompareStrsByLastLetter);


    }
  }