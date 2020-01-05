using System;
using System.Text;

namespace Hw_08
{
    class Task1
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = "1a!2.3!!.. 4.!.?6? 7! ..?";
            Console.WriteLine($"Before editing:\n{str}");
            string[] str1 = str.Split('?', 2);
            sb.Append(str1[0]);
            sb.Replace("!", "");
            sb.Replace(".", "");
            string str2 = sb.ToString();
            sb.Clear();
            sb.Append(str1[1]);
            sb.Replace(" ", "_");
            string str3 = sb.ToString();
            sb.Clear();
            sb.AppendJoin('?', str2, str3);
            str = sb.ToString();
            Console.WriteLine($"After editing:\n{str}");
        }
    }
}
