using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
          Func<bool> boolfunc= () => true;
          Func<int,bool> intfunc = (x) =>x<10;
          if(boolfunc() && intfunc(5))
            {
              Console.WriteLine("5<10");
            }
        }
    }
}