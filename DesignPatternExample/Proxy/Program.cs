﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subject o = new Proxy();
            o.Request();

            Console.WriteLine();

        }
    }
}
