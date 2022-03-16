using System;
using System.Diagnostics;

namespace GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("search word is invalid");
                return;
            }
            string query = string.Join(" ", args);
            string encoded = System.Web.HttpUtility.UrlEncode(query);
            string url = "https://www.google.com/search?q=" + encoded + "&btnI";
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };
            Process.Start(pi);
        }
    }
}