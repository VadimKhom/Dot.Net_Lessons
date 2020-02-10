﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadeCalculationsLibrary
{
    public class FirstCascade
    {
        public delegate bool Check(int value);
        public event Check Stop;

        public FirstCascade()
        {
            
        }

        public int Calculate(int value)
        {
            if (!Stop(value))
            {
                return value + 1;
            }
            else {
                return value;
            }
        }
    }
}
