﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAMBackend
{
    class Barbeque : Menu , Iconditional2
    {
        public override void Make()
        {
            Console.WriteLine("Wait 25 minets...");
        }
    }
}
