﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo
{
    public class Dog
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
