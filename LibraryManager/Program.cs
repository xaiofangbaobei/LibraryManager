﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Dl();
            Console.ReadKey();
        }
    }
}
