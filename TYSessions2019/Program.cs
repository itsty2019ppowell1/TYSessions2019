using ActivityTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYSessions2019
{
    class Program
    {
         
    static void Main(string[] args)
        {
            Activity.Track("Exercise 1 started");
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
